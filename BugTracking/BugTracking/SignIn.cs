﻿using System;
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
                    var Login = (from p in db.Users
                                 where p.Login == textBox1.Text
                                 select p).ToArray();
                    var Pass = (from p in db.Users
                                where p.Password == textBox2.Text
                                select p).ToArray();

                    if (textBox1.Text == Login[0].Login)
                    {
                        if (textBox2.Text == Pass[0].Password)
                        {
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
            catch (SystemException a) 
            {
                label2.Text = "Неправильный логин или пароль";
            }
        }
    }
}
