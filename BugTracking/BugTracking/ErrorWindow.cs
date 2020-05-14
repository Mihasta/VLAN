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
            statusButton.Text = error[0].ErrorStatus.ToString();

            switch (statusButton.Text)
            {
                case "Open":
                    button1.Visible = true;
                    button3.Visible = true;
                    button4.Visible = true;
                    button5.Visible = true;
                    label2.Text = String.Empty;
                    break;
                case "Closed":
                    button1.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    button5.Visible = false;
                    label2.Text = "Статус: Закрыт";
                    break;
                default:
                    break;
            }
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
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;
                Like lke = new Like();
                lke.lke(_id, id);
            }
        }

        private void ErrorWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if(Globals.user_status == "Admin")
            {
                switch (e.KeyCode)
                {
                    case Keys.A:
                        if (e.Modifiers == Keys.Control)
                        {
                            if (tabControl1.SelectedTab.Name == "tabPage2" && statusButton.Text == "Open")
                            {
                                AddSolution addsolution = new AddSolution(_id);
                                addsolution.Show();
                            }
                        }
                        break;
                    case Keys.E:
                        if (e.Modifiers == Keys.Control)
                        {
                            if (tabControl1.SelectedTab.Name == "tabPage2" && statusButton.Text == "Open")
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
                        }
                        break;
                    case Keys.Delete:
                        if (tabControl1.SelectedTab.Name == "tabPage2" && statusButton.Text == "Open")
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
                            }
                        }
                        break;
                    case Keys.F5:
                        if (tabControl1.SelectedTab.Name == "tabPage2" && statusButton.Text == "Open")
                        {
                            RefreshDataGridView(_id);
                        }
                        break;
                    default:
                        break;

                }
            }
            if (Globals.user_status == "Moderator")
            {
                switch (e.KeyCode)
                {
                    case Keys.A:
                        if (e.Modifiers == Keys.Control)
                        {
                            if (tabControl1.SelectedTab.Name == "tabPage2" && statusButton.Text == "Open")
                            {
                                AddSolution addsolution = new AddSolution(_id);
                                addsolution.Show();
                            }
                        }
                        break;
                    case Keys.E:
                        if (e.Modifiers == Keys.Control)
                        {
                            if (tabControl1.SelectedTab.Name == "tabPage2" && statusButton.Text == "Open")
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
                        }
                        break;
                    case Keys.Delete:
                        if (tabControl1.SelectedTab.Name == "tabPage2" && statusButton.Text == "Open")
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
                            }
                        }
                        break;
                    case Keys.F5:
                        if (tabControl1.SelectedTab.Name == "tabPage2" && statusButton.Text == "Open")
                        {
                            RefreshDataGridView(_id);
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
                            if (tabControl1.SelectedTab.Name == "tabPage2" && statusButton.Text == "Open")
                            {
                                AddSolution addsolution = new AddSolution(_id);
                                addsolution.Show();
                            }
                        }
                        break;
                    case Keys.F5:
                        if (tabControl1.SelectedTab.Name == "tabPage2" && statusButton.Text == "Open")
                        {
                            RefreshDataGridView(_id);
                        }
                        break;
                    default:
                        break;

                }

            }
        }
        private void statusButton_Click(object sender, EventArgs e)
        {
            BTContext db = new BTContext();
            var error = (from p in db.Errors where p.Id == _id select p).FirstOrDefault();
            db.SaveChanges();
            switch (statusButton.Text)
            {
                case "Open":
                    error.ErrorStatus = ErrorStatus.Closed;
                    label2.Text = "Статус: Закрыт";
                    statusButton.Text = "Closed";
                    break;
                case "Closed":
                    error.ErrorStatus = ErrorStatus.Open;
                    label2.Text = String.Empty;
                    statusButton.Text = "Open";
                    break;
                default:
                    break;
            }
            db.SaveChanges();
            button1.Visible = !button1.Visible;
            button3.Visible = !button1.Visible;
            button4.Visible = !button1.Visible;
            button5.Visible = !button1.Visible;
        }
    }
}