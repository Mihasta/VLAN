using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void Users_Load_1(object sender, EventArgs e)
        {
            BTContext db = new BTContext();
            dataGridView1.DataSource = db.Users.ToList();
        }
    }
}
