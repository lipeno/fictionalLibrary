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
using DobrisaCesaric.Utility;

namespace DobrisaCesaric.View
{
    public partial class ViewAuthorsForm : Form, IObserver, IViewAuthors
    {
        public ViewAuthorsForm()
        {
            InitializeComponent();
        }

        public void ShowForm()
        {
            Show();
        }

        public void update()
        {
            UpdateListAuthors();
        }

        private void UpdateListAuthors()
        {
            listAuthors.Items.Clear();

            int num = AuthorRepository.GetInstance().Count();
            for (int i = 0; i < num; i++)
            {
                Author author = AuthorRepository.GetInstance().GetAuthorByIndex(i);
                ListViewItem lvt = new ListViewItem(author.Name);
                lvt.SubItems.Add(author.Description);
                lvt.SubItems.Add(author.Dob.ToString("yyyy-MM-dd"));
              
                listAuthors.Items.Add(lvt);
            }
        }

        private void ViewAuthorsForm_Load_1(object sender, EventArgs e)
        {
            UpdateListAuthors();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            MainController mainController = new MainController();
            AddAuthorForm frmAddAuthor = new AddAuthorForm();
            mainController.addNewAuthor(frmAddAuthor);
        }
    }
}
