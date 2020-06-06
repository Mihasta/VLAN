using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracking
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (BTContext db = new BTContext())
            {
                User admin = new User
                {
                    Name = "admin",
                    Surname = "admin",
                    Login = "admin",
                    Password = "123",
                    Status = UserStatus.Admin,
                    Mail = "admin@mail.ru",
                    PhoneNumber = "+79666666666"
                };
                db.Users.Add(admin);
                db.SaveChanges();
                Console.WriteLine("Успешно добавлено");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddUser adduser = new AddUser();
            adduser.Show();
        }


        private void Edit_User(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;
                EditUser edituser = new EditUser(id);
                edituser.Show();

            }
        }

        private void Delete_User(object sender, EventArgs e)
        {
            using (BTContext db = new BTContext())
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int index = dataGridView1.SelectedRows[0].Index;
                    int id = 0;
                    bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                    if (converted == false)
                        return;
                    User user = db.Users.Find(id);
                    db.Users.Remove(user);
                    db.SaveChanges();

                }
            }
        }
        private void Users_Load_1(object sender, EventArgs e)
        {
            /*var types = new List<string>();
            types.Add("All");*/
            BTContext db = new BTContext();
            dataGridView1.DataSource = db.Users.ToList();

            if (Globals.user_status == "Moderator")
            {
                DelUser.Visible = false;
                EditUser.Visible = false;
                this.dataGridView1.Columns["Password"].Visible = false;
            }
            else if (Globals.user_status == "Admin")
            {
                dataGridView1.DataSource = db.Users.ToList();
            }

            ToolTip tt = new ToolTip();

            tt.SetToolTip(addUser, "Добавить пользователя");
            tt.SetToolTip(EditUser, "Редактировать пользователя");
            tt.SetToolTip(DelUser, "Удалить пользователя");
            tt.SetToolTip(refresh, "Обновить");

            dataGridView1.Columns[0].Width = Convert.ToInt32(dataGridView1.Columns[7].Width * 0.3);
            dataGridView1.Columns[1].HeaderText = "Имя";
            dataGridView1.Columns[2].HeaderText = "Имя";
            dataGridView1.Columns[3].HeaderText = "Логин";
            dataGridView1.Columns[4].HeaderText = "Пароль";
            dataGridView1.Columns[5].HeaderText = "Статус";
            dataGridView1.Columns[6].HeaderText = "E-mail";
            dataGridView1.Columns[7].HeaderText = "Номер телефона";
            dataGridView1.Columns[8].HeaderText = "Ошибки";
            dataGridView1.Columns[9].HeaderText = "Решения";

            dataGridView1.Columns["Errors"].Visible = false;
            dataGridView1.Columns["Solutions"].Visible = false;

            CreateSettings();
            FixCheckBoxes();
            TableUpdate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BTContext db = new BTContext();
            dataGridView1.DataSource = db.Users.ToList();
        }

        private void Users_KeyDown(object sender, KeyEventArgs e)

        {
            if (Globals.user_status == "Moderator")
            {
                if (e.KeyCode == Keys.F5)
                {
                    BTContext db = new BTContext();
                    dataGridView1.DataSource = db.Users.ToList();

                }

                if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
                {
                    AddUser adduser = new AddUser();
                    adduser.Show();

                }

            }
            if (Globals.user_status == "Admin")
            {
                switch (e.KeyCode)
                {
                    case Keys.A:
                        if (e.Modifiers == Keys.Control) {
                            AddUser adduser = new AddUser();
                            adduser.Show();
                        }
                            
                        break;
                    case Keys.E:
                        if (e.Modifiers == Keys.Control)
                        {
                            if (dataGridView1.SelectedRows.Count > 0)
                            {
                                int index = dataGridView1.SelectedRows[0].Index;
                                int id = 0;
                                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                                if (converted == false)
                                    return;
                                EditUser edituser = new EditUser(id);
                                edituser.Show();
                            }
                        }
                        break;

                    case Keys.Delete:

                        using (BTContext db = new BTContext())
                        {
                            if (dataGridView1.SelectedRows.Count > 0)
                            {
                                int index = dataGridView1.SelectedRows[0].Index;
                                int id = 0;
                                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                                if (converted == false)
                                    return;
                                User user = db.Users.Find(id);
                                db.Users.Remove(user);
                                db.SaveChanges();
                            }
                        }
                        break;
                    default:
                        break;

                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Editbd.Visible = !Editbd.Visible;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string status = Statusbox.Controls.OfType<RadioButton>().Single(rb => rb.Checked).Text;
            dataGridView1.DataSource = GetFilterredUsers(status);
            ChangeSettings();
            TableUpdate();
        }

        private void TableUpdate()
        {
            string Path = @"..\..\..\Settings.txt";
            foreach (string line in File.ReadLines(Path))
            {
                if (line.Contains("1"))
                {
                    dataGridView1.Columns[line.Substring(0, line.IndexOf(" "))].Visible = true;
                }
                else
                {
                    dataGridView1.Columns[line.Substring(0, line.IndexOf(" "))].Visible = false;
                }
            }
        }

        private void CreateSettings()
        {
            string Path = @"..\..\..\Settings.txt";
            if (File.Exists(Path) == false)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(Path, false))
                    {
                        foreach (DataGridViewColumn col in dataGridView1.Columns)
                        {
                            if (col.Visible == true)
                            {
                                sw.WriteLine(col.Name + " = 1");
                            }
                            else
                            {
                                sw.WriteLine(col.Name + " = 0");
                            }
                        }
                    }
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }
        }
        private void ChangeSettings()
        {
            string Path = @"..\..\..\Settings.txt";
            CheckBox[] cb = new CheckBox[10];
            cb[0] = checkBox1;
            cb[1] = checkBox2;
            cb[2] = checkBox3;
            cb[3] = checkBox4;
            cb[4] = checkBox5;
            cb[5] = checkBox6;
            cb[6] = checkBox7;
            cb[7] = checkBox8;
            cb[8] = checkBox11;
            cb[9] = checkBox9;
            int i = 0;
            using (StreamWriter sw = new StreamWriter(Path, false))
            {
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    if (cb[i].Checked == true)
                    {
                        sw.WriteLine(col.Name + " = 1");
                    }
                    else
                    {
                        sw.WriteLine(col.Name + " = 0");
                    }
                    i++;
                }
            }       
        }

        private void FixCheckBoxes()
        {
            string Path = @"..\..\..\Settings.txt";
            CheckBox[] cb = new CheckBox[10];
            cb[0] = checkBox1;
            cb[1] = checkBox2;
            cb[2] = checkBox3;
            cb[3] = checkBox4;
            cb[4] = checkBox5;
            cb[5] = checkBox6;
            cb[6] = checkBox7;
            cb[7] = checkBox8;
            cb[8] = checkBox11;
            cb[9] = checkBox9;
            int i = 0;
            foreach (string line in File.ReadLines(Path))
            {
                if (line.Contains("1"))
                {
                    cb[i].Checked = true;
                }
                else
                {
                    cb[i].Checked = false;
                }
                i++;
            }
        }
        public List<User> GetFilterredUsers(string status)
        {
            BTContext db = new BTContext();
            IQueryable<User> filteredUsers = db.Users;
            if (status != "All")
            {
                filteredUsers = filteredUsers.Where(user => user.Status.ToString() == status);
            }
            return filteredUsers.ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = !groupBox1.Visible;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                dataGridView1.CurrentCell = null;
                if (row.Cells[3].Value.ToString().Contains(textBox1.Text))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }

        private void Users_SizeChanged(object sender, EventArgs e)
        {
            int s = 0;
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                if (col.Visible == true)
                {
                    s++;
                }
            }
            int cs = dataGridView1.Size.Width / s;
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.Width = cs;
            }
        }
    }
}
    
       


