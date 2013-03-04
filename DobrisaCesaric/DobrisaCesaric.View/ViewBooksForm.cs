using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using DobrisaCesaric.Controller;
using System.Windows.Forms;
using DobrisaCesaric.DomainModel;
using DobrisaCesaric.DomainModel.Repositories;
using DobrisaCesaric.Utility;


namespace DobrisaCesaric.View
{
    public partial class ViewBooksForm : Form, IObserver, IViewBooks
    {
        public ViewBooksForm()
        {
            InitializeComponent();
        }

        public void ShowForm()
        {
            Show();
        }

        public void update()
        {
            UpdateListBooks();
        }

        private void UpdateListBooks()
        {
            listBooks.Items.Clear();

            int num = BookRepository.GetInstance().Count();
            for (int i = 0; i < num; i++)
            {
                Book book = BookRepository.GetInstance().GetBookByIndex(i);
                ListViewItem lvt = new ListViewItem(book.Isbn);
                lvt.SubItems.Add(book.Name);
                lvt.SubItems.Add(book.Authors.First().Name);

                listBooks.Items.Add(lvt);
            }
        }

        private void ViewBooksForm_Load(object sender, EventArgs e)
        {
            UpdateListBooks();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            MainController mainController = new MainController();
            AddBookForm frmAddBook = new AddBookForm();
            mainController.addNewBook(frmAddBook);
        }
    }
}
