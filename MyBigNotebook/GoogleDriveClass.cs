﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.Windows.Forms;



namespace MyBigNotebook
{
    class GoogleDriveClass
    {
        static string[] Scopes = { DriveService.Scope.DriveFile };  //Массив для работы с файлами
        static string ApplicationName = "MyBigNotebook";      //Наименование программы
        public static UserCredential credential = null;             //Ключи авторизации
        public static string extension = ".xml";


        public bool Authorize()
        {
            using (System.IO.FileStream stream =
                     new System.IO.FileStream("Client.json", System.IO.FileMode.Open, System.IO.FileAccess.Read))
            {
                try
                {
                    string credPath = System.Environment.CurrentDirectory.ToString();
                    credPath = System.IO.Path.Combine(credPath, "drive-bridge.json");

                    credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                        GoogleClientSecrets.Load(stream).Secrets,
                        GoogleDriveClass.Scopes,
                        "dedulkonikita@gmail.com", CancellationToken.None,
                        new FileDataStore(credPath, true)).Result;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    credential = null;
                }

            }
            return (credential != null);
        }


        public bool FileCreate(string name, string value, out string id)
        {
            bool result = false;
            id = null;
            if (credential == null)
                this.Authorize();
            if (credential == null)
            {
                return result;
            }

            using (var service = new Google.Apis.Drive.v3.DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            }))

            {
                var body = new Google.Apis.Drive.v3.Data.File();
                body.Name = name;
                body.MimeType = "text/json";
                body.ViewersCanCopyContent = true;

                byte[] byteArray = Encoding.Default.GetBytes(value);
                using (var stream = new System.IO.MemoryStream(byteArray))
                {
                    Google.Apis.Drive.v3.FilesResource.CreateMediaUpload request = service.Files.Create(body, stream, body.MimeType);
                    if (request.Upload().Exception == null)
                    { id = request.ResponseBody.Id; result = true; }
                }
            }
            return result;
        }

        public bool FileUpdate(string name, string value)
        {
            bool result = false;
            if (credential == null)
                this.Authorize();
            if (credential == null)
            {
                return result;
            }

            string new_id;
            if (FileCreate(name, value, out new_id))
            {
                IList<Google.Apis.Drive.v3.Data.File> files = GetFileList();
                if (files != null && files.Count > 0)
                {
                    result = true;
                    try
                    {
                        using (var service = new DriveService(new BaseClientService.Initializer()
                        {
                            HttpClientInitializer = credential,
                            ApplicationName = ApplicationName,
                        }))
                        {
                            foreach (var file in files)
                            {
                                if (file.Name == name && file.Id != new_id)
                                {
                                    try
                                    {
                                        Google.Apis.Drive.v3.FilesResource.DeleteRequest request = service.Files.Delete(file.Id);
                                        string res = request.Execute();
                                    }
                                    catch (Exception)
                                    {
                                        continue;
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception)
                    {
                        return result;
                    }
                }
            }
            return result;
        }
        public IList<Google.Apis.Drive.v3.Data.File> GetFileList()
        {
            IList<Google.Apis.Drive.v3.Data.File> result = null;
            if (credential == null)
                this.Authorize();
            if (credential == null)
            {
                return result;
            }
            // Create Drive API service.
            using (Google.Apis.Drive.v3.DriveService service = new Google.Apis.Drive.v3.DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            }))
            {
                try
                {
                    // Define parameters of request.
                    FilesResource.ListRequest listRequest = service.Files.List();
                    listRequest.PageSize = 1000;
                    listRequest.Fields = "nextPageToken, files(id, name, size)";

                    // List files.
                    result = listRequest.Execute().Files;
                }
                catch (Exception)
                {
                    return null;
                }
            }
            return result;
        }
        public string GetFileId(string name)
        {
            string result = null;
            IList<Google.Apis.Drive.v3.Data.File> files = GetFileList();

            if (files != null && files.Count > 0)
            {
                foreach (var file in files)
                {
                    if (file.Name == name)
                    {
                        result = file.Id;
                        break;
                    }
                }
            }
            return result;
        }
        public string FileRead(string id)
        {
            if (String.IsNullOrEmpty(id))
            {
                return ("Errore. File not found");
            }
            bool result = false;
            string value = null;
            if (credential == null)
                this.Authorize();
            if (credential != null)
            {
                using (var service = new DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName,
                }))
                {
                    Google.Apis.Drive.v3.FilesResource.GetRequest request = service.Files.Get(id);
                    using (var stream = new MemoryStream())
                    {
                        request.MediaDownloader.ProgressChanged += (Google.Apis.Download.IDownloadProgress progress) =>
                        {
                            if (progress.Status == Google.Apis.Download.DownloadStatus.Completed)
                                result = true;
                        };
                        request.Download(stream);

                        if (result)
                        {
                            int start = 0;
                            int count = (int)stream.Length;
                            value = Encoding.Default.GetString(stream.GetBuffer(), start, count);
                        }
                    }
                }
            }
            return value;
        }
    }

}