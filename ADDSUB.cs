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
    public partial class ADDSUB : Form
    {
        public ADDSUB()
        {
            InitializeComponent();
        }

        bool Mode = true;
        SqlConnection con = new SqlConnection("data source = ROG; database = lect; integrated security = True");
        SqlCommand cmd;
        String sql;
        SqlDataReader dr;
        DataTable table = new DataTable();
        int selectedRow;

        private void insertDetails()
        {

            String subid = subidtextBox1.Text;
            String offyear = offyearComboBox.Text;
            String offsem = offsemComboBox.Text;
            String subname = subnatextbox2.Text;
            String lechours = lechoComboBox.Text;
            String lectuthours = lectutComboBox.Text;
            String leclabhours = leclabComboBox.Text;
            String lecevahours = lecevaComboBox.Text;
  
            if (Mode == true)
            {
                sql = "insert into addsub(subid,offyear,offsem,subname,lechours,lectuthours,leclabhours,lecevahours) values ('" + subid + "','" + offyear + "','" + offsem + "','" + subname + "','" + lechours + "','" + lectuthours + "','" + leclabhours + "','" + lecevahours + "')";
                con.Open();
                cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@subid", subid);
                cmd.Parameters.AddWithValue("@offyear", offyear);
                cmd.Parameters.AddWithValue("@offsem", offsem);
                cmd.Parameters.AddWithValue("@subname", subname);
                cmd.Parameters.AddWithValue("@lechours", lechours);
                cmd.Parameters.AddWithValue("@lectuthours", lectuthours);
                cmd.Parameters.AddWithValue("@leclabhours", leclabhours);
                cmd.Parameters.AddWithValue("@lecevahours", lecevahours);
                cmd.ExecuteNonQuery();

                MessageBox.Show("All Subject Details are Recorded Successfuly.");
            }
            else
            {
                MessageBox.Show("!! Details are NOT Recorded Successfuly. !!");

            }

            con.Close();

        }

        private void validateInsert()
        {

            if (subidtextBox1.Text == "")
            {

                MessageBox.Show("Please Insert the Name!! ");

            }
            else if (offyearComboBox.Text == "")
            {

                MessageBox.Show("Please Choose The Year!!");
            }
            else if (offsemComboBox.Text == "")
            {
                MessageBox.Show("Please Choose The Semester!!");

            }
            else if (subnatextbox2.Text == "")
            {
                MessageBox.Show("Please Enter The Subject Name!!");
            }

            else if (lechoComboBox.Text == "")
            {
                MessageBox.Show("Please Choose Number of Lecture Hours !!");
            }
            else if (lectutComboBox.Text == "")
            {
                MessageBox.Show("Please Choose Number of Lecture Hours !!");

            }
            else if (leclabComboBox.Text == "")
            {
                MessageBox.Show("Please Choose Number of Lecture Hours !!");

            }
            else if (lecevaComboBox.Text == "")
            {
                MessageBox.Show("Please Choose Number of Lecture Hours !!");

            }
            else
            {
                insertDetails();
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            validateInsert();
            load();
            clear();
        }

        private void addsubBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.addsubBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lectDataSet1);

        }

        private void ADDSUB_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lectDataSet1.addsub' table. You can move, or remove it, as needed.
            this.addsubTableAdapter.Fill(this.lectDataSet1.addsub);

        }

        private void addsubDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            selectedRow = e.RowIndex;
            DataGridViewRow row = addsubDataGridView.Rows[selectedRow];
            subidtextBox1.Text = row.Cells[0].Value.ToString();
            offyearComboBox.Text = row.Cells[1].Value.ToString();
            offsemComboBox.Text = row.Cells[2].Value.ToString();
            subnatextbox2.Text = row.Cells[3].Value.ToString();
            lechoComboBox.Text = row.Cells[4].Value.ToString();
            lectutComboBox.Text = row.Cells[5].Value.ToString();
            leclabComboBox.Text = row.Cells[6].Value.ToString();
            lecevaComboBox.Text = row.Cells[7].Value.ToString();
        }
        private void clear()
        {
            subidtextBox1.Clear();
            offyearComboBox.ResetText();
            offsemComboBox.ResetText();
            subnatextbox2.Clear();
            lechoComboBox.ResetText();
            lectutComboBox.ResetText();
            leclabComboBox.ResetText();
            lecevaComboBox.ResetText();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            clear();
            load();
        }
        
        private void btnupdate_Click(object sender, EventArgs e)
        {
            String subid = subidtextBox1.Text;
            String offyear = offyearComboBox.Text;
            String offsem = offsemComboBox.Text;
            String subname = subnatextbox2.Text;
            String lechours = lechoComboBox.Text;
            String lectuthours = lectutComboBox.Text;
            String leclabhours = leclabComboBox.Text;
            String lecevahours = lecevaComboBox.Text;

            if (Mode == true)
            {

                sql = "UPDATE addsub set offyear= @offyear, offsem= @offsem, subname = @subname, lechours = @lechours, lectuthours = @lectuthours, leclabhours = @leclabhours,lecevahours = @lecevahours  where subid = '" + subidtextBox1.Text + "'";
                con.Open();
                cmd = new SqlCommand(sql, con);


                cmd.Parameters.AddWithValue("@subid", subid);
                cmd.Parameters.AddWithValue("@offyear", offyear);
                cmd.Parameters.AddWithValue("@offsem", offsem);
                cmd.Parameters.AddWithValue("@subname", subname);
                cmd.Parameters.AddWithValue("@lechours", lechours);
                cmd.Parameters.AddWithValue("@lectuthours", lectuthours);
                cmd.Parameters.AddWithValue("@leclabhours", leclabhours);
                cmd.Parameters.AddWithValue("@lecevahours", lecevahours);

                //Execute the Query
                cmd.ExecuteNonQuery();
                MessageBox.Show(" All Lecturer Details are Successfuly Updated!! ");

                subidtextBox1.Enabled = true;


            }
            else
            {
                MessageBox.Show("!! Details are Not Updated !! ");
            }

            con.Close();
            load();
            clear();
        }

        string id;

        private void button1_Click(object sender, EventArgs e)
        {
            id = addsubDataGridView.CurrentRow.Cells[0].Value.ToString();
            sql = "delete from addsub where subid = '" + subidtextBox1.Text + "'";
            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@subid", id);
            cmd.ExecuteNonQuery();
            MessageBox.Show(" Record Successfull Deleted!. ");

            con.Close();
            load();
            clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADDLEC AD = new ADDLEC();
            AD.Show();
        }
        public void load()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from addsub", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "insert_data");
            addsubDataGridView.DataSource = ds;
            addsubDataGridView.DataMember = "insert_data";
            con.Close();

        }

        public void getID(String id)
        {

            sql = "select * from addsub where subid= '" + id + "'   ";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                subidtextBox1.Text = dr[0].ToString();
                offyearComboBox.Text = dr[1].ToString();
                offsemComboBox.Text = dr[2].ToString();
                subnatextbox2.Text = dr[3].ToString();
                lechoComboBox.Text = dr[4].ToString();
                lectutComboBox.Text = dr[5].ToString();
                leclabComboBox.Text = dr[6].ToString();
                lecevaComboBox.Text = dr[7].ToString();

            }

            con.Close();

        }




        private void addsubDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == addsubDataGridView.Columns["edit"].Index && e.RowIndex >= 0)
            {
                Mode = false;
                subidtextBox1.Enabled = false;
                id = addsubDataGridView.CurrentRow.Cells[0].Value.ToString();

                getID(id);




            }
            else if (e.ColumnIndex == addsubDataGridView.Columns["delete"].Index && e.RowIndex >= 0)
            {
                Mode = false;
                id = addsubDataGridView.CurrentRow.Cells[0].Value.ToString();

                sql = "delete from addsub where subid = @subid";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@subid", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Record Successfull Deleted!. ");

                con.Close();


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            load();
            clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchLecturer AD = new SearchLecturer();
            AD.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADDSESSION AD = new ADDSESSION();
            AD.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchSession AD = new SearchSession();
            AD.Show();
        }
    }
}
