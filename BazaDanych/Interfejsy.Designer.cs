namespace BazaDanych
{
    partial class Interfejsy
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtKod = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.zAMKNIJToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRZYPNIJToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oDEPNIJToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Silver;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelete.Location = new System.Drawing.Point(218, 425);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "USUŃ";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.Silver;
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModify.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnModify.Location = new System.Drawing.Point(113, 425);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 11;
            this.btnModify.Text = "MODYFIKU";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Silver;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdd.Location = new System.Drawing.Point(12, 425);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "DODAJ";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDescription.ForeColor = System.Drawing.Color.White;
            this.txtDescription.Location = new System.Drawing.Point(12, 63);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(560, 50);
            this.txtDescription.TabIndex = 9;
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTitle.ForeColor = System.Drawing.Color.White;
            this.txtTitle.Location = new System.Drawing.Point(12, 33);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(560, 24);
            this.txtTitle.TabIndex = 8;
            this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKod
            // 
            this.txtKod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtKod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKod.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtKod.ForeColor = System.Drawing.Color.White;
            this.txtKod.Location = new System.Drawing.Point(12, 119);
            this.txtKod.Multiline = true;
            this.txtKod.Name = "txtKod";
            this.txtKod.ReadOnly = true;
            this.txtKod.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKod.Size = new System.Drawing.Size(560, 284);
            this.txtKod.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zAMKNIJToolStripMenuItem,
            this.pRZYPNIJToolStripMenuItem,
            this.oDEPNIJToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(588, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // zAMKNIJToolStripMenuItem
            // 
            this.zAMKNIJToolStripMenuItem.Name = "zAMKNIJToolStripMenuItem";
            this.zAMKNIJToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.zAMKNIJToolStripMenuItem.Text = "ZAMKNIJ";
            this.zAMKNIJToolStripMenuItem.Click += new System.EventHandler(this.zAMKNIJToolStripMenuItem_Click);
            // 
            // pRZYPNIJToolStripMenuItem
            // 
            this.pRZYPNIJToolStripMenuItem.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pRZYPNIJToolStripMenuItem.Name = "pRZYPNIJToolStripMenuItem";
            this.pRZYPNIJToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.pRZYPNIJToolStripMenuItem.Text = "PRZYPNIJ";
            this.pRZYPNIJToolStripMenuItem.Click += new System.EventHandler(this.pRZYPNIJToolStripMenuItem_Click);
            // 
            // oDEPNIJToolStripMenuItem
            // 
            this.oDEPNIJToolStripMenuItem.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.oDEPNIJToolStripMenuItem.Name = "oDEPNIJToolStripMenuItem";
            this.oDEPNIJToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.oDEPNIJToolStripMenuItem.Text = "ODEPNIJ";
            this.oDEPNIJToolStripMenuItem.Click += new System.EventHandler(this.oDEPNIJToolStripMenuItem_Click);
            // 
            // btnAnuluj
            // 
            this.btnAnuluj.BackColor = System.Drawing.Color.Silver;
            this.btnAnuluj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnuluj.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAnuluj.Location = new System.Drawing.Point(497, 425);
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.Size = new System.Drawing.Size(75, 23);
            this.btnAnuluj.TabIndex = 14;
            this.btnAnuluj.Text = "ANULUJ";
            this.btnAnuluj.UseVisualStyleBackColor = false;
            this.btnAnuluj.Visible = false;
            this.btnAnuluj.Click += new System.EventHandler(this.btnAnuluj_Click);
            // 
            // Interfejsy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(588, 466);
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtKod);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Interfejsy";
            this.Text = "Interfejsy";
            this.Load += new System.EventHandler(this.Interfejsy_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtKod;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zAMKNIJToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRZYPNIJToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oDEPNIJToolStripMenuItem;
        private System.Windows.Forms.Button btnAnuluj;
    }
}