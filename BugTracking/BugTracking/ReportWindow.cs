using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace BugTracking
{
    public partial class ReportWindow : Form
    {
        public ReportWindow()
        {
            InitializeComponent();
        }

        private void create_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "PDF Files|*.pdf";
            dlg.FilterIndex = 0;

            string fileName = string.Empty;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                fileName = dlg.FileName;

                Document myDocument = new Document(iTextSharp.text.PageSize.A4, 10, 10, 42, 35);
                PdfWriter.GetInstance(myDocument, new FileStream(fileName, FileMode.Create));
                myDocument.Open();

                string startDate = GetStartDate();
                string endDate = GetEndDate();

                var errors = GetErrorsInDateInterval(startDate, endDate);


                myDocument.Close();
            }
            this.Close();
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rb_day.Checked = false;
            rb_week.Checked = false;
            rb_month.Checked = false;
            groupBox2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string GetStartDate()
        {
            string startDate = string.Empty;
            if (groupBox2.Enabled == false)
            {
                startDate = string.Empty;
                if (rb_day.Checked == true)
                {
                    startDate = DateTime.Now.ToString("dd.MM.yyyy 00:00");
                }
                if (rb_week.Checked == true)
                {
                    DateTime baseDate = DateTime.Today;
                    var thisWeekStart = baseDate.AddDays(-(int)baseDate.DayOfWeek + 1);
                    startDate = thisWeekStart.ToString("dd.MM.yyyy 00:00");
                }
                if (rb_month.Checked == true)
                {
                    startDate = DateTime.Now.ToString("01.MM.yyyy 00:00");
                }
            }
            else
            {
                startDate = dateTimePickerStart.Value.ToString("dd.MM.yyyy HH:mm");
            }
            return startDate;
        }

        private string GetEndDate()
        {
            string endDate = string.Empty;
            if (groupBox2.Enabled == false)
            {
                endDate = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
            }
            else
            {
                endDate = dateTimePickerEnd.Value.ToString("dd.MM.yyyy HH:mm");
            }
            return endDate;
        }

        private Error[] GetErrorsInDateInterval(string sDate, string eDate)
        {
            DateTime StartDate = DateTime.Parse(sDate);
            DateTime EndDate = DateTime.Parse(eDate);
            BTContext db = new BTContext();
            var errors = (from p in db.Errors
                          where p.Date > StartDate && p.Date < EndDate
                          select p).ToArray();
            return errors;
        }
    }
}
