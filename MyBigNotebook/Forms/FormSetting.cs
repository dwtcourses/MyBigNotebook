﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace MyBigNotebook.Forms
{
    public partial class FormSetting : Form
    {
        
        public FormSetting()
        {
            InitializeComponent();
            textBoxGoogleUser.Text = ConfigurationManager.AppSettings.Get("GoogleUser");
            checkBoxAutoSave.Checked = Convert.ToBoolean(ConfigurationManager.AppSettings.Get("AutoSave"));
            numericUpDownsaveTime.Value = Convert.ToInt32(ConfigurationManager.AppSettings.Get("TimeAutoSave"));
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            configuration.AppSettings.Settings["GoogleUser"].Value = textBoxGoogleUser.Text;
            configuration.AppSettings.Settings["AutoSave"].Value = checkBoxAutoSave.Checked.ToString();
            configuration.AppSettings.Settings["TimeAutoSave"].Value = numericUpDownsaveTime.Value.ToString() ;
            configuration.Save();
            this.DialogResult = DialogResult.OK;
        }
    }
}
