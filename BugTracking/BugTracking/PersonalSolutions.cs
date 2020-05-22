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
    public partial class PersonalSolutions : Form
    {
        public PersonalSolutions()
        {
            InitializeComponent();
        }

        private void PersonalSolutions_Load(object sender, EventArgs e)
        {
            BTContext db = new BTContext();
            dataGridView1.DataSource = db.Solutions.Where(s => s.UserId == Globals.user_id).ToList();
        }

        private void RefreshDataGridView()
        {
            BTContext db = new BTContext();
            dataGridView1.DataSource = db.Solutions.Where(s => s.UserId == Globals.user_id).ToList();
        }

        void solutioncontrol_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshDataGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                BTContext db = new BTContext();
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;
                Solution solution = db.Solutions.Find(id);
                db.Solutions.Remove(solution);
                db.SaveChanges();
                RefreshDataGridView();
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
                editsolution.FormClosed += new FormClosedEventHandler(solutioncontrol_FormClosed);
            }
        }

        private void PersonalSolutions_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        BTContext db = new BTContext();
                        int index = dataGridView1.SelectedRows[0].Index;
                        int id = 0;
                        bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                        if (converted == false)
                            return;
                        Solution solution = db.Solutions.Find(id);
                        db.Solutions.Remove(solution);
                        db.SaveChanges();
                        RefreshDataGridView();
                    }
                    break;
                case Keys.E:
                    if (e.Modifiers == Keys.Control)
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
                            editsolution.FormClosed += new FormClosedEventHandler(solutioncontrol_FormClosed);
                        }
                    }
                    break;
            }
        }
    }
}
