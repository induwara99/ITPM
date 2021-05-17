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
    public partial class SearchSession : Form
    {
        public SearchSession()
        {
            InitializeComponent();
        }
        void display()
        {

            SqlConnection con = new SqlConnection("Data Source=ROG;Initial Catalog=lect;Integrated Security=True;Pooling=False");
            DataTable dt = new DataTable();


            if (subId.Text.Length > 0)
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from addses where subj LIKE '" + subId.Text + "%'", con);
                sda.Fill(dt);

            }
            else if (Groupid.Text.Length > 0)
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from addses where grup LIKE '" + Groupid.Text + "%'", con);
                sda.Fill(dt);
            }
            else if (lecName.Text.Length > 0)
            {
                SqlDataAdapter sda = new SqlDataAdapter("select * from addses where lecname LIKE '" + lecName.Text + "%'", con);
                sda.Fill(dt);
            }

            dataGridView1.DataSource = dt;
        }

        private void LecIdTxt_TextChanged(object sender, EventArgs e)
        {
            lecName.Text = "";
            subId.Text = "";
            display();
        }

        private void subId_TextChanged(object sender, EventArgs e)
        {
            lecName.Text = "";
            Groupid.Text = "";
            display();
        }

        private void lecName_TextChanged(object sender, EventArgs e)
        {
            Groupid.Text = "";
            subId.Text = "";
            display();
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
            ADDLEC AD = new ADDLEC();
            AD.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADDSESSION AD = new ADDSESSION();
            AD.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchSession AD = new SearchSession();
            AD.Show();
        }
    }
}
