namespace POEditor
{
    partial class FormEditor
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent ()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager (typeof (FormEditor));
            this.comboBoxLanguages = new System.Windows.Forms.ComboBox ();
            this.labelLanguages = new System.Windows.Forms.Label ();
            this.progressBar = new System.Windows.Forms.ProgressBar ();
            this.listView = new System.Windows.Forms.ListView ();
            this.panelHeader = new System.Windows.Forms.Panel ();
            this.labelDescription = new System.Windows.Forms.Label ();
            this.labelHeader = new System.Windows.Forms.Label ();
            this.buttonKeys = new System.Windows.Forms.Button ();
            this.buttonSave = new System.Windows.Forms.Button ();
            this.groupBoxLanguage = new System.Windows.Forms.GroupBox ();
            this.textBoxPath = new System.Windows.Forms.TextBox ();
            this.labelPath = new System.Windows.Forms.Label ();
            this.columnHeaderTerms = ((System.Windows.Forms.ColumnHeader) (new System.Windows.Forms.ColumnHeader ()));
            this.columnHeaderTranslated = ((System.Windows.Forms.ColumnHeader) (new System.Windows.Forms.ColumnHeader ()));
            this.panelDictionary = new System.Windows.Forms.Panel ();
            this.splitContainerTotal = new System.Windows.Forms.SplitContainer ();
            this.splitContainerItems = new System.Windows.Forms.SplitContainer ();
            this.textBoxTerms = new System.Windows.Forms.TextBox ();
            this.textBoxTranslated = new System.Windows.Forms.TextBox ();
            this.pictureBoxForm = new System.Windows.Forms.PictureBox ();
            this.panelHeader.SuspendLayout ();
            this.groupBoxLanguage.SuspendLayout ();
            this.panelDictionary.SuspendLayout ();
            this.splitContainerTotal.Panel1.SuspendLayout ();
            this.splitContainerTotal.Panel2.SuspendLayout ();
            this.splitContainerTotal.SuspendLayout ();
            this.splitContainerItems.Panel1.SuspendLayout ();
            this.splitContainerItems.Panel2.SuspendLayout ();
            this.splitContainerItems.SuspendLayout ();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxForm)).BeginInit ();
            this.SuspendLayout ();
            // 
            // comboBoxLanguages
            // 
            this.comboBoxLanguages.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxLanguages.FormattingEnabled = true;
            this.comboBoxLanguages.Location = new System.Drawing.Point (161, 20);
            this.comboBoxLanguages.Name = "comboBoxLanguages";
            this.comboBoxLanguages.Size = new System.Drawing.Size (439, 21);
            this.comboBoxLanguages.TabIndex = 0;
            // 
            // labelLanguages
            // 
            this.labelLanguages.AutoSize = true;
            this.labelLanguages.Location = new System.Drawing.Point (10, 23);
            this.labelLanguages.Name = "labelLanguages";
            this.labelLanguages.Size = new System.Drawing.Size (37, 13);
            this.labelLanguages.TabIndex = 1;
            this.labelLanguages.Text = "Язык:";
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point (12, 427);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size (695, 23);
            this.progressBar.TabIndex = 2;
            // 
            // listView
            // 
            this.listView.Columns.AddRange (new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTerms,
            this.columnHeaderTranslated});
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point (0, 0);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size (690, 192);
            this.listView.TabIndex = 4;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Firebrick;
            this.panelHeader.Controls.Add (this.labelDescription);
            this.panelHeader.Controls.Add (this.labelHeader);
            this.panelHeader.Controls.Add (this.pictureBoxForm);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point (0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size (719, 64);
            this.panelHeader.TabIndex = 6;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDescription.Location = new System.Drawing.Point (67, 31);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size (246, 13);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "Выполняйте редактирование пунктов словаря";
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font ("Tahoma", 9.25F, System.Drawing.FontStyle.Bold);
            this.labelHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelHeader.Location = new System.Drawing.Point (67, 12);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size (178, 16);
            this.labelHeader.TabIndex = 1;
            this.labelHeader.Text = "Редактирование словаря";
            // 
            // buttonKeys
            // 
            this.buttonKeys.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonKeys.Location = new System.Drawing.Point (631, 88);
            this.buttonKeys.Name = "buttonKeys";
            this.buttonKeys.Size = new System.Drawing.Size (75, 23);
            this.buttonKeys.TabIndex = 7;
            this.buttonKeys.Text = "Ключи";
            this.buttonKeys.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point (631, 115);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size (75, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // groupBoxLanguage
            // 
            this.groupBoxLanguage.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxLanguage.Controls.Add (this.labelPath);
            this.groupBoxLanguage.Controls.Add (this.textBoxPath);
            this.groupBoxLanguage.Controls.Add (this.labelLanguages);
            this.groupBoxLanguage.Controls.Add (this.comboBoxLanguages);
            this.groupBoxLanguage.Location = new System.Drawing.Point (12, 70);
            this.groupBoxLanguage.Name = "groupBoxLanguage";
            this.groupBoxLanguage.Size = new System.Drawing.Size (613, 81);
            this.groupBoxLanguage.TabIndex = 9;
            this.groupBoxLanguage.TabStop = false;
            this.groupBoxLanguage.Text = "Выбор языка";
            // 
            // textBoxPath
            // 
            this.textBoxPath.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPath.Location = new System.Drawing.Point (161, 47);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size (439, 21);
            this.textBoxPath.TabIndex = 9;
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point (12, 50);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size (84, 13);
            this.labelPath.TabIndex = 10;
            this.labelPath.Text = "Расположение:";
            // 
            // columnHeaderTerms
            // 
            this.columnHeaderTerms.Text = "Ключи";
            this.columnHeaderTerms.Width = 298;
            // 
            // columnHeaderTranslated
            // 
            this.columnHeaderTranslated.Tag = "";
            this.columnHeaderTranslated.Text = "Перевод";
            this.columnHeaderTranslated.Width = 387;
            // 
            // panelDictionary
            // 
            this.panelDictionary.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDictionary.Controls.Add (this.splitContainerTotal);
            this.panelDictionary.Location = new System.Drawing.Point (12, 157);
            this.panelDictionary.Name = "panelDictionary";
            this.panelDictionary.Size = new System.Drawing.Size (694, 264);
            this.panelDictionary.TabIndex = 10;
            // 
            // splitContainerTotal
            // 
            this.splitContainerTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainerTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerTotal.Location = new System.Drawing.Point (0, 0);
            this.splitContainerTotal.Name = "splitContainerTotal";
            this.splitContainerTotal.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerTotal.Panel1
            // 
            this.splitContainerTotal.Panel1.Controls.Add (this.listView);
            // 
            // splitContainerTotal.Panel2
            // 
            this.splitContainerTotal.Panel2.Controls.Add (this.splitContainerItems);
            this.splitContainerTotal.Size = new System.Drawing.Size (694, 264);
            this.splitContainerTotal.SplitterDistance = 196;
            this.splitContainerTotal.TabIndex = 11;
            // 
            // splitContainerItems
            // 
            this.splitContainerItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainerItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerItems.Location = new System.Drawing.Point (0, 0);
            this.splitContainerItems.Name = "splitContainerItems";
            // 
            // splitContainerItems.Panel1
            // 
            this.splitContainerItems.Panel1.Controls.Add (this.textBoxTerms);
            // 
            // splitContainerItems.Panel2
            // 
            this.splitContainerItems.Panel2.Controls.Add (this.textBoxTranslated);
            this.splitContainerItems.Size = new System.Drawing.Size (694, 64);
            this.splitContainerItems.SplitterDistance = 331;
            this.splitContainerItems.TabIndex = 1;
            // 
            // textBoxTerms
            // 
            this.textBoxTerms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTerms.Location = new System.Drawing.Point (0, 0);
            this.textBoxTerms.Multiline = true;
            this.textBoxTerms.Name = "textBoxTerms";
            this.textBoxTerms.ReadOnly = true;
            this.textBoxTerms.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTerms.Size = new System.Drawing.Size (327, 60);
            this.textBoxTerms.TabIndex = 0;
            // 
            // textBoxTranslated
            // 
            this.textBoxTranslated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTranslated.Location = new System.Drawing.Point (0, 0);
            this.textBoxTranslated.Multiline = true;
            this.textBoxTranslated.Name = "textBoxTranslated";
            this.textBoxTranslated.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTranslated.Size = new System.Drawing.Size (355, 60);
            this.textBoxTranslated.TabIndex = 0;
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
            // FormEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size (719, 462);
            this.Controls.Add (this.panelDictionary);
            this.Controls.Add (this.groupBoxLanguage);
            this.Controls.Add (this.panelHeader);
            this.Controls.Add (this.buttonSave);
            this.Controls.Add (this.progressBar);
            this.Controls.Add (this.buttonKeys);
            this.Font = new System.Drawing.Font ("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.MinimumSize = new System.Drawing.Size (735, 500);
            this.Name = "FormEditor";
            this.Text = "POEditor";
            this.Load += new System.EventHandler (this.FormMain_Load);
            this.panelHeader.ResumeLayout (false);
            this.panelHeader.PerformLayout ();
            this.groupBoxLanguage.ResumeLayout (false);
            this.groupBoxLanguage.PerformLayout ();
            this.panelDictionary.ResumeLayout (false);
            this.splitContainerTotal.Panel1.ResumeLayout (false);
            this.splitContainerTotal.Panel2.ResumeLayout (false);
            this.splitContainerTotal.ResumeLayout (false);
            this.splitContainerItems.Panel1.ResumeLayout (false);
            this.splitContainerItems.Panel1.PerformLayout ();
            this.splitContainerItems.Panel2.ResumeLayout (false);
            this.splitContainerItems.Panel2.PerformLayout ();
            this.splitContainerItems.ResumeLayout (false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxForm)).EndInit ();
            this.ResumeLayout (false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxLanguages;
        private System.Windows.Forms.Label labelLanguages;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.PictureBox pictureBoxForm;
        private System.Windows.Forms.Button buttonKeys;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.GroupBox groupBoxLanguage;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.ColumnHeader columnHeaderTerms;
        private System.Windows.Forms.ColumnHeader columnHeaderTranslated;
        private System.Windows.Forms.Panel panelDictionary;
        private System.Windows.Forms.SplitContainer splitContainerTotal;
        private System.Windows.Forms.SplitContainer splitContainerItems;
        private System.Windows.Forms.TextBox textBoxTerms;
        private System.Windows.Forms.TextBox textBoxTranslated;

    }
}

