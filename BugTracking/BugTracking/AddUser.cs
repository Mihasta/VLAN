﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            label12.Text = "";
            phonenumber.MaxLength = 12;
            if (PasswordCheck.Text == "" && emailCheck.Text == "" && tlfcheck.Text == "" && label12.Text== "")
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

                        var Log = (from p in db.Users
                                   where p.Login == login.Text
                                   select p).FirstOrDefault();

                        if (Log != null)
                        {
                            label12.Text = "Такой логин уже существует!";
                        }
                        else
                        {
                            label12.Text = "";
                            db.Users.Add(user);
                            db.SaveChanges();
                            this.Close();
                        }
                    }
                }
                catch //(System.Data.Entity.Validation.DbEntityValidationException dbEx)
                {
                    /*Exception raise = dbEx;
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            string message = string.Format("{0}:{1}",
                                validationErrors.Entry.Entity.ToString(),
                                validationError.ErrorMessage);
                            // raise a new exception nesting
                            // the current instance as InnerException
                            raise = new InvalidOperationException(message, raise);
                        }
                    }
                    throw raise;*/
                    label8.Text = "Заполните все поля";
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (password2.Text != password.Text)
            {
                PasswordCheck.Text = "Пароли не совпадают";
            }
            else
            {
                PasswordCheck.Text = "";
            }
        }

        private void mail_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^([a-z0-9]+([-_][a-z0-9]+)*)@(([a-z0-9]+(-[a-z0-9]+)*).){2,}[a-z]+$";
            string email = mail.Text;
            if (Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)))
            {
                emailCheck.Text = "";
            }
            else
            {
                emailCheck.Text = "Неправильная почта";
            }
        }

        private void AddUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
