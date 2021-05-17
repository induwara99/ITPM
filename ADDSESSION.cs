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
    public partial class ADDSESSION : Form
    {
        int selectedRow;
        public ADDSESSION()
        {
            InitializeComponent();
        }
        private void ADDSESSIONLOAD()
        {
            // TODO: This line of code loads data into the 'lectDataSet.addlect' table. You can move, or remove it, as needed.
            this.addsesTableAdapter1.Fill(this.lectDataSet3.addses);
            SqlConnection con = new SqlConnection();

            con.ConnectionString = "data source = ROG; database = lect; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select MAX(sesID) from addses";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);


            Int64 abc = Convert.ToInt64(DS.Tables[0].Rows[0][0]);

            labelSes.Text = (abc + 1).ToString();
        }
       
        private void ADDSESSION_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lectDataSet3.addses' table. You can move, or remove it, as needed.
            this.addsesTableAdapter1.Fill(this.lectDataSet3.addses);
            // TODO: This line of code loads data into the 'lectDataSet2.addses' table. You can move, or remove it, as needed.
            LoadData();
            ADDSESSIONLOAD();
            
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {
            SqlConnection con = new SqlConnection("data source = ROG; database = lect; integrated security = True");
            SqlCommand sc;
            SqlDataReader dr;

            String sql1 = "Select fname from addlect where lvl = 'Lecturer'";
            try
            {
                con.Open();
                
                sc = new SqlCommand(sql1, con);
                dr = sc.ExecuteReader();

                while (dr.Read())
                {
                    lecNaComboBox.Items.Add(dr.GetValue(0).ToString());
                }
                sc.Dispose();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            String sql2 = "Select fname from addlect where lvl = 'Assistent Lecturer'";
            try
            {
                con.Open();
                sc = new SqlCommand(sql2, con);
                dr = sc.ExecuteReader();

                while (dr.Read())
                {
                    AssNameComboBox.Items.Add(dr.GetValue(0).ToString());
                }
                sc.Dispose();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            String sql3 = "Select subid from addsub";
            try
            {
                con.Open();
                sc = new SqlCommand(sql3, con);
                dr = sc.ExecuteReader();

                while (dr.Read())
                {
                    SubComboBox.Items.Add(dr.GetValue(0).ToString());
                }
                sc.Dispose();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            load();
            ADDSESSIONLOAD();
            clear();
        }
        private void clear()
        {
        
            numStudTextBox.Clear();
            lecNaComboBox.ResetText();
            AssNameComboBox.ResetText();
            groupComboBox.ResetText();
            SubComboBox.ResetText();
            ducomBox1.ResetText();
            typecomboBox1.ResetText();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void emIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void addsesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.addsesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lectDataSet2);

        }

        

        private void addsesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void AssNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADDSESSION AD = new ADDSESSION();
            AD.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchLecturer AD = new SearchLecturer();
            AD.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADDSUB AD = new ADDSUB();
            AD.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADDLEC AD = new ADDLEC();
            AD.Show();
        }
        public void load()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from addses", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "insert_data");
            addsesDataGridView1.DataSource = ds;
            addsesDataGridView1.DataMember = "insert_data";
            con.Close();

        }


        bool Mode = true;
        SqlConnection con = new SqlConnection("data source = ROG; database = lect; integrated security = True");
        SqlCommand cmd;
        String sql;
        DataTable table = new DataTable();
       
        private void insertDetails()
        {

            
            String lecname = lecNaComboBox.Text;
            String asslecname = AssNameComboBox.Text;
            String grup = groupComboBox.Text;
            String subj = SubComboBox.Text;
            int numstd = int.Parse(numStudTextBox.Text);
            int duration = int.Parse(ducomBox1.Text);
            String typ = typecomboBox1.Text;

            if (Mode == true)
            {
                sql = "insert into addses(lecname,asslecname,grup,subj,numstd,duration,typ) values ('" + lecname + "','" + asslecname + "','" + grup + "','" + subj + "','" + numstd + "','" + duration + "','" + typ + "')";
                con.Open();
                cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@lecname", lecname);
                cmd.Parameters.AddWithValue("@asslecname", asslecname);
                cmd.Parameters.AddWithValue("@grup", grup);
                cmd.Parameters.AddWithValue("@subj", subj);
                cmd.Parameters.AddWithValue("@numstd", numstd);
                cmd.Parameters.AddWithValue("@duration", duration);
                cmd.Parameters.AddWithValue("@typ", typ);
                cmd.ExecuteNonQuery();

                MessageBox.Show("All Session Details are Recorded Successfuly.");
            }
            else
            {
                MessageBox.Show("!! Details are NOT Recorded Successfuly. !!");

            }

            con.Close();

        }

        private void validateInsert()
        {
   
            if (lecNaComboBox.Text == "")
            {

                MessageBox.Show("Please Select the Lecturer Name!!");

            }
            else if (AssNameComboBox.Text == "")
            {

                MessageBox.Show("Please Select the Assistent Lecturer Name!!");
            }
            else if (groupComboBox.Text == "")
            {
                MessageBox.Show("Please Choose a Group!!");

            }
            else if (SubComboBox.Text == "")
            {
                MessageBox.Show("Please Choose a Subject!!");
            }

            else if (numStudTextBox.Text == "")
            {
                MessageBox.Show("Please Enter the Amoun Of Students Partisipating to the Lecturer!!");
            }
            else if (ducomBox1.Text == "")
            {
                MessageBox.Show("Please Enter Time Duration!!");
            }
            else if (typecomboBox1.Text == "")
            {
                MessageBox.Show("Please Enter the Session Type!!");
            }
            else
            {
                insertDetails();
                load();
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            validateInsert();
            clear();
        }
        private void update()
        {
            String lecname = lecNaComboBox.Text;
            String asslecname = AssNameComboBox.Text;
            String grup = groupComboBox.Text;
            String subj = SubComboBox.Text;
            int numstd = int.Parse(numStudTextBox.Text);
            int duration = int.Parse(ducomBox1.Text);
            String typ = typecomboBox1.Text;

            if (Mode == true)
            {
                
               sql = "UPDATE addses set lecname = @lecname, asslecname= @asslecname, grup= @grup, subj = @subj, numstd = @numstd, duration = @duration, typ = @typ where sesID = '" + labelSes.Text + "'";
                con.Open();
                cmd = new SqlCommand(sql, con);


                cmd.Parameters.AddWithValue("@lecname", lecname);
                cmd.Parameters.AddWithValue("@asslecname", asslecname);
                cmd.Parameters.AddWithValue("@grup", grup);
                cmd.Parameters.AddWithValue("@subj", subj);
                cmd.Parameters.AddWithValue("@numstd", numstd);
                cmd.Parameters.AddWithValue("@duration", duration);
                cmd.Parameters.AddWithValue("@typ", typ);

                //Execute the Query
                cmd.ExecuteNonQuery();
                MessageBox.Show(" All Session Details are Successfuly Updated!! ");

                labelSes.Enabled = true;

            }
            else
            {
                MessageBox.Show("!! Details are Not Updated !! ");
            }

            con.Close();

        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            update();
            clear();
            load();
        }
        string id;
        private void delete()
        {
            id = addsesDataGridView1.CurrentRow.Cells[0].Value.ToString();
            sql = "delete from addses where sesID = '" + labelSes.Text + "'";
            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@sesID", id);
            cmd.ExecuteNonQuery();
            MessageBox.Show(" Session Successfull Deleted!. ");
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            delete();
            clear();
            load();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SearchSession AD = new SearchSession();
            AD.Show();
        }

        private void addsesDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = addsesDataGridView1.Rows[selectedRow];
            labelSes.Text = row.Cells[0].Value.ToString();
            lecNaComboBox.Text = row.Cells[1].Value.ToString();
            AssNameComboBox.Text = row.Cells[2].Value.ToString();
            groupComboBox.Text = row.Cells[3].Value.ToString();
            SubComboBox.Text = row.Cells[4].Value.ToString();
            numStudTextBox.Text = row.Cells[5].Value.ToString();
            ducomBox1.Text = row.Cells[6].Value.ToString();
            typecomboBox1.Text = row.Cells[7].Value.ToString();

        }
    }
}
