namespace IOProjectForm.forms
{
    partial class MainForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tab_manager_student = new System.Windows.Forms.TabPage();
            this.btn_search_cancel = new System.Windows.Forms.Button();
            this.tb_search_data = new System.Windows.Forms.TextBox();
            this.btn_cancel_student = new System.Windows.Forms.Button();
            this.btn_save_student = new System.Windows.Forms.Button();
            this.btn_delete_student = new System.Windows.Forms.Button();
            this.btn_edit_student = new System.Windows.Forms.Button();
            this.btn_add_student = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.dataGridStudent = new System.Windows.Forms.DataGridView();
            this.column_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_point = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_student_group = new System.Windows.Forms.TextBox();
            this.lb_student_group = new System.Windows.Forms.Label();
            this.tb_student_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_student_id = new System.Windows.Forms.TextBox();
            this.lb_student_id = new System.Windows.Forms.Label();
            this.tab_user = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.tab_manager_student.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tab_manager_student);
            this.tabControl.Controls.Add(this.tab_user);
            this.tabControl.Location = new System.Drawing.Point(-1, -2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(759, 442);
            this.tabControl.TabIndex = 0;
            // 
            // tab_manager_student
            // 
            this.tab_manager_student.Controls.Add(this.btn_search_cancel);
            this.tab_manager_student.Controls.Add(this.tb_search_data);
            this.tab_manager_student.Controls.Add(this.btn_cancel_student);
            this.tab_manager_student.Controls.Add(this.btn_save_student);
            this.tab_manager_student.Controls.Add(this.btn_delete_student);
            this.tab_manager_student.Controls.Add(this.btn_edit_student);
            this.tab_manager_student.Controls.Add(this.btn_add_student);
            this.tab_manager_student.Controls.Add(this.btn_search);
            this.tab_manager_student.Controls.Add(this.dataGridStudent);
            this.tab_manager_student.Controls.Add(this.tb_student_group);
            this.tab_manager_student.Controls.Add(this.lb_student_group);
            this.tab_manager_student.Controls.Add(this.tb_student_name);
            this.tab_manager_student.Controls.Add(this.label1);
            this.tab_manager_student.Controls.Add(this.tb_student_id);
            this.tab_manager_student.Controls.Add(this.lb_student_id);
            this.tab_manager_student.Location = new System.Drawing.Point(4, 22);
            this.tab_manager_student.Name = "tab_manager_student";
            this.tab_manager_student.Padding = new System.Windows.Forms.Padding(3);
            this.tab_manager_student.Size = new System.Drawing.Size(751, 416);
            this.tab_manager_student.TabIndex = 0;
            this.tab_manager_student.Text = "Manager ";
            this.tab_manager_student.UseVisualStyleBackColor = true;
            // 
            // btn_search_cancel
            // 
            this.btn_search_cancel.Location = new System.Drawing.Point(510, 123);
            this.btn_search_cancel.Name = "btn_search_cancel";
            this.btn_search_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_search_cancel.TabIndex = 41;
            this.btn_search_cancel.Text = "Tất cả";
            this.btn_search_cancel.UseVisualStyleBackColor = true;
            // 
            // tb_search_data
            // 
            this.tb_search_data.Location = new System.Drawing.Point(3, 126);
            this.tb_search_data.Name = "tb_search_data";
            this.tb_search_data.Size = new System.Drawing.Size(378, 20);
            this.tb_search_data.TabIndex = 39;
            // 
            // btn_cancel_student
            // 
            this.btn_cancel_student.Location = new System.Drawing.Point(522, 76);
            this.btn_cancel_student.Name = "btn_cancel_student";
            this.btn_cancel_student.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel_student.TabIndex = 38;
            this.btn_cancel_student.Text = "Hủy";
            this.btn_cancel_student.UseVisualStyleBackColor = true;
            this.btn_cancel_student.Click += new System.EventHandler(this.btn_cancel_student_Click);
            // 
            // btn_save_student
            // 
            this.btn_save_student.Location = new System.Drawing.Point(414, 76);
            this.btn_save_student.Name = "btn_save_student";
            this.btn_save_student.Size = new System.Drawing.Size(75, 23);
            this.btn_save_student.TabIndex = 37;
            this.btn_save_student.Text = "Lưu";
            this.btn_save_student.UseVisualStyleBackColor = true;
            this.btn_save_student.Click += new System.EventHandler(this.btn_save_student_Click);
            // 
            // btn_delete_student
            // 
            this.btn_delete_student.Location = new System.Drawing.Point(304, 76);
            this.btn_delete_student.Name = "btn_delete_student";
            this.btn_delete_student.Size = new System.Drawing.Size(75, 23);
            this.btn_delete_student.TabIndex = 36;
            this.btn_delete_student.Text = "Xóa";
            this.btn_delete_student.UseVisualStyleBackColor = true;
            this.btn_delete_student.Click += new System.EventHandler(this.btn_delete_student_Click);
            // 
            // btn_edit_student
            // 
            this.btn_edit_student.Location = new System.Drawing.Point(204, 76);
            this.btn_edit_student.Name = "btn_edit_student";
            this.btn_edit_student.Size = new System.Drawing.Size(75, 23);
            this.btn_edit_student.TabIndex = 35;
            this.btn_edit_student.Text = "Sửa";
            this.btn_edit_student.UseVisualStyleBackColor = true;
            this.btn_edit_student.Click += new System.EventHandler(this.btn_edit_student_Click);
            // 
            // btn_add_student
            // 
            this.btn_add_student.Location = new System.Drawing.Point(102, 76);
            this.btn_add_student.Name = "btn_add_student";
            this.btn_add_student.Size = new System.Drawing.Size(75, 23);
            this.btn_add_student.TabIndex = 34;
            this.btn_add_student.Text = "Thêm";
            this.btn_add_student.UseVisualStyleBackColor = true;
            this.btn_add_student.Click += new System.EventHandler(this.btn_add_student_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(405, 123);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 40;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // dataGridStudent
            // 
            this.dataGridStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_id,
            this.column_name,
            this.column_group,
            this.column_point});
            this.dataGridStudent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridStudent.Location = new System.Drawing.Point(3, 152);
            this.dataGridStudent.Name = "dataGridStudent";
            this.dataGridStudent.Size = new System.Drawing.Size(745, 261);
            this.dataGridStudent.TabIndex = 33;
            this.dataGridStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridStudent_CellContentClick);
            // 
            // column_id
            // 
            this.column_id.DataPropertyName = "id";
            this.column_id.Frozen = true;
            this.column_id.HeaderText = "Mã sinh viên";
            this.column_id.Name = "column_id";
            this.column_id.Width = 150;
            // 
            // column_name
            // 
            this.column_name.DataPropertyName = "name";
            this.column_name.HeaderText = "Tên sinh viên";
            this.column_name.Name = "column_name";
            this.column_name.Width = 300;
            // 
            // column_group
            // 
            this.column_group.DataPropertyName = "group";
            this.column_group.HeaderText = "Lớp khóa học";
            this.column_group.Name = "column_group";
            this.column_group.Width = 150;
            // 
            // column_point
            // 
            this.column_point.DataPropertyName = "point";
            this.column_point.HeaderText = "Điểm tổng kết";
            this.column_point.Name = "column_point";
            // 
            // tb_student_group
            // 
            this.tb_student_group.Location = new System.Drawing.Point(620, 28);
            this.tb_student_group.Name = "tb_student_group";
            this.tb_student_group.Size = new System.Drawing.Size(98, 20);
            this.tb_student_group.TabIndex = 28;
            // 
            // lb_student_group
            // 
            this.lb_student_group.AutoSize = true;
            this.lb_student_group.Location = new System.Drawing.Point(541, 31);
            this.lb_student_group.Name = "lb_student_group";
            this.lb_student_group.Size = new System.Drawing.Size(73, 13);
            this.lb_student_group.TabIndex = 27;
            this.lb_student_group.Text = "Lớp khóa học";
            // 
            // tb_student_name
            // 
            this.tb_student_name.Location = new System.Drawing.Point(327, 28);
            this.tb_student_name.Name = "tb_student_name";
            this.tb_student_name.Size = new System.Drawing.Size(177, 20);
            this.tb_student_name.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tên sinh viên";
            // 
            // tb_student_id
            // 
            this.tb_student_id.Location = new System.Drawing.Point(102, 28);
            this.tb_student_id.Name = "tb_student_id";
            this.tb_student_id.Size = new System.Drawing.Size(127, 20);
            this.tb_student_id.TabIndex = 22;
            // 
            // lb_student_id
            // 
            this.lb_student_id.AutoSize = true;
            this.lb_student_id.Location = new System.Drawing.Point(29, 31);
            this.lb_student_id.Name = "lb_student_id";
            this.lb_student_id.Size = new System.Drawing.Size(67, 13);
            this.lb_student_id.TabIndex = 21;
            this.lb_student_id.Text = "Mã sinh viên";
            // 
            // tab_user
            // 
            this.tab_user.Location = new System.Drawing.Point(4, 22);
            this.tab_user.Name = "tab_user";
            this.tab_user.Padding = new System.Windows.Forms.Padding(3);
            this.tab_user.Size = new System.Drawing.Size(751, 416);
            this.tab_user.TabIndex = 1;
            this.tab_user.Text = "User";
            this.tab_user.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 434);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ SINH VIÊN";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tab_manager_student.ResumeLayout(false);
            this.tab_manager_student.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tab_manager_student;
        private System.Windows.Forms.Button btn_search_cancel;
        private System.Windows.Forms.TextBox tb_search_data;
        private System.Windows.Forms.Button btn_cancel_student;
        private System.Windows.Forms.Button btn_save_student;
        private System.Windows.Forms.Button btn_delete_student;
        private System.Windows.Forms.Button btn_edit_student;
        private System.Windows.Forms.Button btn_add_student;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dataGridStudent;
        private System.Windows.Forms.TextBox tb_student_group;
        private System.Windows.Forms.Label lb_student_group;
        private System.Windows.Forms.TextBox tb_student_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_student_id;
        private System.Windows.Forms.Label lb_student_id;
        private System.Windows.Forms.TabPage tab_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_group;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_point;
    }
}