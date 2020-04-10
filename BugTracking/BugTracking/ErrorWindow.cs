﻿using System;
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
    public partial class ErrorWindow : Form
    {
        private static int _id;
        public void RefreshDataGridView(int id)
        {
            BTContext db = new BTContext();
            dataGridView1.DataSource = db.Solutions.Where(s => s.ErrorId == id).ToList();
        }

        public void FillInfo(int id)
        {
            BTContext db = new BTContext();
            var error = (from p in db.Errors where p.Id == id select p).ToArray();
            Code.Text += ' ' + error[0].Code.ToString();
            Type.Text += ' ' + GetErrorType(error[0].TypeId);
            Priority.Text += ' ' + error[0].Priority.ToString();
            Level.Text += ' ' + error[0].Level.ToString();
            Date.Text += ' ';
            Date.Text += error[0].Date;
            UserString.Text += ' ' + GetUserString(error[0].UserId);
            DescriptionTextBox.Text += error[0].Description.ToString();
        }

        public string GetErrorType(int id)
        {
            BTContext db = new BTContext();
            var type = (from p in db.ErrorTypes where p.Id == id select p).ToArray();
            return type[0].Name;
        }

        public string GetUserString(int id)
        {
            string userstring = "";
            BTContext db = new BTContext();
            var user = (from p in db.Users where p.Id == id select p).ToArray();
            userstring += user[0].Name + ' ' + user[0].Surname + ", ID = " + user[0].Id;
            return userstring;
        }

        public ErrorWindow()
        {
            InitializeComponent();
        }

        public ErrorWindow(int id)
        {
            InitializeComponent();
            _id = id;
            FillInfo(_id);
            RefreshDataGridView(_id);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RefreshDataGridView(_id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddSolution addsolution = new AddSolution(_id);
            addsolution.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                EditSolution editsolution = new EditSolution(id);
                editsolution.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
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
                    Solution solution = db.Solutions.Find(id);
                    db.Solutions.Remove(solution);
                    db.SaveChanges();

                }
            }
        }
        private void ErrorWindow_Load(object sender, EventArgs e)
        {
            if (Globals.user_status == "User")
            {
                button3.Visible = false;
                button4.Visible = false;
            }
            else if (Globals.user_status == "Moderator") 
            {
                button4.Visible = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;
                if (Globals.Like != true) 
                {
                    using (BTContext db = new BTContext())
                    {
                        //Console.WriteLine("зашел");
                        /*var Likes = (from p in db.Solutions
                                     where p.Id == id
                                     select p.Likes).ToArray();*/
                        var solution = db.Solutions.First(x => x.Id == id);
                        i = solution.Likes;
                        i++;
                        //Console.WriteLine(i);
                        solution.Likes = i;
                        db.SaveChanges();
                    }
                }
                Globals.Like = true;
            }
        }

        private void ErrorWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                RefreshDataGridView(_id);
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
                        Solution solution = db.Solutions.Find(id);
                        db.Solutions.Remove(solution);
                        db.SaveChanges();

                    }
                }
            }
        }
    }
}