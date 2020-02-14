namespace LLIB.Forms
{
    partial class CustomerForm
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
            this.PnlSearch = new System.Windows.Forms.Panel();
            this.DgvSearchResult = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.GroupSearch = new System.Windows.Forms.GroupBox();
            this.CustomerPhone = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnPeople = new System.Windows.Forms.Button();
            this.BtnUsers = new System.Windows.Forms.Button();
            this.PnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearchResult)).BeginInit();
            this.GroupSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlSearch
            // 
            this.PnlSearch.Controls.Add(this.DgvSearchResult);
            this.PnlSearch.Controls.Add(this.label3);
            this.PnlSearch.Controls.Add(this.GroupSearch);
            this.PnlSearch.Location = new System.Drawing.Point(101, 40);
            this.PnlSearch.Name = "PnlSearch";
            this.PnlSearch.Size = new System.Drawing.Size(599, 406);
            this.PnlSearch.TabIndex = 2;
            // 
            // DgvSearchResult
            // 
            this.DgvSearchResult.AllowUserToAddRows = false;
            this.DgvSearchResult.AllowUserToDeleteRows = false;
            this.DgvSearchResult.AllowUserToOrderColumns = true;
            this.DgvSearchResult.AllowUserToResizeColumns = false;
            this.DgvSearchResult.AllowUserToResizeRows = false;
            this.DgvSearchResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSearchResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.DgvSearchResult.Location = new System.Drawing.Point(34, 127);
            this.DgvSearchResult.Name = "DgvSearchResult";
            this.DgvSearchResult.Size = new System.Drawing.Size(530, 215);
            this.DgvSearchResult.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "İd";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ad";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Soyad";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Telefon";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ətraflı";
            this.Column5.Name = "Column5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon";
            // 
            // GroupSearch
            // 
            this.GroupSearch.Controls.Add(this.CustomerPhone);
            this.GroupSearch.Controls.Add(this.textBox2);
            this.GroupSearch.Controls.Add(this.BtnSearch);
            this.GroupSearch.Controls.Add(this.textBox1);
            this.GroupSearch.Controls.Add(this.label2);
            this.GroupSearch.Controls.Add(this.label1);
            this.GroupSearch.Location = new System.Drawing.Point(18, 15);
            this.GroupSearch.Name = "GroupSearch";
            this.GroupSearch.Size = new System.Drawing.Size(560, 85);
            this.GroupSearch.TabIndex = 0;
            this.GroupSearch.TabStop = false;
            this.GroupSearch.Text = "Müştəri axratışı";
            // 
            // CustomerPhone
            // 
            this.CustomerPhone.Location = new System.Drawing.Point(270, 59);
            this.CustomerPhone.Name = "CustomerPhone";
            this.CustomerPhone.Size = new System.Drawing.Size(77, 20);
            this.CustomerPhone.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(150, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(82, 20);
            this.textBox2.TabIndex = 4;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(413, 41);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(98, 26);
            this.BtnSearch.TabIndex = 6;
            this.BtnSearch.Text = "Axtar";
            this.BtnSearch.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(78, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // BtnPeople
            // 
            this.BtnPeople.Location = new System.Drawing.Point(101, 3);
            this.BtnPeople.Name = "BtnPeople";
            this.BtnPeople.Size = new System.Drawing.Size(86, 31);
            this.BtnPeople.TabIndex = 3;
            this.BtnPeople.Text = "Şəxslər";
            this.BtnPeople.UseVisualStyleBackColor = true;
            // 
            // BtnUsers
            // 
            this.BtnUsers.Location = new System.Drawing.Point(193, 3);
            this.BtnUsers.Name = "BtnUsers";
            this.BtnUsers.Size = new System.Drawing.Size(94, 31);
            this.BtnUsers.TabIndex = 4;
            this.BtnUsers.Text = "İdarəçilər";
            this.BtnUsers.UseVisualStyleBackColor = true;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnUsers);
            this.Controls.Add(this.BtnPeople);
            this.Controls.Add(this.PnlSearch);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.PnlSearch.ResumeLayout(false);
            this.PnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearchResult)).EndInit();
            this.GroupSearch.ResumeLayout(false);
            this.GroupSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlSearch;
        private System.Windows.Forms.DataGridView DgvSearchResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox GroupSearch;
        private System.Windows.Forms.TextBox CustomerPhone;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnPeople;
        private System.Windows.Forms.Button BtnUsers;
    }
}