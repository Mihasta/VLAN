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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
            status.DataSource = Enum.GetValues(typeof(UserStatus));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label10.Text == "")
            {
                try
                {
                    using (BTContext db = new BTContext())
                    {
                        User user = new User
                        {
                            Name = name.Text,
                            Surname = surname.Text,
                            Login = login.Text,
                            Password = password.Text,
                            Status = (UserStatus)status.SelectedItem,
                            Mail = mail.Text,
                            PhoneNumber = phonenumber.Text
                        };
                        db.Users.Add(user);
                        db.SaveChanges();
                    }
                    this.Close();
                }
                catch (Exception ex)
                {
                    label8.Text = "Заполните все поля";
                    //MessageBox.Show(ex.Message);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (password2.Text != password.Text)
            {
                label10.Text = "Пароли не совпадают";
            }
            else
            {
                label10.Text = "";
            }
        }
    }
}
