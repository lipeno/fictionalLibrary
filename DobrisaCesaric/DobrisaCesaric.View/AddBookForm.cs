using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DobrisaCesaric.Utility;

namespace DobrisaCesaric.View
{
    public partial class AddBookForm : Form, IAddBook
    {
        public AddBookForm()
        {
            InitializeComponent();
        }

        public bool ShowForm()
        {
            if (ShowDialog() == DialogResult.OK)
                return true;
            else
            {
                return false;
            }
        }

        public string getBookName()
        {
            return txtBookName.Text;
        }

        public string getAuthorName()
        {
            return txtAuthorName.Text;
        }

        public string getIsbn()
        {
            return txtIsbn.Text;
        }
    }
}
