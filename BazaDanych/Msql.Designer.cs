namespace BazaDanych
{
    partial class Msql
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtKod = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold);
            this.txtId.Location = new System.Drawing.Point(0, 9);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(35, 26);
            this.txtId.TabIndex = 13;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(227, 383);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(119, 383);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 11;
            this.btnModify.Text = "Modyfikuj";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(10, 383);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtDescription.Location = new System.Drawing.Point(0, 47);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(528, 54);
            this.txtDescription.TabIndex = 9;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtTitle.Location = new System.Drawing.Point(41, 9);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(487, 26);
            this.txtTitle.TabIndex = 8;
            // 
            // txtKod
            // 
            this.txtKod.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F);
            this.txtKod.Location = new System.Drawing.Point(0, 117);
            this.txtKod.Multiline = true;
            this.txtKod.Name = "txtKod";
            this.txtKod.ReadOnly = true;
            this.txtKod.Size = new System.Drawing.Size(528, 243);
            this.txtKod.TabIndex = 7;
            // 
            // Msql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 458);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtKod);
            this.Name = "Msql";
            this.Text = "Msql";
            this.Load += new System.EventHandler(this.Msql_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtKod;
    }
}