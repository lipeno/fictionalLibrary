using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DobrisaCesaric.Controller;
using DobrisaCesaric.DomainModel.Repositories;
using DobrisaCesaric.DomainModel;
using DobrisaCesaric.Utility;

namespace DobrisaCesaric.View
{
    public partial class LendForm : Form, ILend, IObserver
    {
        public LendForm()
        {
            InitializeComponent();
        }

        public void ShowForm()
        {
            Show();
        }

        public void UpdateList()
        {
            // refresh lenders list and librarians
                int num = UserRepository.GetInstance().Count();
                List<string> _itemsUsers = new List<string>();

            List<string> _itemsLibrarians = new List<string>();

            for (int i = 0; i < num; i++)
            {
                User user = UserRepository.GetInstance().GetuserByIndex(i);
                if (user is BookLender)
                {
                    _itemsUsers.Add(user.GetFullName());
                }
                if (user is Librarian)
                {
                    _itemsLibrarians.Add(user.GetFullName());
                }
            }

            lstLenders.DataSource = _itemsUsers;

            cboLibrarian.DataSource = _itemsLibrarians;

            // refresh books list
            num = BookRepository.GetInstance().Count();
            List<string> _itemsBooks = new List<string>();

            for (int i = 0; i < num; i++)
            {
                Book book = BookRepository.GetInstance().GetBookByIndex(i);
                _itemsBooks.Add(book.Name);
            }
            lstBooks.DataSource = _itemsBooks;

        }

        private void LendForm_Load(object sender, EventArgs e)
        {
            UpdateList();
            UpdateListLendings();
        }

        public void update()
        {
            UpdateListLendings();
        }

        private void UpdateListLendings()
        {
            lstLendings.Items.Clear();

            int num = LendingRepository.GetInstance().Count();
            for (int i = 0; i < num; i++)
            {
                Lending lending = LendingRepository.GetInstance().getLendingByIndex(i);
                ListViewItem lvt = new ListViewItem(lending.Book.Name);
                lvt.SubItems.Add(lending.BookLender.GetFullName());

                lstLendings.Items.Add(lvt);
            }
        }

        public int getBook()
        {
            return lstBooks.SelectedIndex;
        }

        public string getLibrarian()
        {
            return cboLibrarian.Text;
        }

        public string getLender()
        {
            return lstLenders.Text;
        }

        public int getLending()
        {
            int selected = 0;
            if (lstLendings.SelectedIndices.Count > 0)
            {
                selected = lstLendings.SelectedIndices[0];
            }
            return selected;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            MainController mainController = new MainController();
            LendForm frm = (LendForm) Form.ActiveForm;
            
            mainController.lend(frm);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MainController mainController = new MainController();
                LendForm frm = (LendForm)Form.ActiveForm;

                mainController.returnbook(frm);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

    }
}
