namespace IOProjectForm
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.lb_login_name = new System.Windows.Forms.Label();
            this.tb_login_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_login_password = new System.Windows.Forms.Label();
            this.tb_login_password = new System.Windows.Forms.TextBox();
            this.lb_content = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(185, 120);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Đăng nhập";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(266, 120);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(75, 23);
            this.btn_register.TabIndex = 1;
            this.btn_register.Text = "Đăng kí";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // lb_login_name
            // 
            this.lb_login_name.AutoSize = true;
            this.lb_login_name.Location = new System.Drawing.Point(98, 62);
            this.lb_login_name.Name = "lb_login_name";
            this.lb_login_name.Size = new System.Drawing.Size(81, 13);
            this.lb_login_name.TabIndex = 2;
            this.lb_login_name.Text = "Tên đăng nhập";
            // 
            // tb_login_name
            // 
            this.tb_login_name.Location = new System.Drawing.Point(185, 59);
            this.tb_login_name.Name = "tb_login_name";
            this.tb_login_name.Size = new System.Drawing.Size(224, 20);
            this.tb_login_name.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // lb_login_password
            // 
            this.lb_login_password.AutoSize = true;
            this.lb_login_password.Location = new System.Drawing.Point(98, 94);
            this.lb_login_password.Name = "lb_login_password";
            this.lb_login_password.Size = new System.Drawing.Size(52, 13);
            this.lb_login_password.TabIndex = 4;
            this.lb_login_password.Text = "Mật khẩu";
            // 
            // tb_login_password
            // 
            this.tb_login_password.Location = new System.Drawing.Point(185, 91);
            this.tb_login_password.Name = "tb_login_password";
            this.tb_login_password.Size = new System.Drawing.Size(224, 20);
            this.tb_login_password.TabIndex = 5;
            // 
            // lb_content
            // 
            this.lb_content.AutoSize = true;
            this.lb_content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_content.Location = new System.Drawing.Point(106, 12);
            this.lb_content.Name = "lb_content";
            this.lb_content.Size = new System.Drawing.Size(179, 16);
            this.lb_content.TabIndex = 6;
            this.lb_content.Text = "ĐĂNG NHẬP HỆ THỐNG";
            this.lb_content.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 95);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 169);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_content);
            this.Controls.Add(this.tb_login_password);
            this.Controls.Add(this.lb_login_password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_login_name);
            this.Controls.Add(this.lb_login_name);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.btn_login);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Label lb_login_name;
        private System.Windows.Forms.TextBox tb_login_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_login_password;
        private System.Windows.Forms.TextBox tb_login_password;
        private System.Windows.Forms.Label lb_content;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

