using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITPM
{
    public partial class PrintLecturer : Form
    {
        public PrintLecturer()
        {
            InitializeComponent();
        }

        private void addlectBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.addlectBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lectDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lectDataSet.addlect' table. You can move, or remove it, as needed.
            this.addlectTableAdapter.Fill(this.lectDataSet.addlect);

        }
        

        private void print_Click(object sender, EventArgs e)
        {
            try
            {
                printPreviewDialog1.ShowDialog();
            }
            catch
            {
                throw new ApplicationException("Error, Check Your System");
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            try
            {
                e.Graphics.DrawString(rtReceipt.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(0, 0));
            }
            catch
            {
                throw new ApplicationException("Error, Check Your System");
            }


        }

        private void recordsbtn_Click(object sender, EventArgs e)
        {
            try
            {
                rtReceipt.Clear();
                rtReceipt.AppendText("\t"+" Lecturer Details "+"\n");
                rtReceipt.AppendText("==================================" + "\n");
                rtReceipt.AppendText("Lecturer ID " + "\t" + "\t" + "\t" + "\t"+ emIdTextBox.Text+ "\n");
                rtReceipt.AppendText("Lecturer Name " + "\t" + "\t" + "\t" + "\t" + fnameTextBox.Text + "\n");
                rtReceipt.AppendText("Faculty Name " + "\t" + "\t" + "\t" + "\t" + fanameTextBox.Text + "\n");
                rtReceipt.AppendText("Department ID " + "\t" + "\t" + "\t" + "\t" + depnameTextBox.Text + "\n");
                rtReceipt.AppendText("Center " + "\t" + "\t" + "\t" + "\t" + centerTextBox.Text + "\n");
                rtReceipt.AppendText("Building " + "\t" + "\t" + "\t" + "\t" + buildingTextBox.Text + "\n");
                rtReceipt.AppendText("Lecturer Level" + "\t" + "\t" + "\t" + "\t" + lvlTextBox.Text + "\n");
                rtReceipt.AppendText("Lecturer Rank" + "\t" + "\t" + "\t" + "\t" + lrankTextBox.Text + "\n");
            }
            catch
            {
                throw new ApplicationException("Error, Check Your System");
            }
        }
    }
}
