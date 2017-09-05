using System;
using System.Windows.Forms;
using IOProjectForm.forms;
using System.Collections.Generic;
using IOProjectForm.data;
namespace IOProjectForm
{
    public partial class LoginForm : Form
    {
        private string pathDataSource;
        private List<User> listUser = new List<User>();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            pathDataSource = DataPath.pathUser;
            tb_login_name.Focus();
            listUser = IOStream.readLineUser(pathDataSource);
            if(listUser == null)
            {
                listUser = new List<User>();
            }
        }

        public void btn_login_Click(object sender, EventArgs e)
        {
            if (login())
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Closed += (s, args) => this.Close();
                mainForm.Show();
            }
        }

        private bool login()
        {
            if (string.IsNullOrWhiteSpace(tb_login_name.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_login_name.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(tb_login_password.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_login_password.Focus();
                return false;
            }else
            {
                if (!MyValidate.validatePassword(tb_login_password.Text))
                {
                    MessageBox.Show("Mật khẩu không đúng", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_login_password.Focus();
                    return false;
                }
            }

            for(int i = 0; i<listUser.Count; i++)
            {
                if (listUser[i].getID().Equals(tb_login_name.Text))
                {
                    if (listUser[i].getPassword().Equals(tb_login_password.Text))
                    {
                        MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }else
                    {
                        MessageBox.Show("Mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                }
            }
            MessageBox.Show("Tên đăng nhập và mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Closed += (s, args) => this.Close();
            registerForm.Show();
        }
    }
}
