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

            ToolTip tt = new ToolTip();
            tt.SetToolTip(EditTypeError, "Редактировать тип ошибки");
            tt.SetToolTip(Add1TypeError, "Добавить тип ошибки");
            tt.SetToolTip(DelTypeError, "Удалить тип ошибки");
            tt.SetToolTip(Refresh, "Обновить список");
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

        private void dbTypeError_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Delete_ErrorType(object sender, EventArgs e)
        {
            using (BTContext db = new BTContext())
            {
                if (dbTypeError.SelectedRows.Count > 0)
                {
                    int index = dbTypeError.SelectedRows[0].Index;
                    int id = 0;
                    bool converted = Int32.TryParse(dbTypeError[0, index].Value.ToString(), out id);
                    if (converted == false)
                        return;
                    ErrorType errorType = db.ErrorTypes.Find(id);
                    db.ErrorTypes.Remove(errorType);
                    db.SaveChanges();
                }
            }
        }

        private void AddErrorType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.E)
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
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
            {
                BTContext db = new BTContext();
                dbTypeError.DataSource = db.ErrorTypes.ToList();
            }

                if (e.KeyCode == Keys.Delete)
            {
                using (BTContext db = new BTContext())
                {
                    if (dbTypeError.SelectedRows.Count > 0)
                    {
                        int index = dbTypeError.SelectedRows[0].Index;
                        int id = 0;
                        bool converted = Int32.TryParse(dbTypeError[0, index].Value.ToString(), out id);
                        if (converted == false)
                            return;
                        ErrorType errorType = db.ErrorTypes.Find(id);
                        db.ErrorTypes.Remove(errorType);
                        db.SaveChanges();
                    }

                }
            }
        }
    }
}
