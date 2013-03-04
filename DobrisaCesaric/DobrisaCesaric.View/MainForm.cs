using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DobrisaCesaric.Controller;
using DobrisaCesaric.DomainModel;
using DobrisaCesaric.DomainModel.Repositories;

namespace DobrisaCesaric.View
{
    public partial class MainForm : Form
    {
        MainController mainController = new MainController();

        void FillDummy()
        {
            mainController.fillDummy();
        }


        public MainForm()
        {
            InitializeComponent();
            FillDummy();
        }

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBookForm frmAddBook = new AddBookForm();
            ViewBooksForm frm = new ViewBooksForm();
            BookRepository.GetInstance().addObserver(frm);
            mainController.addNewBook(frmAddBook);
        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBooksForm form = new ViewBooksForm();
            mainController.viewBooks(form);
        }

        private void addLenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddLenderForm form = new AddLenderForm();
            mainController.addLender(form);
        }

        private void lendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LendForm form = new LendForm();
            LendingRepository.GetInstance().addObserver(form);
            mainController.viewLendings(form);
        }

        private void addAuthorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddAuthorForm frmAddAuthor = new AddAuthorForm();
            ViewAuthorsForm frm = new ViewAuthorsForm();
            AuthorRepository.GetInstance().addObserver(frm);
            mainController.addNewAuthor(frmAddAuthor);
        }

        private void viewAuthorsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewAuthorsForm form = new ViewAuthorsForm();
            mainController.viewAuthors(form);
        }

        private void addLibrarianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddLibrarianForm frm = new AddLibrarianForm();
            mainController.addNewLibrarian(frm);
        }

        private void bookLendingReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LendForm form = new LendForm();
            LendingRepository.GetInstance().addObserver(form);
            mainController.viewLendings(form);
        }
    }
}
