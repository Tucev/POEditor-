﻿namespace POEditor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox ();
            this.SuspendLayout ();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point (12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size (498, 295);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Проект";
            // 
            // FormNewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size (522, 531);
            this.Controls.Add (this.groupBox1);
            this.Font = new System.Drawing.Font ("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.Name = "FormNewProject";
            this.Text = "FormNewProject";
            this.ResumeLayout (false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
    }
}