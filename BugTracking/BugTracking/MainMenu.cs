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
            var types = new List<string>();
            types.Add("All");
            types.AddRange(db.ErrorTypes.Select(q => q.Name).ToList());
            TypeComboBox.DataSource = types;
            this.dataGridView1.Columns["User"].Visible = false;
            this.dataGridView1.Columns["Type"].Visible = false;

            comboBox2.SelectedIndex = 0;

            comboBox1.Items.Add("Нет");
            foreach (DataGridViewColumn column in dataGridView1.Columns)
                if (column.Visible)
                    comboBox1.Items.Add(column.Name);

            comboBox1.SelectedIndex = 0;
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
                //Console.WriteLine("Успешно добавлено");
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
                //Console.WriteLine("Успешно добавлено");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddError adderror = new AddError();
            adderror.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string priority = PriorityBox.Controls.OfType<RadioButton>().Single(rb => rb.Checked).Text;
            string level = LevelBox.Controls.OfType<RadioButton>().Single(rb => rb.Checked).Text;
            string type = TypeComboBox.SelectedItem.ToString();
            string code = CodeTextBox.Text;
            dataGridView1.DataSource = GetFilterredErrors(priority, level, type, code);
            //dataGridView1.Sort(dataGridView1.Columns[comboBox1.SelectedItem.ToString()], ListSortDirection.Ascending);
        }

        public int GetErrorTypeId(string name)
        {
            BTContext db = new BTContext();
            var type = (from p in db.ErrorTypes where p.Name == name select p).ToArray();
            return type[0].Id;
        }
        public List<Error> GetFilterredErrors(string priority, string level, string type, string code)
        {
            BTContext db = new BTContext();
            IQueryable<Error> filteredErrors = db.Errors;
            if (priority != "All")
            {
                filteredErrors = filteredErrors.Where(error => error.Priority.ToString() == priority);
            }
            if (level != "All")
            {
                filteredErrors = filteredErrors.Where(error => error.Level.ToString() == level);
            }
            if (type != "All")
            {
                int type_id = GetErrorTypeId(type);
                filteredErrors = filteredErrors.Where(error => error.TypeId == type_id);
            }
            if (!string.IsNullOrWhiteSpace(code))
            {
                filteredErrors = filteredErrors.Where(error => error.Code.Contains(code));
            }

            if (comboBox1.SelectedIndex != 0)
            {
                if (comboBox1.SelectedItem.ToString() == "Id")
                    filteredErrors = comboBox2.SelectedIndex == 0 ? filteredErrors.OrderBy(x => x.Id) : filteredErrors.OrderByDescending(x => x.Id);
                if (comboBox1.SelectedItem.ToString() == "Date")
                    filteredErrors = comboBox2.SelectedIndex == 0 ? filteredErrors.OrderBy(x => x.Date) : filteredErrors.OrderByDescending(x => x.Date);
                if (comboBox1.SelectedItem.ToString() == "Priority")
                    filteredErrors = comboBox2.SelectedIndex == 0 ? filteredErrors.OrderByDescending(x => x.Priority) : filteredErrors.OrderBy(x => x.Priority);
                if (comboBox1.SelectedItem.ToString() == "Level")
                    filteredErrors = comboBox2.SelectedIndex == 0 ? filteredErrors.OrderBy(x => x.Level) : filteredErrors.OrderByDescending(x => x.Level);
                if (comboBox1.SelectedItem.ToString() == "Code")
                    filteredErrors = comboBox2.SelectedIndex == 0 ? filteredErrors.OrderBy(x => x.Code) : filteredErrors.OrderByDescending(x => x.Code);
                if (comboBox1.SelectedItem.ToString() == "Description")
                    filteredErrors = comboBox2.SelectedIndex == 0 ? filteredErrors.OrderBy(x => x.Description) : filteredErrors.OrderByDescending(x => x.Description);
                if (comboBox1.SelectedItem.ToString() == "UserId")
                    filteredErrors = comboBox2.SelectedIndex == 0 ? filteredErrors.OrderBy(x => x.UserId) : filteredErrors.OrderByDescending(x => x.UserId);
                if (comboBox1.SelectedItem.ToString() == "TypeId")
                    filteredErrors = comboBox2.SelectedIndex == 0 ? filteredErrors.OrderBy(x => x.TypeId) : filteredErrors.OrderByDescending(x => x.TypeId);
            }

            return filteredErrors.ToList();
        }
        private void Edit_Error(object sender, EventArgs e)
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

        private void Delete_Error(object sender, EventArgs e)
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

        private void button7_Click(object sender, EventArgs e)
        {
            filterBox.Visible = !filterBox.Visible;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About op = new About();
            op.Show();
        }
        private void KeyDown_MainMenu(object sender, KeyEventArgs e)
        {

            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.U)
            {
                Users users = new Users();
                users.Show();
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.E)
            {
                AddError adderror = new AddError();
                adderror.Show();
            }
            if (e.KeyCode == Keys.F1)
            {
                About op = new About();
                op.Show();
            }
            if (e.KeyCode == Keys.Delete)
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
            if (e.KeyCode == Keys.E)
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
        }

        private void создатьОтчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportWindow reportwindow = new ReportWindow();
            reportwindow.Show();
        }
    }
}
