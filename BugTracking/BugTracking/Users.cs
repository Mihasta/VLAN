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
        //BTContext db;
        public Users()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BTContext db = new BTContext();
            dataGridView1.DataSource = db.Users.ToList();
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
            if (Globals.user_status == "Moderator")
            {
                button1.Visible = false;
                button5.Visible = false;
                button4.Visible = false;
            }
            else if (Globals.user_status == "Admin")
            {
                BTContext db = new BTContext();
                dataGridView1.DataSource = db.Users.ToList();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BTContext db = new BTContext();
            dataGridView1.DataSource = db.Users.ToList();
        }

        private void Users_KeyDown(object sender, KeyEventArgs e)
        {
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

            if (e.KeyCode == Keys.E && e.Modifiers == Keys.Alt)
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

        }
    }
}

