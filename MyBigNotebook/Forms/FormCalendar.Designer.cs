﻿namespace MyBigNotebook
{
    partial class FormCalendar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalendar));
            this.monthCalendarMain = new System.Windows.Forms.MonthCalendar();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.textBoxDayInfo = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAddBirthDay = new System.Windows.Forms.ToolStripButton();
            this.tbAddMemorable = new System.Windows.Forms.ToolStripButton();
            this.tbAddReminder = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButtondelete = new System.Windows.Forms.ToolStripSplitButton();
            this.удалитьДеньРожденияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьПамяьнуюДатуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьНапоминанияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelInfo.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendarMain
            // 
            this.monthCalendarMain.CalendarDimensions = new System.Drawing.Size(4, 1);
            this.monthCalendarMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.monthCalendarMain.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendarMain.Location = new System.Drawing.Point(0, 0);
            this.monthCalendarMain.MaxSelectionCount = 1;
            this.monthCalendarMain.Name = "monthCalendarMain";
            this.monthCalendarMain.ScrollChange = 1;
            this.monthCalendarMain.ShowToday = false;
            this.monthCalendarMain.ShowTodayCircle = false;
            this.monthCalendarMain.TabIndex = 0;
            this.monthCalendarMain.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarMain_DateSelected);
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.textBoxDayInfo);
            this.panelInfo.Controls.Add(this.toolStrip1);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfo.Location = new System.Drawing.Point(0, 162);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(668, 212);
            this.panelInfo.TabIndex = 2;
            // 
            // textBoxDayInfo
            // 
            this.textBoxDayInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDayInfo.Location = new System.Drawing.Point(0, 25);
            this.textBoxDayInfo.Name = "textBoxDayInfo";
            this.textBoxDayInfo.ReadOnly = true;
            this.textBoxDayInfo.Size = new System.Drawing.Size(668, 187);
            this.textBoxDayInfo.TabIndex = 1;
            this.textBoxDayInfo.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddBirthDay,
            this.tbAddMemorable,
            this.tbAddReminder,
            this.toolStripSeparator1,
            this.toolStripSplitButtondelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(668, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAddBirthDay
            // 
            this.tsbAddBirthDay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddBirthDay.Image = global::MyBigNotebook.Properties.Resources.baseline_cake_black_36dp;
            this.tsbAddBirthDay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddBirthDay.Name = "tsbAddBirthDay";
            this.tsbAddBirthDay.Size = new System.Drawing.Size(23, 22);
            this.tsbAddBirthDay.Text = "Добавить день рождения";
            this.tsbAddBirthDay.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tbAddMemorable
            // 
            this.tbAddMemorable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbAddMemorable.Image = global::MyBigNotebook.Properties.Resources.baseline_add_black_36dp;
            this.tbAddMemorable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbAddMemorable.Name = "tbAddMemorable";
            this.tbAddMemorable.Size = new System.Drawing.Size(23, 22);
            this.tbAddMemorable.Text = "Добавить памятную дату";
            this.tbAddMemorable.Click += new System.EventHandler(this.tbAddMemorable_Click);
            // 
            // tbAddReminder
            // 
            this.tbAddReminder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbAddReminder.Image = global::MyBigNotebook.Properties.Resources.baseline_add_alert_black_36dp;
            this.tbAddReminder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbAddReminder.Name = "tbAddReminder";
            this.tbAddReminder.Size = new System.Drawing.Size(23, 22);
            this.tbAddReminder.Text = "Добавить напоминание";
            this.tbAddReminder.Click += new System.EventHandler(this.tbAddReminder_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSplitButtondelete
            // 
            this.toolStripSplitButtondelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButtondelete.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьДеньРожденияToolStripMenuItem,
            this.удалитьПамяьнуюДатуToolStripMenuItem,
            this.удалитьНапоминанияToolStripMenuItem});
            this.toolStripSplitButtondelete.Image = global::MyBigNotebook.Properties.Resources.baseline_delete_sweep_black_36dp;
            this.toolStripSplitButtondelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtondelete.Name = "toolStripSplitButtondelete";
            this.toolStripSplitButtondelete.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButtondelete.Text = "Удалить на выбранную дату";
            // 
            // удалитьДеньРожденияToolStripMenuItem
            // 
            this.удалитьДеньРожденияToolStripMenuItem.Name = "удалитьДеньРожденияToolStripMenuItem";
            this.удалитьДеньРожденияToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.удалитьДеньРожденияToolStripMenuItem.Text = "Удалить день рождения";
            this.удалитьДеньРожденияToolStripMenuItem.Click += new System.EventHandler(this.удалитьДеньРожденияToolStripMenuItem_Click);
            // 
            // удалитьПамяьнуюДатуToolStripMenuItem
            // 
            this.удалитьПамяьнуюДатуToolStripMenuItem.Name = "удалитьПамяьнуюДатуToolStripMenuItem";
            this.удалитьПамяьнуюДатуToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.удалитьПамяьнуюДатуToolStripMenuItem.Text = "Удалить памятную дату";
            this.удалитьПамяьнуюДатуToolStripMenuItem.Click += new System.EventHandler(this.удалитьПамяьнуюДатуToolStripMenuItem_Click);
            // 
            // удалитьНапоминанияToolStripMenuItem
            // 
            this.удалитьНапоминанияToolStripMenuItem.Name = "удалитьНапоминанияToolStripMenuItem";
            this.удалитьНапоминанияToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.удалитьНапоминанияToolStripMenuItem.Text = "Удалить напоминания";
            this.удалитьНапоминанияToolStripMenuItem.Click += new System.EventHandler(this.удалитьНапоминанияToolStripMenuItem_Click);
            // 
            // FormCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 374);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.monthCalendarMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCalendar";
            this.Text = "Календарь";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCalendar_FormClosed);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendarMain;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAddBirthDay;
        private System.Windows.Forms.ToolStripButton tbAddMemorable;
        private System.Windows.Forms.ToolStripButton tbAddReminder;
        private System.Windows.Forms.RichTextBox textBoxDayInfo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtondelete;
        private System.Windows.Forms.ToolStripMenuItem удалитьДеньРожденияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьПамяьнуюДатуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьНапоминанияToolStripMenuItem;
    }
}