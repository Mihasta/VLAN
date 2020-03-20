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
    public partial class ErrorWindow : Form
    {
        private static int _id;
        public ErrorWindow()
        {
            InitializeComponent();
        }

        public void RefreshDataGridView(int id)
        {
            using (BTContext db = new BTContext())
            {
                var solutions = (from p in db.Solutions
                                 where p.ErrorId == id
                                 select p);
                dataGridView1.DataSource = solutions.ToList();
            }
        }

        public ErrorWindow(int id)
        {
            InitializeComponent();
            _id = id;
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
    }
}