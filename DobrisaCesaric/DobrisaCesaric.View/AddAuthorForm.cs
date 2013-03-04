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
    public partial class AddAuthorForm : Form, IAddAuthor
    {
        public AddAuthorForm()
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

        public string getAuthorName()
        {
            return txtAuthorName.Text;
        }

        public string getAuthorDescription()
        {
            return txtAuthorDescription.Text;
        }

        public DateTime getAuthorDob()
        {
            return txtDob.Value;
        }
    }
}
