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
    public partial class TextType : Form
    {
        public TextType()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            using (BTContext db = new BTContext())
            {
                ErrorType type = new ErrorType
                {
                    Name = textBox1.Text,
                };
                db.ErrorTypes.Add(type);
                db.SaveChanges();
            }
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
