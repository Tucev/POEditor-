namespace POEditor
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager (typeof (FormMain));
            this.listView1 = new System.Windows.Forms.ListView ();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader) (new System.Windows.Forms.ColumnHeader ()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader) (new System.Windows.Forms.ColumnHeader ()));
            this.textBox1 = new System.Windows.Forms.TextBox ();
            this.textBox2 = new System.Windows.Forms.TextBox ();
            this.button1 = new System.Windows.Forms.Button ();
            this.textBox3 = new System.Windows.Forms.TextBox ();
            this.button2 = new System.Windows.Forms.Button ();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip ();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox ();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton ();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem ();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem ();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip ();
            this.toolStrip1.SuspendLayout ();
            this.menuStrip1.SuspendLayout ();
            this.SuspendLayout ();
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.Columns.AddRange (new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point (12, 82);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size (381, 284);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 153;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point (12, 372);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size (143, 100);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point (161, 372);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size (232, 100);
            this.textBox2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point (399, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size (75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point (399, 82);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size (225, 21);
            this.textBox3.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point (399, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size (75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange (new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point (0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size (694, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size (121, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::POEditor.Properties.Resources.page;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size (23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size (48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size (59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange (new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point (0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size (694, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size (694, 486);
            this.Controls.Add (this.toolStrip1);
            this.Controls.Add (this.button2);
            this.Controls.Add (this.textBox3);
            this.Controls.Add (this.button1);
            this.Controls.Add (this.textBox2);
            this.Controls.Add (this.textBox1);
            this.Controls.Add (this.listView1);
            this.Controls.Add (this.menuStrip1);
            this.Font = new System.Drawing.Font ("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.Icon = ((System.Drawing.Icon) (resources.GetObject ("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "POEditor";
            this.Load += new System.EventHandler (this.FormMain_Load);
            this.toolStrip1.ResumeLayout (false);
            this.toolStrip1.PerformLayout ();
            this.menuStrip1.ResumeLayout (false);
            this.menuStrip1.PerformLayout ();
            this.ResumeLayout (false);
            this.PerformLayout ();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

