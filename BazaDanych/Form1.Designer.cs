namespace BazaDanych
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnString = new System.Windows.Forms.Button();
            this.btnIf = new System.Windows.Forms.Button();
            this.btnLoop = new System.Windows.Forms.Button();
            this.btnTable = new System.Windows.Forms.Button();
            this.btnInterface = new System.Windows.Forms.Button();
            this.btnProgram = new System.Windows.Forms.Button();
            this.btnSeek = new System.Windows.Forms.Button();
            this.dgGrid = new System.Windows.Forms.DataGridView();
            this.txtSeek = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOther = new System.Windows.Forms.Button();
            this.btnSql = new System.Windows.Forms.Button();
            this.btnAnuluj = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dgGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnString
            // 
            resources.ApplyResources(this.btnString, "btnString");
            this.btnString.BackColor = System.Drawing.Color.DimGray;
            this.btnString.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnString.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnString.ForeColor = System.Drawing.Color.White;
            this.btnString.Name = "btnString";
            this.btnString.UseVisualStyleBackColor = false;
            this.btnString.Click += new System.EventHandler(this.btnString_Click_1);
            // 
            // btnIf
            // 
            resources.ApplyResources(this.btnIf, "btnIf");
            this.btnIf.BackColor = System.Drawing.Color.DimGray;
            this.btnIf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIf.ForeColor = System.Drawing.Color.White;
            this.btnIf.Name = "btnIf";
            this.btnIf.UseVisualStyleBackColor = false;
            this.btnIf.Click += new System.EventHandler(this.btnIf_Click_1);
            // 
            // btnLoop
            // 
            resources.ApplyResources(this.btnLoop, "btnLoop");
            this.btnLoop.BackColor = System.Drawing.Color.DimGray;
            this.btnLoop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoop.ForeColor = System.Drawing.Color.White;
            this.btnLoop.Name = "btnLoop";
            this.btnLoop.UseVisualStyleBackColor = false;
            this.btnLoop.Click += new System.EventHandler(this.btnLoop_Click_1);
            // 
            // btnTable
            // 
            resources.ApplyResources(this.btnTable, "btnTable");
            this.btnTable.BackColor = System.Drawing.Color.DimGray;
            this.btnTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTable.ForeColor = System.Drawing.Color.White;
            this.btnTable.Name = "btnTable";
            this.btnTable.Tag = "1";
            this.btnTable.UseVisualStyleBackColor = false;
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click_1);
            // 
            // btnInterface
            // 
            resources.ApplyResources(this.btnInterface, "btnInterface");
            this.btnInterface.BackColor = System.Drawing.Color.DimGray;
            this.btnInterface.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInterface.ForeColor = System.Drawing.Color.White;
            this.btnInterface.Name = "btnInterface";
            this.btnInterface.UseVisualStyleBackColor = false;
            this.btnInterface.Click += new System.EventHandler(this.btnInterface_Click_1);
            // 
            // btnProgram
            // 
            resources.ApplyResources(this.btnProgram, "btnProgram");
            this.btnProgram.BackColor = System.Drawing.Color.DimGray;
            this.btnProgram.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProgram.ForeColor = System.Drawing.Color.White;
            this.btnProgram.Name = "btnProgram";
            this.btnProgram.UseVisualStyleBackColor = false;
            this.btnProgram.Click += new System.EventHandler(this.btnProgram_Click_1);
            // 
            // btnSeek
            // 
            resources.ApplyResources(this.btnSeek, "btnSeek");
            this.btnSeek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeek.Name = "btnSeek";
            this.btnSeek.UseVisualStyleBackColor = true;
            this.btnSeek.Click += new System.EventHandler(this.btnSeek_Click);
            // 
            // dgGrid
            // 
            resources.ApplyResources(this.dgGrid, "dgGrid");
            this.dgGrid.AllowUserToAddRows = false;
            this.dgGrid.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dgGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGrid.Name = "dgGrid";
            this.dgGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgGrid_CellClick);
            // 
            // txtSeek
            // 
            resources.ApplyResources(this.txtSeek, "txtSeek");
            this.txtSeek.Name = "txtSeek";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.btnOther);
            this.groupBox1.Controls.Add(this.btnSql);
            this.groupBox1.Controls.Add(this.btnProgram);
            this.groupBox1.Controls.Add(this.btnInterface);
            this.groupBox1.Controls.Add(this.btnTable);
            this.groupBox1.Controls.Add(this.btnLoop);
            this.groupBox1.Controls.Add(this.btnIf);
            this.groupBox1.Controls.Add(this.btnString);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // btnOther
            // 
            resources.ApplyResources(this.btnOther, "btnOther");
            this.btnOther.BackColor = System.Drawing.Color.DimGray;
            this.btnOther.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOther.ForeColor = System.Drawing.Color.White;
            this.btnOther.Name = "btnOther";
            this.btnOther.UseVisualStyleBackColor = false;
            this.btnOther.Click += new System.EventHandler(this.btnOther_Click);
            // 
            // btnSql
            // 
            resources.ApplyResources(this.btnSql, "btnSql");
            this.btnSql.BackColor = System.Drawing.Color.DimGray;
            this.btnSql.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSql.ForeColor = System.Drawing.Color.White;
            this.btnSql.Name = "btnSql";
            this.btnSql.UseVisualStyleBackColor = false;
            this.btnSql.Click += new System.EventHandler(this.btnSql_Click);
            // 
            // btnAnuluj
            // 
            resources.ApplyResources(this.btnAnuluj, "btnAnuluj");
            this.btnAnuluj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnuluj.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnuluj.Name = "btnAnuluj";
            this.btnAnuluj.UseVisualStyleBackColor = true;
            this.btnAnuluj.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAnuluj;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAnuluj);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSeek);
            this.Controls.Add(this.dgGrid);
            this.Controls.Add(this.btnSeek);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion;

        private System.Windows.Forms.Button btnString;
        private System.Windows.Forms.Button btnIf;
        private System.Windows.Forms.Button btnLoop;
        private System.Windows.Forms.Button btnTable;
        private System.Windows.Forms.Button btnInterface;
        private System.Windows.Forms.Button btnProgram;
        private System.Windows.Forms.Button btnSeek;
        private System.Windows.Forms.DataGridView dgGrid;
        private System.Windows.Forms.TextBox txtSeek;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOther;
        private System.Windows.Forms.Button btnSql;
        private System.Windows.Forms.Button btnAnuluj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

