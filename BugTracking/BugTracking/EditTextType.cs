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
    public partial class EditTextType : Form
    {
        private int _id;
        public EditTextType(int id)
        {
            InitializeComponent();
            _id = id;
            using (var db = new BTContext())
            {
                var type = db.ErrorTypes.First(x => x.Id == id);
                textBox1.Text = type.Name;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            using (var db = new BTContext())
            {
                var type = db.ErrorTypes.First(x => x.Id == _id);
                type.Name = textBox1.Text;
                db.SaveChanges();
            }
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
