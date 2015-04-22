namespace POEditor
{
    partial class FormNewProject
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager (typeof (FormNewProject));
            this.groupBoxProject = new System.Windows.Forms.GroupBox ();
            this.groupBoxLanguages = new System.Windows.Forms.GroupBox ();
            this.buttonOK = new System.Windows.Forms.Button ();
            this.buttonCancel = new System.Windows.Forms.Button ();
            this.buttonReset = new System.Windows.Forms.Button ();
            this.textBoxProjectPath = new System.Windows.Forms.TextBox ();
            this.buttonSelectProjectPath = new System.Windows.Forms.Button ();
            this.textBoxProjectName = new System.Windows.Forms.TextBox ();
            this.labelNameProject = new System.Windows.Forms.Label ();
            this.labelPath = new System.Windows.Forms.Label ();
            this.comboBoxProjectFormat = new System.Windows.Forms.ComboBox ();
            this.labelFormat = new System.Windows.Forms.Label ();
            this.textBoxLanguageName = new System.Windows.Forms.TextBox ();
            this.textBoxLanguagePath = new System.Windows.Forms.TextBox ();
            this.buttonSelectLanguagePath = new System.Windows.Forms.Button ();
            this.listViewLanguages = new System.Windows.Forms.ListView ();
            this.label1 = new System.Windows.Forms.Label ();
            this.label2 = new System.Windows.Forms.Label ();
            this.label3 = new System.Windows.Forms.Label ();
            this.textBoxLanguageFile = new System.Windows.Forms.TextBox ();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader) (new System.Windows.Forms.ColumnHeader ()));
            this.columnHeaderFile = ((System.Windows.Forms.ColumnHeader) (new System.Windows.Forms.ColumnHeader ()));
            this.columnHeaderPath = ((System.Windows.Forms.ColumnHeader) (new System.Windows.Forms.ColumnHeader ()));
            this.buttonSave = new System.Windows.Forms.Button ();
            this.buttonRemove = new System.Windows.Forms.Button ();
            this.panelHeader = new System.Windows.Forms.Panel ();
            this.labelHeader = new System.Windows.Forms.Label ();
            this.labelDescription = new System.Windows.Forms.Label ();
            this.pictureBoxForm = new System.Windows.Forms.PictureBox ();
            this.button1 = new System.Windows.Forms.Button ();
            this.groupBoxProject.SuspendLayout ();
            this.groupBoxLanguages.SuspendLayout ();
            this.panelHeader.SuspendLayout ();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxForm)).BeginInit ();
            this.SuspendLayout ();
            // 
            // groupBoxProject
            // 
            this.groupBoxProject.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxProject.Controls.Add (this.labelFormat);
            this.groupBoxProject.Controls.Add (this.comboBoxProjectFormat);
            this.groupBoxProject.Controls.Add (this.labelPath);
            this.groupBoxProject.Controls.Add (this.labelNameProject);
            this.groupBoxProject.Controls.Add (this.textBoxProjectName);
            this.groupBoxProject.Controls.Add (this.buttonSelectProjectPath);
            this.groupBoxProject.Controls.Add (this.textBoxProjectPath);
            this.groupBoxProject.Location = new System.Drawing.Point (12, 70);
            this.groupBoxProject.Name = "groupBoxProject";
            this.groupBoxProject.Size = new System.Drawing.Size (431, 107);
            this.groupBoxProject.TabIndex = 0;
            this.groupBoxProject.TabStop = false;
            this.groupBoxProject.Text = "Проект";
            // 
            // groupBoxLanguages
            // 
            this.groupBoxLanguages.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxLanguages.Controls.Add (this.button1);
            this.groupBoxLanguages.Controls.Add (this.buttonRemove);
            this.groupBoxLanguages.Controls.Add (this.buttonSave);
            this.groupBoxLanguages.Controls.Add (this.label3);
            this.groupBoxLanguages.Controls.Add (this.textBoxLanguageFile);
            this.groupBoxLanguages.Controls.Add (this.label2);
            this.groupBoxLanguages.Controls.Add (this.label1);
            this.groupBoxLanguages.Controls.Add (this.listViewLanguages);
            this.groupBoxLanguages.Controls.Add (this.buttonSelectLanguagePath);
            this.groupBoxLanguages.Controls.Add (this.textBoxLanguagePath);
            this.groupBoxLanguages.Controls.Add (this.textBoxLanguageName);
            this.groupBoxLanguages.Location = new System.Drawing.Point (12, 183);
            this.groupBoxLanguages.Name = "groupBoxLanguages";
            this.groupBoxLanguages.Size = new System.Drawing.Size (431, 364);
            this.groupBoxLanguages.TabIndex = 1;
            this.groupBoxLanguages.TabStop = false;
            this.groupBoxLanguages.Text = "Языки";
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point (206, 553);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size (75, 23);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point (287, 553);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size (75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReset.Location = new System.Drawing.Point (368, 553);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size (75, 23);
            this.buttonReset.TabIndex = 4;
            this.buttonReset.Text = "Сбросить";
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // textBoxProjectPath
            // 
            this.textBoxProjectPath.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProjectPath.Location = new System.Drawing.Point (103, 74);
            this.textBoxProjectPath.Name = "textBoxProjectPath";
            this.textBoxProjectPath.Size = new System.Drawing.Size (281, 21);
            this.textBoxProjectPath.TabIndex = 0;
            // 
            // buttonSelectProjectPath
            // 
            this.buttonSelectProjectPath.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectProjectPath.Location = new System.Drawing.Point (390, 73);
            this.buttonSelectProjectPath.Name = "buttonSelectProjectPath";
            this.buttonSelectProjectPath.Size = new System.Drawing.Size (27, 23);
            this.buttonSelectProjectPath.TabIndex = 1;
            this.buttonSelectProjectPath.Text = "...";
            this.buttonSelectProjectPath.UseVisualStyleBackColor = true;
            // 
            // textBoxProjectName
            // 
            this.textBoxProjectName.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProjectName.Location = new System.Drawing.Point (103, 20);
            this.textBoxProjectName.Name = "textBoxProjectName";
            this.textBoxProjectName.Size = new System.Drawing.Size (314, 21);
            this.textBoxProjectName.TabIndex = 2;
            // 
            // labelNameProject
            // 
            this.labelNameProject.AutoSize = true;
            this.labelNameProject.Location = new System.Drawing.Point (10, 23);
            this.labelNameProject.Name = "labelNameProject";
            this.labelNameProject.Size = new System.Drawing.Size (59, 13);
            this.labelNameProject.TabIndex = 3;
            this.labelNameProject.Text = "Название:";
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point (10, 77);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size (84, 13);
            this.labelPath.TabIndex = 4;
            this.labelPath.Text = "Расположение:";
            // 
            // comboBoxProjectFormat
            // 
            this.comboBoxProjectFormat.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxProjectFormat.FormattingEnabled = true;
            this.comboBoxProjectFormat.Location = new System.Drawing.Point (103, 47);
            this.comboBoxProjectFormat.Name = "comboBoxProjectFormat";
            this.comboBoxProjectFormat.Size = new System.Drawing.Size (314, 21);
            this.comboBoxProjectFormat.TabIndex = 5;
            // 
            // labelFormat
            // 
            this.labelFormat.AutoSize = true;
            this.labelFormat.Location = new System.Drawing.Point (10, 50);
            this.labelFormat.Name = "labelFormat";
            this.labelFormat.Size = new System.Drawing.Size (49, 13);
            this.labelFormat.TabIndex = 6;
            this.labelFormat.Text = "Формат:";
            // 
            // textBoxLanguageName
            // 
            this.textBoxLanguageName.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLanguageName.Location = new System.Drawing.Point (103, 20);
            this.textBoxLanguageName.Name = "textBoxLanguageName";
            this.textBoxLanguageName.Size = new System.Drawing.Size (314, 21);
            this.textBoxLanguageName.TabIndex = 1;
            // 
            // textBoxLanguagePath
            // 
            this.textBoxLanguagePath.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLanguagePath.Location = new System.Drawing.Point (103, 74);
            this.textBoxLanguagePath.Name = "textBoxLanguagePath";
            this.textBoxLanguagePath.Size = new System.Drawing.Size (281, 21);
            this.textBoxLanguagePath.TabIndex = 2;
            // 
            // buttonSelectLanguagePath
            // 
            this.buttonSelectLanguagePath.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectLanguagePath.Location = new System.Drawing.Point (390, 73);
            this.buttonSelectLanguagePath.Name = "buttonSelectLanguagePath";
            this.buttonSelectLanguagePath.Size = new System.Drawing.Size (27, 23);
            this.buttonSelectLanguagePath.TabIndex = 3;
            this.buttonSelectLanguagePath.Text = "...";
            this.buttonSelectLanguagePath.UseVisualStyleBackColor = true;
            // 
            // listViewLanguages
            // 
            this.listViewLanguages.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewLanguages.Columns.AddRange (new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderFile,
            this.columnHeaderPath});
            this.listViewLanguages.GridLines = true;
            this.listViewLanguages.Location = new System.Drawing.Point (13, 131);
            this.listViewLanguages.Name = "listViewLanguages";
            this.listViewLanguages.Size = new System.Drawing.Size (404, 220);
            this.listViewLanguages.TabIndex = 4;
            this.listViewLanguages.UseCompatibleStateImageBehavior = false;
            this.listViewLanguages.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point (11, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size (37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Язык:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point (11, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size (84, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Расположение:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point (11, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size (65, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Имя файла:";
            // 
            // textBoxLanguageFile
            // 
            this.textBoxLanguageFile.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLanguageFile.Location = new System.Drawing.Point (103, 47);
            this.textBoxLanguageFile.Name = "textBoxLanguageFile";
            this.textBoxLanguageFile.Size = new System.Drawing.Size (314, 21);
            this.textBoxLanguageFile.TabIndex = 7;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Язык";
            this.columnHeaderName.Width = 109;
            // 
            // columnHeaderFile
            // 
            this.columnHeaderFile.Text = "Файл";
            this.columnHeaderFile.Width = 116;
            // 
            // columnHeaderPath
            // 
            this.columnHeaderPath.Text = "Расположение";
            this.columnHeaderPath.Width = 133;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point (194, 102);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size (75, 23);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemove.Location = new System.Drawing.Point (275, 102);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size (68, 23);
            this.buttonRemove.TabIndex = 10;
            this.buttonRemove.Text = "Удалить";
            this.buttonRemove.UseVisualStyleBackColor = true;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.DarkCyan;
            this.panelHeader.Controls.Add (this.labelDescription);
            this.panelHeader.Controls.Add (this.labelHeader);
            this.panelHeader.Controls.Add (this.pictureBoxForm);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point (0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size (455, 64);
            this.panelHeader.TabIndex = 5;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font ("Tahoma", 9.25F, System.Drawing.FontStyle.Bold);
            this.labelHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelHeader.Location = new System.Drawing.Point (67, 12);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size (180, 16);
            this.labelHeader.TabIndex = 1;
            this.labelHeader.Text = "Создание нового проекта";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDescription.Location = new System.Drawing.Point (67, 31);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size (179, 13);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "Создание нового проекта языков";
            // 
            // pictureBoxForm
            // 
            this.pictureBoxForm.Image = ((System.Drawing.Image) (resources.GetObject ("pictureBoxForm.Image")));
            this.pictureBoxForm.InitialImage = null;
            this.pictureBoxForm.Location = new System.Drawing.Point (10, 8);
            this.pictureBoxForm.Name = "pictureBoxForm";
            this.pictureBoxForm.Size = new System.Drawing.Size (48, 48);
            this.pictureBoxForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxForm.TabIndex = 0;
            this.pictureBoxForm.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point (349, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size (68, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Очистить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormNewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size (455, 588);
            this.Controls.Add (this.panelHeader);
            this.Controls.Add (this.buttonReset);
            this.Controls.Add (this.buttonCancel);
            this.Controls.Add (this.buttonOK);
            this.Controls.Add (this.groupBoxLanguages);
            this.Controls.Add (this.groupBoxProject);
            this.Font = new System.Drawing.Font ("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.Icon = ((System.Drawing.Icon) (resources.GetObject ("$this.Icon")));
            this.Name = "FormNewProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создать новый проект";
            this.Load += new System.EventHandler (this.FormNewProject_Load);
            this.groupBoxProject.ResumeLayout (false);
            this.groupBoxProject.PerformLayout ();
            this.groupBoxLanguages.ResumeLayout (false);
            this.groupBoxLanguages.PerformLayout ();
            this.panelHeader.ResumeLayout (false);
            this.panelHeader.PerformLayout ();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxForm)).EndInit ();
            this.ResumeLayout (false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxProject;
        private System.Windows.Forms.Label labelFormat;
        private System.Windows.Forms.ComboBox comboBoxProjectFormat;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Label labelNameProject;
        private System.Windows.Forms.TextBox textBoxProjectName;
        private System.Windows.Forms.Button buttonSelectProjectPath;
        private System.Windows.Forms.TextBox textBoxProjectPath;
        private System.Windows.Forms.GroupBox groupBoxLanguages;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLanguageFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewLanguages;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderFile;
        private System.Windows.Forms.ColumnHeader columnHeaderPath;
        private System.Windows.Forms.Button buttonSelectLanguagePath;
        private System.Windows.Forms.TextBox textBoxLanguagePath;
        private System.Windows.Forms.TextBox textBoxLanguageName;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.PictureBox pictureBoxForm;
        private System.Windows.Forms.Button button1;
    }
}