
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LLIB.Data;
using LLIB.Models;

namespace Library.Forms
{
    public partial class BookAddForm : Form
    {

        private readonly LibraryContext context;

        public BookAddForm()
        {

            context = new LibraryContext();
            InitializeComponent();
        }

        public object TxtNewBookName { get; private set; }

        internal LibraryContext Context => context;

        ////kitab elave etmek
        private void BtnAddNewBook_Click(object sender, EventArgs e)
        {

            //textboxlarin bosh olmamagini yoxlamaq uchun if 
            if (!string.IsNullOrEmpty(TxtNewBookAuthor.Text) ||
                !string.IsNullOrEmpty(TxtNewBookGenre.Text) ||
                !string.IsNullOrEmpty(TxtNewBookName.Text) ||
                !string.IsNullOrEmpty(TxtNewBookPrice.Text) 
               


            {
                //yaradilan kitabi database elave etmek uchun
                Book book = new Book
                {


                    Title = TxtNewBookName.Text,
                    Genre = TxtNewBookGenre.Text,
                    Author = TxtNewBookAuthor.Text,
                    
                    Price = Convert.ToDecimal(TxtNewBookPrice.Text)


                };
                Context.Books.Add(book);
                Context.SaveChanges();

                this.Close();

            }
        }
    }
}
