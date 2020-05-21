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
        private bool personal_solutions = false;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Users users = new Users();
            users.ShowDialog();
        }

        private void RefreshDataGridView()
        {
            BTContext db = new BTContext();
            string priority = PriorityBox.Controls.OfType<RadioButton>().Single(rb => rb.Checked).Text;
            string level = LevelBox.Controls.OfType<RadioButton>().Single(rb => rb.Checked).Text;
            string type = TypeComboBox.SelectedItem.ToString();
            string code = CodeTextBox.Text;
            string status = ErrorStatusBox.Controls.OfType<RadioButton>().Single(rb => rb.Checked).Text;
            dataGridView1.DataSource = GetFilterredErrors(priority, level, type, code, status);

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int index = row.Index;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out int id);
                if (converted == false)
                    return;
                Error error = db.Errors.Find(id);
                if (error.ErrorStatus == ErrorStatus.Open)
                {
                    row.DefaultCellStyle.BackColor = Color.Pink;
                }
                else if (error.ErrorStatus == ErrorStatus.Closed)
                {
                    row.DefaultCellStyle.BackColor = Color.PaleGreen;
                }
            }
            dataGridView1.ClearSelection();
            this.dataGridView1.Columns["User"].Visible = false;
            this.dataGridView1.Columns["Type"].Visible = false;
        }

        private void FixFilter()
        {
            BTContext db = new BTContext();

            var types = new List<string>();
            types.Add("All");
            types.AddRange(db.ErrorTypes.Select(q => q.Name).ToList());
            TypeComboBox.DataSource = types;

            SortBox1.SelectedIndex = 0;
            SortBox2.SelectedIndex = 0;
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            if (Globals.user_status == "User")
            {
                User.Visible = false;
                ошибкиToolStripMenuItem.Visible = false;
                отчетToolStripMenuItem.Visible = false;
                button5.Visible = false;
                button6.Visible = false;

            }
            else if (Globals.user_status == "Moderator")
            {
                ошибкиToolStripMenuItem.Visible = false;
                button6.Visible = false;

            }

            FixFilter();

            RefreshDataGridView();

            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();

            ToolTip tt = new ToolTip();
            tt.SetToolTip(User, "Пользователи");
            tt.SetToolTip(button3, "Добавить ошибку");
            tt.SetToolTip(button5, "Редактировать ошибку");
            tt.SetToolTip(button6, "Удалить ошибку");
            tt.SetToolTip(button4, "Обновить");
            dataGridView1.ClearSelection();
        }

        void errorcontrol_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshDataGridView();
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

        private void AddError(object sender, EventArgs e)
        {
            AddError adderror = new AddError();
            adderror.ShowDialog();
            adderror.FormClosed += new FormClosedEventHandler(errorcontrol_FormClosed);
        }

        private void RefreshButton(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        public int GetErrorTypeId(string name)
        {
            BTContext db = new BTContext();
            var type = (from p in db.ErrorTypes where p.Name == name select p).ToArray();
            return type[0].Id;
        }
        public List<Error> GetFilterredErrors(string priority, string level, string type, string code, string status)
        {
            BTContext db = new BTContext();
            IQueryable<Error> filteredErrors = db.Errors;
            if (PersonalErrorsCheckBox.Checked == true)
            {
                filteredErrors = filteredErrors.Where(error => error.UserId == Globals.user_id);
            }
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
            if (status != "All")
            {
                filteredErrors = filteredErrors.Where(error => error.ErrorStatus.ToString() == status);
            }
            if (SortBox1.SelectedIndex != 0)
            {
                if (SortBox1.SelectedItem.ToString() == "Id")
                    filteredErrors = SortBox2.SelectedIndex == 0 ? filteredErrors.OrderBy(x => x.Id) : filteredErrors.OrderByDescending(x => x.Id);
                if (SortBox1.SelectedItem.ToString() == "Date")
                    filteredErrors = SortBox2.SelectedIndex == 0 ? filteredErrors.OrderBy(x => x.Date) : filteredErrors.OrderByDescending(x => x.Date);
                if (SortBox1.SelectedItem.ToString() == "Priority")
                    filteredErrors = SortBox2.SelectedIndex == 0 ? filteredErrors.OrderByDescending(x => x.Priority) : filteredErrors.OrderBy(x => x.Priority);
                if (SortBox1.SelectedItem.ToString() == "Level")
                    filteredErrors = SortBox2.SelectedIndex == 0 ? filteredErrors.OrderBy(x => x.Level) : filteredErrors.OrderByDescending(x => x.Level);
                if (SortBox1.SelectedItem.ToString() == "Code")
                    filteredErrors = SortBox2.SelectedIndex == 0 ? filteredErrors.OrderBy(x => x.Code) : filteredErrors.OrderByDescending(x => x.Code);
                if (SortBox1.SelectedItem.ToString() == "Description")
                    filteredErrors = SortBox2.SelectedIndex == 0 ? filteredErrors.OrderBy(x => x.Description) : filteredErrors.OrderByDescending(x => x.Description);
                if (SortBox1.SelectedItem.ToString() == "UserId")
                    filteredErrors = SortBox2.SelectedIndex == 0 ? filteredErrors.OrderBy(x => x.UserId) : filteredErrors.OrderByDescending(x => x.UserId);
                if (SortBox1.SelectedItem.ToString() == "TypeId")
                    filteredErrors = SortBox2.SelectedIndex == 0 ? filteredErrors.OrderBy(x => x.TypeId) : filteredErrors.OrderByDescending(x => x.TypeId);
            }
            return filteredErrors.ToList();
        }
        private void CodeTextBox_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                dataGridView1.CurrentCell = null;
                if (row.Cells[5].Value.ToString().Contains(CodeTextBox.Text))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
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
                editerror.ShowDialog();
                editerror.FormClosed += new FormClosedEventHandler(errorcontrol_FormClosed);
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
                    RefreshDataGridView();
                }
            }
        }

        private void типОшибкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddErrorType AET = new AddErrorType();
            AET.ShowDialog();
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
                errorwindow.ShowDialog();
                errorwindow.FormClosed += new FormClosedEventHandler(errorcontrol_FormClosed);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            filterBox.Visible = !filterBox.Visible;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About op = new About();
            op.ShowDialog();
        }
        private void KeyDown_MainMenu(object sender, KeyEventArgs e)
        {
            if (Globals.user_status == "Moderator" || Globals.user_status == "Admin")
            {
                switch (e.KeyCode)
                {
                    case Keys.U:
                        if (e.Modifiers == Keys.Control)
                        {
                            Users users = new Users();
                            users.ShowDialog();
                        }
                        break;
                    case Keys.A:
                        if (e.Modifiers == Keys.Control)
                        {
                            AddError adderror = new AddError();
                            adderror.ShowDialog();
                        }
                        break;
                    case Keys.R:
                        if (e.Modifiers == Keys.Control)
                        {
                            ReportWindow reportwindow = new ReportWindow();
                            reportwindow.ShowDialog();
                        }
                        break;
                    case Keys.T:
                        AddErrorType AET = new AddErrorType();
                        AET.ShowDialog();
                        break;
                    case Keys.F:
                        filterBox.Visible = !filterBox.Visible;
                        break;
                    case Keys.F5:
                        RefreshDataGridView();
                        break;
                    case Keys.F12:
                        About op = new About();
                        op.ShowDialog();
                        break;
                    case Keys.F1:
                        help hel = new help();
                        hel.ShowDialog();
                        break;
                    case Keys.E:
                        if (e.Modifiers == Keys.Control)
                        {
                            if (dataGridView1.SelectedRows.Count > 0)
                            {
                                int index = dataGridView1.SelectedRows[0].Index;
                                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out int id);
                                if (converted == false)
                                    return;
                                EditError editerror = new EditError(id);
                                editerror.ShowDialog();
                            }
                        }
                        break;
                    case Keys.Delete:
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
                        break;
                    default:
                        break;
                }

            }
            if (Globals.user_status == "User")
            {
                switch (e.KeyCode)
                {
                    case Keys.A:

                        if (e.Modifiers == Keys.Control)
                        {

                            AddError adderror = new AddError();
                            adderror.ShowDialog();
                        }
                        break;

                    case Keys.F5:

                        string priority = PriorityBox.Controls.OfType<RadioButton>().Single(rb => rb.Checked).Text;
                        string level = LevelBox.Controls.OfType<RadioButton>().Single(rb => rb.Checked).Text;
                        string type = TypeComboBox.SelectedItem.ToString();
                        string code = CodeTextBox.Text;
                        string status = ErrorStatusBox.Controls.OfType<RadioButton>().Single(rb => rb.Checked).Text;
                        dataGridView1.DataSource = GetFilterredErrors(priority, level, type, code, status);
                        break;
                    case Keys.F1:
                        About op = new About();
                        op.ShowDialog();
                        break;
                    default:
                        break;
                

            }
        }
    }

        private void создатьОтчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportWindow reportwindow = new ReportWindow();
            reportwindow.ShowDialog();
        }

        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void выходИзАккаунтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignIn sg = new SignIn();
            sg.Show();
            this.Close();
        }

        private void инфОКомпеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            information inf = new information();
            inf.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("dd MMMM yyyy | HH:mm:ss");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            BTContext db = new BTContext();
            switch (personal_solutions)
            {
                case true:
                    button9.BackColor = SystemColors.Control;
                    dataGridView1.DataSource = db.Errors.ToList();
                    break;
                case false:
                    button9.BackColor = Color.Gray;
                    dataGridView1.DataSource = db.Solutions.Where(s => s.UserId == Globals.user_id).ToList();
                    break;
                default:
                    break;
            }
            personal_solutions = !personal_solutions;
        }

        private void черныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void белыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
