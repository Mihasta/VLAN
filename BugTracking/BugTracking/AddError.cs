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
    public partial class AddError : Form
    {
        public AddError()
        {
            InitializeComponent();
            priority.DataSource = Enum.GetValues(typeof(ErrorPriority));
            level.DataSource = Enum.GetValues(typeof(ErrorLevel));

            using (BTContext db = new BTContext())
            {
                var Types = (from p in db.ErrorTypes select p.Name).ToArray();
                type.DataSource = Types;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (BTContext db = new BTContext())
            {
                var TypeId = (from p in db.ErrorTypes
                              where p.Name == type.Text
                              select p).ToArray();

                Error error = new Error
                {
                    Date = DateTime.Now,
                    Priority = (ErrorPriority)priority.SelectedItem,
                    Level = (ErrorLevel)level.SelectedItem,
                    Code = code.Text,
                    Description = description.Text,
                    UserId = Globals.user_id,
                    TypeId = TypeId[0].Id
                };
                db.Errors.Add(error);
                db.SaveChanges();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
