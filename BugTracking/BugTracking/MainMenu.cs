using System;
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
            if (Globals.user_status == "User")
            {
                User.Visible = false;
                ошибкиToolStripMenuItem.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
            }
            else if (Globals.user_status == "Moderator")
            {
                ошибкиToolStripMenuItem.Visible = false;
                button6.Visible = false;
            }
            BTContext db = new BTContext();
            dataGridView1.DataSource = db.Errors.ToList();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (BTContext db = new BTContext())
            {
                Error error = new Error
                {
                    Date = DateTime.Now,
                    Priority = ErrorPriority.Low,
                    Level = ErrorLevel.Trivial,
                    Code = "IDE1006",
                    Description = "oshibka oshibka",
                    UserId = 2,
                    TypeId = 1
                };
                db.Errors.Add(error);
                db.SaveChanges();
                Console.WriteLine("Успешно добавлено");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (BTContext db = new BTContext())
            {
                ErrorType type = new ErrorType
                {
                    Name = "Logic"
                };
                db.ErrorTypes.Add(type);
                db.SaveChanges();
                Console.WriteLine("Успешно добавлено");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddError adderror = new AddError();
            adderror.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BTContext db = new BTContext();
            dataGridView1.DataSource = db.Errors.ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out int id);
                if (converted == false)
                    return;
                EditError editerror = new EditError(id);
                editerror.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (BTContext db = new BTContext())
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int index = dataGridView1.SelectedRows[0].Index;
                    bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out int id);
                    if (converted == false)
                        return;
                    Error error = db.Errors.Find(id);
                    db.Errors.Remove(error);
                    db.SaveChanges();

                }
            }
        }

        private void типОшибкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddErrorType AET = new AddErrorType();
            AET.Show();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out int id);
                if (converted == false)
                    return;
                ErrorWindow errorwindow = new ErrorWindow(id);
                errorwindow.Show();
            }
        }
    }
}
