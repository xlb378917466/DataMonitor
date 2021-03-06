﻿using DataMonitor.DQ.BusinessLayer;
using DataMonitor.DQ.Infrastructure;
using DataMonitor.DQ.Infrastructure.DataRepository;
using DataMonitor.DQ.Infrastructure.Security;
using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DataMonitor.DQ.UI
{
    public partial class Login : Office2007Form
    {
        const string userprofilefile = "userprofile.xml";
        public Login()
        {
            InitializeComponent();
            this.EnableGlass = false;
            ReadUserProfile();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPwd.Text;

            if (SignIn(username, password))
            {
                this.Hide();
                SaveUserProfile(username, password);
                MainForm mainForm = new MainForm();
                mainForm.WindowState = FormWindowState.Maximized;
                mainForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("登录失败，请重试");
            }
        }


        private void SaveUserProfile(string username, string password)
        {
            if (!chkRememberPassword.Checked)
            {
                username = string.Empty;
                password = string.Empty;
            }
            XDocument xdoc = new XDocument(
                                        new XDeclaration("1.0", "utf-8", "yes"),
                                        new XElement("root",
                                        new XElement("username", username),
                                        new XElement("password", password)
                                        ));
            xdoc.Save(userprofilefile);

        }
        private void ReadUserProfile()
        {
            if (File.Exists(userprofilefile))
            {
                XElement xele = XElement.Load(userprofilefile);
                XElement usernameEle = xele.Element("username");
                XElement pwdEle = xele.Element("password");
                txtUserName.Text = usernameEle.Value;
                txtPwd.Text = pwdEle.Value;
            }

        }

        private bool SignIn(string username, string password)
        {
            var encryptedpwd = SecurityHelper.Md5Encode(password);
            var user = AuthenticationService.SignIn(username, encryptedpwd);
            Singleton.Instance.CurrentUser = user;
            Singleton.Instance.Modules = user.Role.RoleModules.Select(o => o.Module).ToList();
            return user != null;
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
