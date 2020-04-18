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
                myDocument.Add(new Paragraph("Empty"));
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
            rb_week.Checked = false;
            rb_month.Checked = false;
            rb_year.Checked = false;
            groupBox2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
