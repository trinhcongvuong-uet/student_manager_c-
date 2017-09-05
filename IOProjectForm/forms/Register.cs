using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOProjectForm.forms
{
    public partial class RegisterForm : Form
    {
        private string pathDataSource;
        private List<User> listUser;
        
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            pathDataSource = data.DataPath.pathUser;
            tb_register_name.Focus();
            listUser = IOStream.readLineUser(pathDataSource);
            if (listUser == null)
            {
                listUser = new List<User>();
            }
        }

        private bool register()
        {
            if (string.IsNullOrWhiteSpace(tb_register_name.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_register_name.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(tb_register_password.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_register_password.Focus();
                return false;
            }else
            {
                if (!MyValidate.validatePassword(tb_register_password.Text))
                {
                    MessageBox.Show("Mật khẩu không đúng", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_register_password.Focus();
                    return false;
                }
            }

            if (string.IsNullOrWhiteSpace(tb_register_password_validate.Text))
            {
                MessageBox.Show("Bạn chưa xác nhận mật khẩu", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_register_password_validate.Focus();
                return false;
            }
            else
            {
                if (!MyValidate.validatePassword(tb_register_password_validate.Text))
                {
                    MessageBox.Show("Mật khẩu xác nhận không đúng", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_register_password_validate.Focus();
                    return false;
                }
            }

            if (!tb_register_password.Text.ToString().Equals(tb_register_password_validate.Text.ToString()))
            {
                MessageBox.Show("Xác nhận mật khẩu không trùng khớp" 
                    + tb_register_password.Text + tb_register_password_validate.Text , "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_register_password_validate.Focus();
                return false;
            }

            User user = new User(tb_register_name.Text, tb_register_password.Text);
            if (MyValidate.isUserExists(user, listUser))
            {
                MessageBox.Show("Tài khoản đã tồn tại", "Thông báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_register_name.Focus();
                tb_register_password_validate.Text = "";
                tb_register_password.Text = "";
                return false;
            }else
            {
                List<User> list = new List<User>();
                list.Add(user);
                IOStream.writeLineUser(pathDataSource, list, true);
                return true;
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (register())
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Closed += (s, args) => this.Close();
                mainForm.Show();
            }
        }

        private void btn_register_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Closed += (s, args) => this.Close();
            loginForm.Show();
        }
    }
}
