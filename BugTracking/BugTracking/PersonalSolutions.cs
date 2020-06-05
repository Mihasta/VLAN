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
            dataGridView1.Columns[0].Width = Convert.ToInt32(dataGridView1.Columns[0].Width * 0.3);
            dataGridView1.Columns[1].HeaderText = "Описание";
            dataGridView1.Columns[2].HeaderText = "Id ошибки";
            dataGridView1.Columns[3].HeaderText = "Ошибка";
            dataGridView1.Columns[4].HeaderText = "Id пользователя";
            dataGridView1.Columns[5].HeaderText = "Пользователь";
            dataGridView1.Columns[6].HeaderText = "Дата и Время";
            
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
                case Keys.Escape:
                    {
                        this.Close();
                    }
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                dataGridView1.CurrentCell = null;
                if (row.Cells[2].Value.ToString().Contains(textBox1.Text))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }
    }
}
