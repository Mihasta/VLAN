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
    public partial class EditSolution : Form
    {
        private int _id;
        public EditSolution(int id)
        {
            InitializeComponent();
            _id = id;
            using (var db = new BTContext())
            {
                var solution = db.Solutions.First(x => x.Id == id);
                textBox1.Text = solution.Description;
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var db = new BTContext())
            {
                var solution = db.Solutions.First(x => x.Id == _id);
                solution.Description = textBox1.Text;
                db.SaveChanges();
            }
            this.Close();
        }

        private void EditSolution_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
