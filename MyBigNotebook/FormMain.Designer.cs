﻿namespace MyBigNotebook
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCalendar = new System.Windows.Forms.Button();
            this.buttonDiary = new System.Windows.Forms.Button();
            this.buttonFinansial = new System.Windows.Forms.Button();
            this.buttonInformation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCalendar
            // 
            this.buttonCalendar.Location = new System.Drawing.Point(29, 13);
            this.buttonCalendar.Name = "buttonCalendar";
            this.buttonCalendar.Size = new System.Drawing.Size(175, 23);
            this.buttonCalendar.TabIndex = 0;
            this.buttonCalendar.Text = "Календарь";
            this.buttonCalendar.UseVisualStyleBackColor = true;
            this.buttonCalendar.Click += new System.EventHandler(this.buttonCalendar_Click);
            // 
            // buttonDiary
            // 
            this.buttonDiary.Location = new System.Drawing.Point(29, 43);
            this.buttonDiary.Name = "buttonDiary";
            this.buttonDiary.Size = new System.Drawing.Size(175, 23);
            this.buttonDiary.TabIndex = 1;
            this.buttonDiary.Text = "Дневник";
            this.buttonDiary.UseVisualStyleBackColor = true;
            this.buttonDiary.Click += new System.EventHandler(this.buttonDiary_Click);
            // 
            // buttonFinansial
            // 
            this.buttonFinansial.Location = new System.Drawing.Point(29, 72);
            this.buttonFinansial.Name = "buttonFinansial";
            this.buttonFinansial.Size = new System.Drawing.Size(175, 23);
            this.buttonFinansial.TabIndex = 2;
            this.buttonFinansial.Text = "Финансовый помошник";
            this.buttonFinansial.UseVisualStyleBackColor = true;
            this.buttonFinansial.Click += new System.EventHandler(this.buttonFinansial_Click);
            // 
            // buttonInformation
            // 
            this.buttonInformation.Location = new System.Drawing.Point(29, 102);
            this.buttonInformation.Name = "buttonInformation";
            this.buttonInformation.Size = new System.Drawing.Size(175, 23);
            this.buttonInformation.TabIndex = 3;
            this.buttonInformation.Text = "Информация";
            this.buttonInformation.UseVisualStyleBackColor = true;
            this.buttonInformation.Click += new System.EventHandler(this.buttonInformation_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 341);
            this.Controls.Add(this.buttonInformation);
            this.Controls.Add(this.buttonFinansial);
            this.Controls.Add(this.buttonDiary);
            this.Controls.Add(this.buttonCalendar);
            this.Name = "FormMain";
            this.Text = "Главное меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCalendar;
        private System.Windows.Forms.Button buttonDiary;
        private System.Windows.Forms.Button buttonFinansial;
        private System.Windows.Forms.Button buttonInformation;
    }
}

