using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using IOProjectForm.data;

namespace IOProjectForm.forms
{
    public partial class MainForm : Form
    {
        private string pathDataSource;
        private string flag;
        private DataTable studentTable;
        private int indexSelectionTable;
        private List<Student> listStudent;
        public MainForm()
        {
            InitializeComponent();
        }

        public DataTable createTable()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("id");
            dataTable.Columns.Add("name");
            dataTable.Columns.Add("group");
            dataTable.Columns.Add("point");
            listStudent = IOStream.readLineStudent(pathDataSource);
            if(listStudent != null && listStudent.Count > 0)
            {
                for(int i = 0; i < listStudent.Count; i++)
                {
                    
                    Student item = listStudent[i];
                    if(item == null)
                    {
                        break;
                    }
                    dataTable.Rows.Add(item.getID(),
                                       item.getName(),
                                       item.getGroup()+"",
                                       item.getPoint()+"");
                }
            }else
            {
                listStudent = new List<Student>();
            }
            return dataTable;
        }

        public void lockControl()
        {
            btn_add_student.Enabled = true;
            btn_edit_student.Enabled = true;
            btn_delete_student.Enabled = true;

            btn_save_student.Enabled = false;
            btn_cancel_student.Enabled = false;

            tb_student_id.ReadOnly = true;
            tb_student_name.ReadOnly = true;
            tb_student_group.ReadOnly = true;

            btn_add_student.Focus();
        }

        public void unlockControl()
        {
            btn_add_student.Enabled = false;
            btn_edit_student.Enabled = false;
            btn_delete_student.Enabled = false;

            btn_save_student.Enabled = true;
            btn_cancel_student.Enabled = true;

            tb_student_id.ReadOnly = false;
            tb_student_name.ReadOnly = false;
            tb_student_group.ReadOnly = false;

            tb_student_id.Focus();
        }

        private void refreshTextbox()
        {
            tb_student_id.Text = "";
            tb_student_name.Text = "";
            tb_student_group.Text = "";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            pathDataSource = DataPath.pathStudent;
            lockControl();
            studentTable = createTable();
            dataGridStudent.DataSource = studentTable;
            dataGridStudent.RefreshEdit();
            refreshTextbox();
            tb_search_data.Text = "";
        }

        private void btn_edit_student_Click(object sender, EventArgs e)
        {
            unlockControl();
            flag = "edit";
        }

        private void btn_delete_student_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa học sinh này?","Cảnh báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                listStudent.RemoveAt(indexSelectionTable);
                IOStream.writeLineStudent(pathDataSource, listStudent, false);
                studentTable.Rows.RemoveAt(indexSelectionTable);
                
                dataGridStudent.DataSource = studentTable;
                dataGridStudent.RefreshEdit();
            }
        }

        private void btn_cancel_student_Click(object sender, EventArgs e)
        {
            refreshTextbox();
            lockControl();
        }

        private bool checkData()
        {
            if (string.IsNullOrWhiteSpace(tb_student_id.Text))
            {
                MessageBox.Show("Bạn chưa nhập mã sinh viên", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_student_id.Focus();
                return false;
            }else
            {
                if (!MyValidate.validateID(tb_student_id.Text)){
                    MessageBox.Show("Mã sinh viên phải gồm 8 kí tự", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_student_id.Focus();
                    return false;
                }
            }
            if (string.IsNullOrWhiteSpace(tb_student_name.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên sinh viên", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_student_name.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(tb_student_group.Text))
            {
                MessageBox.Show("Bạn chưa nhập điểm toán của sinh viên", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_student_group.Focus();
                return false;
            }
            return true;
        }

        private void dataGridStudent_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                indexSelectionTable = dataGridStudent.CurrentCell.RowIndex;
                DataTable item = (DataTable)dataGridStudent.DataSource;
                if (item.Rows.Count > 0)
                {
                    tb_student_id.Text = dataGridStudent.Rows[indexSelectionTable].Cells[0].Value.ToString();
                    tb_student_name.Text = dataGridStudent.Rows[indexSelectionTable].Cells[1].Value.ToString();
                    tb_student_group.Text = dataGridStudent.Rows[indexSelectionTable].Cells[2].Value.ToString();

                    lockControl();
                }
            }catch(Exception p)
            {
                Console.WriteLine(p.Message);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            List<Student> itemList;
            if((itemList = searchStudent(tb_search_data.Text)) != null)
            {
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("id");
                dataTable.Columns.Add("name");
                dataTable.Columns.Add("group");
                dataTable.Columns.Add("point");
                for (int i = 0; i < itemList.Count; i++)
                {
                    Student item = itemList[i];
                    dataTable.Rows.Add(item.getID(),
                                       item.getName(),
                                       item.getGroup().ToString(),
                                       item.getPoint().ToString());
                }
                dataGridStudent.DataSource = dataTable;
                dataGridStudent.RefreshEdit();
            }
        }

        private List<Student> searchStudent(string data)
        {
            if (string.IsNullOrWhiteSpace(data))
            {
                MessageBox.Show("Nhập dữ liệu bạn cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            List<Student> listSearch = new List<Student>();
            try
            {
                if(data.Length == 8)
                {
                    for (int i = 0; i < listStudent.Count; i++)
                    {
                        if (listStudent[i].getID().Equals(data))
                        {
                            listSearch.Add(listStudent[i]);
                        }
                    }   
                }

                for(int i = 0; i < listStudent.Count; i++)
                {
                    if (listStudent[i].getName().Equals(data))
                    {
                        listSearch.Add(listStudent[i]);
                    }
                }

                for(int i = 0; i< listStudent.Count; i++)
                {
                    if (!listStudent[i].getName().Equals(data) && listStudent[i].getName().Contains(data))
                    {
                        listSearch.Add(listStudent[i]);
                    }
                }

            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return listSearch;
            }
            return listSearch;
        }

        private void btn_search_cancel_Click(object sender, EventArgs e)
        {
            studentTable = createTable();
            dataGridStudent.DataSource = studentTable;
            dataGridStudent.RefreshEdit();
            tb_search_data.Text = "";
            refreshTextbox();
        }

        private void btn_add_student_Click(object sender, EventArgs e)
        {
            unlockControl();
            flag = "add";
            refreshTextbox();
        }

        private void btn_save_student_Click(object sender, EventArgs e)
        {
            if (flag.Equals("add"))
            {
                if (checkData())
                {
                    string id = tb_student_id.Text;
                    string name = tb_student_name.Text;
                    string group = tb_student_group.Text;

                    Student itemStudent = new Student(name, id, group);
                    if (MyValidate.isStudentExists(itemStudent, listStudent))
                    {
                        MessageBox.Show("Sinh viên đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        unlockControl();
                    }
                    else
                    {
                        studentTable.Rows.Add(id, name, group,
                            itemStudent.getPoint()+"");
                        dataGridStudent.DataSource = studentTable;
                        listStudent.Add(itemStudent);
                        List<Student> itemList = new List<Student>();
                        itemList.Add(itemStudent);
                        IOStream.writeLineStudent(pathDataSource, itemList, true);
                        dataGridStudent.RefreshEdit();
                    }

                }
            }
            if (flag.Equals("edit"))
            {
                if (checkData())
                {
                    studentTable.Rows[indexSelectionTable][0] = tb_student_id.Text;
                    studentTable.Rows[indexSelectionTable][1] = tb_student_name.Text;
                    studentTable.Rows[indexSelectionTable][2] = tb_student_group.Text;

                    dataGridStudent.DataSource = studentTable;
                    dataGridStudent.RefreshEdit();
                    lockControl();
                }
            }
        }

        private void dataGridStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridStudent.Rows[rowIndex];
            ////
        }
    }
}
