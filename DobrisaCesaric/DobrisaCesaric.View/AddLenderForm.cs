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
    public partial class AddLenderForm : Form, IAddLender
    {
        public AddLenderForm()
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

        public DateTime getMemberSince()
        {
            return txtMemberSince.Value;
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
