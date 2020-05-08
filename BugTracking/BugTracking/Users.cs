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
        public DataGridView dgv { get { return dataGridView1; } }
        public Users()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BTContext db = new BTContext();
            dataGridView1.DataSource = db.Users.ToList();
            if (checkBox1.Checked == true)
            {
                this.dataGridView1.Columns["Id"].Visible = true;
            }
            else
            {
                this.dataGridView1.Columns["Id"].Visible = false;
            }
            if (checkBox2.Checked == true)
            {
                this.dataGridView1.Columns["Name"].Visible = true;
            }
            else
            {
                this.dataGridView1.Columns["Name"].Visible = false;
            }
            if (checkBox3.Checked == true)
            {
                this.dataGridView1.Columns["Surname"].Visible = true;
            }
            else
            {
                this.dataGridView1.Columns["Surname"].Visible = false;
            }
            if (checkBox4.Checked == true)
            {
                this.dataGridView1.Columns["Login"].Visible = true;
            }
            else
            {
                this.dataGridView1.Columns["Login"].Visible = false;
            }
            if (checkBox5.Checked == true)
            {
                this.dataGridView1.Columns["Password"].Visible = true;
            }
            else
            {
                this.dataGridView1.Columns["Password"].Visible = false;
            }
            if (checkBox6.Checked == true)
            {
                this.dataGridView1.Columns["Status"].Visible = true;
            }
            else
            {
                this.dataGridView1.Columns["Status"].Visible = false;
            }
            if (checkBox7.Checked == true)
            {
                this.dataGridView1.Columns["Mail"].Visible = true;
            }
            else
            {
                this.dataGridView1.Columns["Mail"].Visible = false;
            }
            if (checkBox8.Checked == true)
            {
                this.dataGridView1.Columns["PhoneNumber"].Visible = true;
            }
            else
            {
                this.dataGridView1.Columns["PhoneNumber"].Visible = false;
            }
            if (checkBox11.Checked == true)
            {
                this.dataGridView1.Columns["Errors"].Visible = true;
            }
            else
            {
                this.dataGridView1.Columns["Errors"].Visible = false;
            }
            if (checkBox9.Checked == true)
            {
                this.dataGridView1.Columns["Solutions"].Visible = true;
            }
            else
            {
                this.dataGridView1.Columns["Solutions"].Visible = false;
            }
            if (checkBox10.Checked == true)
            {
                this.dataGridView1.Columns["Like"].Visible = true;
            }
            else
            {
                this.dataGridView1.Columns["Like"].Visible = false;
            }
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
            if (this.dataGridView1.Columns["Id"].Visible == true)
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }
            if (this.dataGridView1.Columns["Name"].Visible == true)
            {
                checkBox2.Checked = true;
            }
            else
            {
                checkBox2.Checked = false;
            }
            if (this.dataGridView1.Columns["Surname"].Visible == true)
            {
                checkBox3.Checked = true;
            }
            else
            {
                checkBox3.Checked = false;
            }
            if (this.dataGridView1.Columns["Login"].Visible == true)
            {
                checkBox4.Checked = true;
            }
            else
            {
                checkBox4.Checked = false;
            }
            if (this.dataGridView1.Columns["Password"].Visible == true)
            {
                checkBox5.Checked = true;
            }
            else
            {
                checkBox5.Checked = false;
            }
            if (this.dataGridView1.Columns["Status"].Visible == true)
            {
                checkBox6.Checked = true;
            }
            else
            {
                checkBox6.Checked = false;
            }
            if (this.dataGridView1.Columns["Mail"].Visible == true)
            {
                checkBox7.Checked = true;
            }
            else
            {
                checkBox7.Checked = false;
            }
            if (this.dataGridView1.Columns["Phonenumber"].Visible == true)
            {
                checkBox8.Checked = true;
            }
            else
            {
                checkBox8.Checked = false;
            }
            if (this.dataGridView1.Columns["Errors"].Visible == true)
            {
                checkBox9.Checked = true;
            }
            else
            {
                checkBox9.Checked = false;
            }
            if (this.dataGridView1.Columns["Solutions"].Visible == true)
            {
                checkBox10.Checked = true;
            }
            else
            {
                checkBox10.Checked = false;
            }
            if (this.dataGridView1.Columns["Like"].Visible == true)
            {
                checkBox11.Checked = true;
            }
            else
            {
                checkBox11.Checked = false;
            }
   
            this.dataGridView1.Columns["Errors"].Visible = false;
            this.dataGridView1.Columns["Solutions"].Visible = false;
            this.dataGridView1.Columns["Like"].Visible = false;
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
                if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
                {
                    AddUser adduser = new AddUser();
                    adduser.Show();

                }
                if (e.Modifiers == Keys.Control && e.KeyCode == Keys.E)
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
                if (e.KeyCode == Keys.F5)
                {
                    BTContext db = new BTContext();
                    dataGridView1.DataSource = db.Users.ToList();

                }
                if (e.KeyCode == Keys.Delete)
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
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Editbd.Visible = !Editbd.Visible;
        }
    }
}
    
       


