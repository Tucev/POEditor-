namespace POEditor
{
    partial class FormKeys
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
            this.panelHeader = new System.Windows.Forms.Panel ();
            this.labelDescription = new System.Windows.Forms.Label ();
            this.labelHeader = new System.Windows.Forms.Label ();
            this.pictureBoxForm = new System.Windows.Forms.PictureBox ();
            this.textBoxSearch = new System.Windows.Forms.TextBox ();
            this.labelSearch = new System.Windows.Forms.Label ();
            this.textBoxEdit = new System.Windows.Forms.TextBox ();
            this.buttonAdd = new System.Windows.Forms.Button ();
            this.buttonRemove = new System.Windows.Forms.Button ();
            this.buttonOk = new System.Windows.Forms.Button ();
            this.listView1 = new System.Windows.Forms.ListView ();
            this.columnHeaderTerms = ((System.Windows.Forms.ColumnHeader) (new System.Windows.Forms.ColumnHeader ()));
            this.panelHeader.SuspendLayout ();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxForm)).BeginInit ();
            this.SuspendLayout ();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Indigo;
            this.panelHeader.Controls.Add (this.labelDescription);
            this.panelHeader.Controls.Add (this.labelHeader);
            this.panelHeader.Controls.Add (this.pictureBoxForm);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point (0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size (395, 64);
            this.panelHeader.TabIndex = 6;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDescription.Location = new System.Drawing.Point (67, 31);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size (281, 13);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "Редактирование списка ключей, для разных языков.";
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font ("Tahoma", 9.25F, System.Drawing.FontStyle.Bold);
            this.labelHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelHeader.Location = new System.Drawing.Point (67, 12);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size (174, 16);
            this.labelHeader.TabIndex = 1;
            this.labelHeader.Text = "Редактирование ключей";
            // 
            // pictureBoxForm
            // 
            this.pictureBoxForm.Image = global::POEditor.Properties.Resources.Diary;
            this.pictureBoxForm.InitialImage = null;
            this.pictureBoxForm.Location = new System.Drawing.Point (10, 8);
            this.pictureBoxForm.Name = "pictureBoxForm";
            this.pictureBoxForm.Size = new System.Drawing.Size (48, 48);
            this.pictureBoxForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxForm.TabIndex = 0;
            this.pictureBoxForm.TabStop = false;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Location = new System.Drawing.Point (70, 76);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size (313, 21);
            this.textBoxSearch.TabIndex = 8;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point (9, 79);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size (41, 13);
            this.labelSearch.TabIndex = 9;
            this.labelSearch.Text = "Поиск:";
            // 
            // textBoxEdit
            // 
            this.textBoxEdit.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEdit.Location = new System.Drawing.Point (10, 469);
            this.textBoxEdit.Multiline = true;
            this.textBoxEdit.Name = "textBoxEdit";
            this.textBoxEdit.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxEdit.Size = new System.Drawing.Size (292, 81);
            this.textBoxEdit.TabIndex = 10;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point (308, 469);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size (75, 23);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemove.Location = new System.Drawing.Point (308, 498);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size (75, 23);
            this.buttonRemove.TabIndex = 12;
            this.buttonRemove.Text = "Удалить";
            this.buttonRemove.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point (308, 527);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size (75, 23);
            this.buttonOk.TabIndex = 13;
            this.buttonOk.Text = "Готово";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange (new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTerms});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point (10, 103);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size (373, 360);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderTerms
            // 
            this.columnHeaderTerms.Text = "Ключи";
            this.columnHeaderTerms.Width = 353;
            // 
            // FormKeys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size (395, 562);
            this.Controls.Add (this.listView1);
            this.Controls.Add (this.buttonOk);
            this.Controls.Add (this.buttonRemove);
            this.Controls.Add (this.buttonAdd);
            this.Controls.Add (this.textBoxEdit);
            this.Controls.Add (this.labelSearch);
            this.Controls.Add (this.textBoxSearch);
            this.Controls.Add (this.panelHeader);
            this.Font = new System.Drawing.Font ("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size (400, 600);
            this.Name = "FormKeys";
            this.Text = "Ключи";
            this.Load += new System.EventHandler (this.FormKeys_Load);
            this.panelHeader.ResumeLayout (false);
            this.panelHeader.PerformLayout ();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBoxForm)).EndInit ();
            this.ResumeLayout (false);
            this.PerformLayout ();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.PictureBox pictureBoxForm;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderTerms;
    }
}