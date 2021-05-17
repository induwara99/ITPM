using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITPM
{
    public partial class SearchLecturer : Form
    {
        public SearchLecturer()
        {
            InitializeComponent();
        }

        void display()
        {

            SqlConnection con = new SqlConnection("Data Source=ROG;Initial Catalog=lect;Integrated Security=True;Pooling=False");
            DataTable dt = new DataTable();


            if (LectnameText.Text.Length > 0)
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from addlect where fname LIKE '" + LectnameText.Text + "%'", con);
                sda.Fill(dt);

            }
            else if (LecIdTxt.Text.Length > 0)
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from addlect where emId LIKE '" + LecIdTxt.Text + "%'", con);
                sda.Fill(dt);
            }
            else if (Lectlvltxt.Text.Length > 0)
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from addlect where lvl LIKE '" + Lectlvltxt.Text + "%'", con);
                sda.Fill(dt);
            }

            dataGridView1.DataSource = dt;
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void OwnertextBox1_TextChanged(object sender, EventArgs e)
        {
            LecIdTxt.Text = "";
            Lectlvltxt.Text = "";
            display();
        }

        private void LecIdTxt_TextChanged(object sender, EventArgs e)
        {
            LectnameText.Text = "";
            Lectlvltxt.Text = "";
            display();
        }

        private void Lectlvltxt_TextChanged(object sender, EventArgs e)
        {
            LectnameText.Text = "";
            LecIdTxt.Text = "";
            display();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADDSUB AD = new ADDSUB();
            AD.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADDLEC AD= new ADDLEC();
            AD.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADDSESSION AD = new ADDSESSION();
            AD.Show();
        }

        private void SearchLecturer_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchSession AD = new SearchSession();
            AD.Show();
        }
    }
}
