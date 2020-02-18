
namespace Library.Forms
{
    partial class BookAddForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNewBookTitle = new System.Windows.Forms.TextBox();
            this.TxtNewBookAuthor = new System.Windows.Forms.TextBox();
            this.TxtNewBookGenre = new System.Windows.Forms.TextBox();
            this.BtnAddNewBook = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNewBookCount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtNewBookPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Genre";
            // 
            // TxtNewBookTitle
            // 
            this.TxtNewBookTitle.Location = new System.Drawing.Point(70, 47);
            this.TxtNewBookTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtNewBookTitle.Name = "TxtNewBookTitle";
            this.TxtNewBookTitle.Size = new System.Drawing.Size(147, 20);
            this.TxtNewBookTitle.TabIndex = 3;
            // 
            // TxtNewBookAuthor
            // 
            this.TxtNewBookAuthor.Location = new System.Drawing.Point(70, 174);
            this.TxtNewBookAuthor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtNewBookAuthor.Name = "TxtNewBookAuthor";
            this.TxtNewBookAuthor.Size = new System.Drawing.Size(147, 20);
            this.TxtNewBookAuthor.TabIndex = 4;
            // 
            // TxtNewBookGenre
            // 
            this.TxtNewBookGenre.Location = new System.Drawing.Point(70, 109);
            this.TxtNewBookGenre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtNewBookGenre.Name = "TxtNewBookGenre";
            this.TxtNewBookGenre.Size = new System.Drawing.Size(147, 20);
            this.TxtNewBookGenre.TabIndex = 5;
            // 
            // BtnAddNewBook
            // 
            this.BtnAddNewBook.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BtnAddNewBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddNewBook.Location = new System.Drawing.Point(343, 108);
            this.BtnAddNewBook.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAddNewBook.Name = "BtnAddNewBook";
            this.BtnAddNewBook.Size = new System.Drawing.Size(103, 53);
            this.BtnAddNewBook.TabIndex = 6;
            this.BtnAddNewBook.Text = "Əlavə et";
            this.BtnAddNewBook.UseVisualStyleBackColor = false;
            this.BtnAddNewBook.Click += new System.EventHandler(this.BtnAddNewBook_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 212);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Price";
            // 
            // TxtNewBookCount
            // 
            this.TxtNewBookCount.Location = new System.Drawing.Point(70, 250);
            this.TxtNewBookCount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtNewBookCount.Name = "TxtNewBookCount";
            this.TxtNewBookCount.Size = new System.Drawing.Size(147, 20);
            this.TxtNewBookCount.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 8;
            // 
            // TxtNewBookPrice
            // 
            this.TxtNewBookPrice.Location = new System.Drawing.Point(0, 0);
            this.TxtNewBookPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtNewBookPrice.Name = "TxtNewBookPrice";
            this.TxtNewBookPrice.Size = new System.Drawing.Size(68, 20);
            this.TxtNewBookPrice.TabIndex = 7;
            // 
            // BookAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.BtnAddNewBook);
            this.Controls.Add(this.TxtNewBookPrice);
            this.Controls.Add(this.TxtNewBookCount);
            this.Controls.Add(this.TxtNewBookGenre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtNewBookAuthor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtNewBookTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BookAddForm";
            this.Text = "BookAddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNewBookTitle;
        private System.Windows.Forms.TextBox TxtNewBookAuthor;
        private System.Windows.Forms.TextBox TxtNewBookGenre;
        private System.Windows.Forms.Button BtnAddNewBook;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNewBookCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtNewBookPrice;
    }
}