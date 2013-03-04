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
    public partial class AddLibrarianForm : Form, IAddLibrarian
    {
        public AddLibrarianForm()
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

        public string getFirstName()
        {
            return txtFirstName.Text;
        }

        public string getLastName()
        {
            return txtLastName.Text;
        }

        public DateTime getStartOfContract()
        {
            return txtStartOfContract.Value;
        }

        public string getDepartment()
        {
            return txtDepartment.Text;
        }

        public string getTelephone()
        {
            return txtTelephone.Text;
        }

        public string getEmail()
        {
            return txtEmail.Text;
        }
    }
}
