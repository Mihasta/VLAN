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
    public partial class SolutionWindow : Form
    {
        private int _id;
        public SolutionWindow()
        {
            InitializeComponent();
        }

        public SolutionWindow(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private void SolutionWindow_Load(object sender, EventArgs e)
        {
            BTContext db = new BTContext();
            var sol = (from p in db.Solutions where p.Id == _id select p).FirstOrDefault();
            textBox1.Text = sol.Description;
        }
    }
}
