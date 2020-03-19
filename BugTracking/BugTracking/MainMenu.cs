﻿using System;
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
    public partial class MainMenu : Form
    {
        
        public MainMenu()
        {
            InitializeComponent();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Users users = new Users();
            users.Show();

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            BTContext db = new BTContext();
            dataGridView1.DataSource = db.Errors.ToList();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BTContext db = new BTContext();
            dataGridView1.DataSource = db.Errors.ToList();
        }
    }
}
