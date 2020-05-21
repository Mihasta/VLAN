using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
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
            CheckBox[] cb = new CheckBox[11];
            cb[0] = checkBox1;
            cb[1] = checkBox2;
            cb[2] = checkBox3;
            cb[3] = checkBox4;
            cb[4] = checkBox5;
            cb[5] = checkBox6;
            cb[6] = checkBox7;
            cb[7] = checkBox8;
            cb[8] = checkBox9;
            cb[9] = checkBox10;
            cb[10] = checkBox11;
            BTContext db = new BTContext();
            dataGridView1.DataSource = db.Users.ToList();

            if (Globals.user_status == "Moderator")
            {
               
                button5.Visible = false;
                button4.Visible = false;
                this.dataGridView1.Columns["Password"].Visible = false;
            }
            else if (Globals.user_status == "Admin")
            {
                dataGridView1.DataSource = db.Users.ToList();
            }
            this.dataGridView1.Columns["Errors"].Visible = false;
            this.dataGridView1.Columns["Solutions"].Visible = false;
            this.dataGridView1.Columns["Like"].Visible = false;
            this.dataGridView1.Columns["Errors"].Visible = false;
            this.dataGridView1.Columns["Solutions"].Visible = false;
            this.dataGridView1.Columns["Like"].Visible = false;

            int i=0;

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {   
                if (col.Visible == true)
                {
                    cb[i].Checked = true;
                }
                else
                {
                    cb[i].Checked = false;
                }
                i++;
            }
            ToolTip tt = new ToolTip();

            tt.SetToolTip(button3, "Добавить пользователя");
            tt.SetToolTip(button4, "Редактировать пользователя");
            tt.SetToolTip(button5, "Удалить пользователя");
            tt.SetToolTip(button7, "Обновить");
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
                switch(e.KeyCode)
                {
                    case Keys.A:
                        AddUser adduser = new AddUser();
                        adduser.Show();
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
            CheckBox[] cb = new CheckBox[11];
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
            cb[10] = checkBox10;
            BTContext db = new BTContext();
            dataGridView1.DataSource = db.Users.ToList();
            int i = 0;
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                if (cb[i].Checked == true)
                {
                    col.Visible = true;
                }
                else
                {
                    col.Visible = false;
                }
                i++;
            }

        }
    }
}
    
       


