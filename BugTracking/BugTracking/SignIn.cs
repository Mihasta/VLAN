using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BugTracking
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                using (BTContext db = new BTContext())
                {
                    var Login  = (from p in db.Users
                                  where p.Login == textBox1.Text
                                  select p).ToArray();
                    var Pass   = (from p in db.Users
                                  where p.Password == textBox2.Text
                                  select p).ToArray();

                    int id = Login[0].Id;

                    if (textBox1.Text == Login[0].Login)
                    {
                        if (textBox2.Text == Pass[0].Password)
                        {
                            Globals.Like = false;
                            Globals.user_id = Login[0].Id;
                            Globals.user_status = Login[0].Status.ToString();
                            Console.WriteLine(Globals.user_id);
                            MainMenu MM = new MainMenu();
                            MM.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        label2.Text = "Неправильный логин или пароль";
                    }
                }
            }
            catch (SystemException) 
            {
                label2.Text = "Неправильный логин или пароль";
            }
        }
    }

    public static class Globals
    {
        public static bool Like;
        public static int user_id;
        public static string user_status;
    }
}
