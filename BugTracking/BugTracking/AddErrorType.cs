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
    public partial class AddErrorType : Form
    {
        public AddErrorType()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            BTContext db = new BTContext();
            dbTypeError.DataSource = db.ErrorTypes.ToList();
        }

        private void AddErrorType_Load(object sender, EventArgs e)
        {
            BTContext db = new BTContext();
            dbTypeError.DataSource = db.ErrorTypes.ToList();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TextType tt = new TextType();
            tt.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dbTypeError.SelectedRows.Count > 0)
            {
                int index = dbTypeError.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dbTypeError[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;
                EditTextType ett = new EditTextType(id);
                ett.Show();
            }
        }
    }
}
