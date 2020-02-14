namespace LLIB.Forms
{
    partial class DashboardForm
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
            this.BtnPeople = new System.Windows.Forms.Button();
            this.BtnUsers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnPeople
            // 
            this.BtnPeople.Location = new System.Drawing.Point(20, 1);
            this.BtnPeople.Name = "BtnPeople";
            this.BtnPeople.Size = new System.Drawing.Size(84, 36);
            this.BtnPeople.TabIndex = 3;
            this.BtnPeople.Text = "Şəxslər";
            this.BtnPeople.UseVisualStyleBackColor = true;
            // 
            // BtnUsers
            // 
            this.BtnUsers.Location = new System.Drawing.Point(131, 1);
            this.BtnUsers.Name = "BtnUsers";
            this.BtnUsers.Size = new System.Drawing.Size(93, 36);
            this.BtnUsers.TabIndex = 4;
            this.BtnUsers.Text = "İdarəçilər";
            this.BtnUsers.UseVisualStyleBackColor = true;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 450);
            this.Controls.Add(this.BtnUsers);
            this.Controls.Add(this.BtnPeople);
            this.Name = "DashboardForm";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnPeople;
        private System.Windows.Forms.Button BtnUsers;
    }
}