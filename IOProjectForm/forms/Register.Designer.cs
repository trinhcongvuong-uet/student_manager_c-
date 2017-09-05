namespace IOProjectForm.forms
{
    partial class RegisterForm
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
            this.btn_register = new System.Windows.Forms.Button();
            this.lb_register_name = new System.Windows.Forms.Label();
            this.tb_register_name = new System.Windows.Forms.TextBox();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.lb_register_pasword_validate = new System.Windows.Forms.Label();
            this.tb_register_password = new System.Windows.Forms.TextBox();
            this.lb_register_passord = new System.Windows.Forms.Label();
            this.btn_register_cancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_register_password_validate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(215, 141);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(75, 23);
            this.btn_register.TabIndex = 0;
            this.btn_register.Text = "Đăng kí";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // lb_register_name
            // 
            this.lb_register_name.AutoSize = true;
            this.lb_register_name.Location = new System.Drawing.Point(112, 57);
            this.lb_register_name.Name = "lb_register_name";
            this.lb_register_name.Size = new System.Drawing.Size(81, 13);
            this.lb_register_name.TabIndex = 1;
            this.lb_register_name.Text = "Tên đăng nhập";
            // 
            // tb_register_name
            // 
            this.tb_register_name.Location = new System.Drawing.Point(215, 54);
            this.tb_register_name.Name = "tb_register_name";
            this.tb_register_name.Size = new System.Drawing.Size(208, 20);
            this.tb_register_name.TabIndex = 2;
            // 
            // lb_register_pasword_validate
            // 
            this.lb_register_pasword_validate.AutoSize = true;
            this.lb_register_pasword_validate.Location = new System.Drawing.Point(112, 109);
            this.lb_register_pasword_validate.Name = "lb_register_pasword_validate";
            this.lb_register_pasword_validate.Size = new System.Drawing.Size(93, 13);
            this.lb_register_pasword_validate.TabIndex = 3;
            this.lb_register_pasword_validate.Text = "Nhập lại mật khẩu";
            // 
            // tb_register_password
            // 
            this.tb_register_password.Location = new System.Drawing.Point(215, 80);
            this.tb_register_password.Name = "tb_register_password";
            this.tb_register_password.Size = new System.Drawing.Size(208, 20);
            this.tb_register_password.TabIndex = 6;
            // 
            // lb_register_passord
            // 
            this.lb_register_passord.AutoSize = true;
            this.lb_register_passord.Location = new System.Drawing.Point(112, 83);
            this.lb_register_passord.Name = "lb_register_passord";
            this.lb_register_passord.Size = new System.Drawing.Size(52, 13);
            this.lb_register_passord.TabIndex = 5;
            this.lb_register_passord.Text = "Mật khẩu";
            // 
            // btn_register_cancel
            // 
            this.btn_register_cancel.Location = new System.Drawing.Point(296, 141);
            this.btn_register_cancel.Name = "btn_register_cancel";
            this.btn_register_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_register_cancel.TabIndex = 7;
            this.btn_register_cancel.Text = "Thoát";
            this.btn_register_cancel.UseVisualStyleBackColor = true;
            this.btn_register_cancel.Click += new System.EventHandler(this.btn_register_cancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 93);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "ĐĂNG KÍ TÀI KHOẢN";
            // 
            // tb_register_password_validate
            // 
            this.tb_register_password_validate.Location = new System.Drawing.Point(215, 106);
            this.tb_register_password_validate.Name = "tb_register_password_validate";
            this.tb_register_password_validate.Size = new System.Drawing.Size(208, 20);
            this.tb_register_password_validate.TabIndex = 10;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 194);
            this.Controls.Add(this.tb_register_password_validate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_register_cancel);
            this.Controls.Add(this.tb_register_password);
            this.Controls.Add(this.lb_register_passord);
            this.Controls.Add(this.lb_register_pasword_validate);
            this.Controls.Add(this.tb_register_name);
            this.Controls.Add(this.lb_register_name);
            this.Controls.Add(this.btn_register);
            this.Name = "RegisterForm";
            this.Text = "Đăng kí";
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Label lb_register_name;
        private System.Windows.Forms.TextBox tb_register_name;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Label lb_register_pasword_validate;
        private System.Windows.Forms.TextBox tb_register_password;
        private System.Windows.Forms.Label lb_register_passord;
        private System.Windows.Forms.Button btn_register_cancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_register_password_validate;
    }
}