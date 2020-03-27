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
    public partial class EditUser : Form
    {
        private int _id;

        public EditUser(int id)
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(UserStatus));
            _id = id;

            using (var db = new BTContext())
            {
                var user = db.Users.First(x => x.Id == id);
                textBox1.Text = user.Name;
                textBox2.Text = user.Surname;
                textBox3.Text = user.Login;
                textBox4.Text = user.Password;
                textBox6.Text = user.Mail;
                textBox7.Text = user.PhoneNumber;
                comboBox1.SelectedItem = user.Status;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var db = new BTContext())
            {
                var user = db.Users.First(x => x.Id == _id);
                user.Name = textBox1.Text;
                user.Surname = textBox2.Text;
                user.Login = textBox3.Text;
                user.Password = textBox4.Text;
                user.Mail = textBox6.Text;
                user.PhoneNumber = textBox7.Text;
                user.Status = (UserStatus)comboBox1.SelectedItem;
                db.SaveChanges();
            }
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}