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
                    Name = "CompilationError"
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
    }
}
