using LLIB.Data;
using System;
using System.Windows.Forms;

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

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        public object TxtNewBookName { get; private set; }
        public object TxtNewBookGenre { get; private set; }
        public object TxtNewBookPrice { get; private set; }
        public object TxtNewBookAuthor { get; private set; }

        internal LibraryContext Context => context;

        ////kitab elave etmek
        private void BtnAddNewBook_Click(object sender, EventArgs e)
        {

            //textboxlarin bosh olmamagini yoxlamaq uchun if 
            if (!NewMethod() ||
                !string.IsNullOrEmpty(TxtNewBookGenre.Text) ||
                !string.IsNullOrEmpty(TxtNewBookAuthor.Text) ||
                !string.IsNullOrEmpty(TxtNewBookPrice.Text) ||





            {
                //yaradilan kitabi database elave etmek uchun
                Book book = GetBook();
                Book book1 = book;
                NewMethod1(book1);
                Context.SaveChanges();

                this.Close();

            }
        }

        private LLIB.Models.BookGenre NewMethod1(Book book)
        {
            return Context.Book1.Add(NewMethod2(book));
        }

        private static Book NewMethod2(Book book1)
        {
            return GetBook(book1);
        }

        private static Book GetBook(Book book1)
        {
            return book1;
        }

        private bool NewMethod()
        {
            return string.IsNullOrEmpty(TxtNewBookName.Text);
        }

        private Book GetBook()
        {
            return new Book
            {


                Name = TxtNewBookName.Text,
                Genre = TxtNewBookGenre.Text,
                Author = TxtNewBookAuthor.Text,

                Price = Convert.ToDecimal(TxtNewBookPrice.Text)


            };
        }
    }
}
