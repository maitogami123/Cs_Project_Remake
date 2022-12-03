using ComponentFactory.Krypton.Toolkit;
using MyFuckingProject.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFuckingProject
{
    public partial class Edit_Account_Form : KryptonForm
    {
        private string prevUsername;
        private string prevPassword;
        private string prevType;

        public Edit_Account_Form(Account_Form accountFormContext)
        {
            InitializeComponent();
        }
        public Edit_Account_Form(string username, string password, string accountType)
        {
            InitializeComponent();
            prevUsername = username;
            prevPassword = password;
            prevType = accountType;
            usernameTextBox.Text = username;
            pwdTxtBox.Text = password;
            typeCbBox.Text = accountType;
        }

        private void editHandler(string curValue, string prevValue)
        {
            if (!curValue.Equals(prevValue))
            {
                saveEditBtn.Visible = true;
            }
            else
            {
                saveEditBtn.Visible = false;
            }
        }

        private void editUserNameBtn_Click(object sender, EventArgs e)
        {
            editUserNameBtn.Visible = false;
            usernameTextBox.Enabled = true;
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            editHandler(usernameTextBox.Text, prevUsername);
        }

        private void editPasswordBtn_Click(object sender, EventArgs e)
        {
            editPasswordBtn.Visible = false;
            pwdTxtBox.Enabled = true;
        }

        private void pwdTxtBox_TextChanged(object sender, EventArgs e)
        {
            editHandler(pwdTxtBox.Text, prevPassword);
        }

        private void editTypeBtn_Click(object sender, EventArgs e)
        {
            editTypeBtn.Visible = false;
            typeCbBox.Enabled = true;
        }

        private void typeCbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            editHandler(typeCbBox.Text, prevType);
        }

        private void saveEditBtn_Click(object sender, EventArgs e)
        {
            //TODO: send new data to SQL server
        }
    }
}
