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
    public partial class EditError : Form
    {
        private int _id;
        public EditError(int id)
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(ErrorPriority));
            comboBox2.DataSource = Enum.GetValues(typeof(ErrorLevel));
            using (BTContext db = new BTContext())
            {
                var Types = (from p in db.ErrorTypes select p.Name).ToArray();
                comboBox3.DataSource = Types;
            }
            _id = id;

            using (var db = new BTContext())
            {
                var error = db.Errors.First(x => x.Id == id);
                comboBox1.SelectedItem = error.Priority;
                comboBox2.SelectedItem = error.Level;
                textBox1.Text = error.Code;
                textBox2.Text = error.Description;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new BTContext())
            {
                var TypeId = (from p in db.ErrorTypes
                              where p.Name == comboBox3.Text
                              select p).ToArray();
                var error = db.Errors.First(x => x.Id == _id);
                error.Priority = (ErrorPriority)comboBox1.SelectedItem;
                error.Level = (ErrorLevel)comboBox2.SelectedItem;
                error.Code = textBox1.Text;
                error.Description = textBox2.Text;
                error.TypeId = TypeId[0].Id;
                db.SaveChanges();
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditError_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}