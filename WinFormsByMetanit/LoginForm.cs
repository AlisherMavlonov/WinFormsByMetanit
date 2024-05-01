using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsByMetanit.Domain.Entity;
using WinFormsByMetanit.Domain.ViewModels.User;
using WinFormsByMetanit.Service.Interfaces;

namespace WinFormsByMetanit
{
    public partial class LoginForm : Form
    {
        private readonly IUserService _userService;
        public LoginForm(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private async void loginButton1_Click(object sender, EventArgs e)
        {
            var login = loginBox1.Text;
            var password = passwordBox2.Text;
            var response = await _userService.GetUser(login, password);
            if (response.StatusCode != Domain.Enum.StatusCode.Ok)
            {
                MessageBox.Show(response.Description);
            }
            else
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
