namespace LLIB.Forms
{
    partial class OrderForm
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
            this.pnl = new System.Windows.Forms.Panel();
            this.GrpTodayOrder = new System.Windows.Forms.GroupBox();
            this.DgvTodayOrders = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnl.SuspendLayout();
            this.GrpTodayOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTodayOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.GrpTodayOrder);
            this.pnl.Location = new System.Drawing.Point(108, 21);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(585, 408);
            this.pnl.TabIndex = 4;
            // 
            // GrpTodayOrder
            // 
            this.GrpTodayOrder.Controls.Add(this.DgvTodayOrders);
            this.GrpTodayOrder.Location = new System.Drawing.Point(19, 19);
            this.GrpTodayOrder.Name = "GrpTodayOrder";
            this.GrpTodayOrder.Size = new System.Drawing.Size(544, 387);
            this.GrpTodayOrder.TabIndex = 0;
            this.GrpTodayOrder.TabStop = false;
            this.GrpTodayOrder.Text = "Sifarişlər";
            // 
            // DgvTodayOrders
            // 
            this.DgvTodayOrders.AllowUserToAddRows = false;
            this.DgvTodayOrders.AllowUserToDeleteRows = false;
            this.DgvTodayOrders.AllowUserToOrderColumns = true;
            this.DgvTodayOrders.AllowUserToResizeColumns = false;
            this.DgvTodayOrders.AllowUserToResizeRows = false;
            this.DgvTodayOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvTodayOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTodayOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column7,
            this.Column9,
            this.Column8,
            this.Column10,
            this.Column2});
            this.DgvTodayOrders.Location = new System.Drawing.Point(33, 54);
            this.DgvTodayOrders.Name = "DgvTodayOrders";
            this.DgvTodayOrders.Size = new System.Drawing.Size(511, 203);
            this.DgvTodayOrders.TabIndex = 0;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Id";
            this.Column6.Name = "Column6";
            this.Column6.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Sifariş sahibi";
            this.Column1.Name = "Column1";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Şəxs";
            this.Column7.Name = "Column7";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Telefon";
            this.Column9.Name = "Column9";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Tarix";
            this.Column8.Name = "Column8";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Tamamla";
            this.Column10.Name = "Column10";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ətraflı";
            this.Column2.Name = "Column2";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.pnl.ResumeLayout(false);
            this.GrpTodayOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTodayOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.GroupBox GrpTodayOrder;
        private System.Windows.Forms.DataGridView DgvTodayOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewButtonColumn Column10;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
    }
}