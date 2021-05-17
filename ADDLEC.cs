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
    public partial class ADDLEC : Form
    {
        public ADDLEC()
        {
            InitializeComponent();
            
            load();

        }

        bool Mode = true;
        SqlConnection con = new SqlConnection("data source = ROG; database = lect; integrated security = True");
        SqlCommand cmd;
        String sql;
        DataTable table = new DataTable();
        int selectedRow;
        public void load()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from addlect",con);
            DataSet ds = new DataSet();
            da.Fill(ds,"insert_data");
            addlectDataGridView.DataSource = ds;
            addlectDataGridView.DataMember = "insert_data";
            con.Close();

        }

        private void insertDetails()
        {

            String fname = fullNameTextBox.Text;
            String faname = faNameComboBox.Text;
            String depname = depNameComboBox.Text;
            String center = centerComboBox.Text;
            String building = buildingComboBox.Text;
            String lvl = lecLevelComboBox.Text;
            int lrank = int.Parse(lecRankComboBox.Text);

            if (Mode == true)
            {
                sql = "insert into addlect(fname,faname,depname,center,building,lvl,lrank) values ('" + fname + "','" + faname + "','" + depname + "','" + center + "','" + building + "','" + lvl + "','" + lrank + "')";
                con.Open();
                cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@fname", fname);
                cmd.Parameters.AddWithValue("@faname", faname);
                cmd.Parameters.AddWithValue("@depname", depname);
                cmd.Parameters.AddWithValue("@center", center);
                cmd.Parameters.AddWithValue("@building", building);
                cmd.Parameters.AddWithValue("@lvl", lvl);
                cmd.Parameters.AddWithValue("@lrank", lrank);
                cmd.ExecuteNonQuery();

                MessageBox.Show("All Lecturer Details are Recorded Successfuly.");
            }
            else
            {
                MessageBox.Show("!! Details are NOT Recorded Successfuly. !!");

            }

            con.Close();

        }
        private void validateInsert()
        {

            if (fullNameTextBox.Text == "")
            {

                MessageBox.Show("Please Insert the Name!! ");

            }
            else if (faNameComboBox.Text == "")
            {

                MessageBox.Show("Please Enter The Faculty Name !!");
            }
            else if (depNameComboBox.Text == "")
            {
                MessageBox.Show("Please Choose a Department!!");

            }
            else if (centerComboBox.Text == "")
            {
                MessageBox.Show("Please Choose a Center!!");
            }

            else if (buildingComboBox.Text == "")
            {
                MessageBox.Show("Please Choose a Building !!");
            }
            else if (lecLevelComboBox.Text == "")
            {
                MessageBox.Show("Please Choose a Level !!");

            }
            else if (lecRankComboBox.Text == "")
            {
                MessageBox.Show("Please Enter a rank");

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
            ADDLECLOAD();
            clear();
        }
        private void clear()
        {
            ADDLECLOAD();
            fullNameTextBox.Clear();
            faNameComboBox.ResetText();
            depNameComboBox.ResetText();
            centerComboBox.ResetText();
            buildingComboBox.ResetText();
            lecLevelComboBox.ResetText();
            lecRankComboBox.ResetText();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void ADDLECLOAD()
        {
            // TODO: This line of code loads data into the 'lectDataSet.addlect' table. You can move, or remove it, as needed.
            this.addlectTableAdapter.Fill(this.lectDataSet.addlect);
            SqlConnection con = new SqlConnection();

            con.ConnectionString = "data source = ROG; database = lect; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select MAX(emId) from addlect";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);


            Int64 abc = Convert.ToInt64(DS.Tables[0].Rows[0][0]);

            label2.Text = (abc + 1).ToString();
        }
        private void ADDLEC_Load(object sender, EventArgs e)
        {
            ADDLECLOAD();
        }

        
      
        private void button4_Click(object sender, EventArgs e)
        {
            load();

        }

        private void emIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fullNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void faNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void depNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lecRankComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buildingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void centerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lecRankLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        private void addlectBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.addlectBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lectDataSet);

        }

        private void addlectDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = addlectDataGridView.Rows[selectedRow];
            label2.Text = row.Cells[0].Value.ToString();
            fullNameTextBox.Text = row.Cells[1].Value.ToString();
            faNameComboBox.Text = row.Cells[2].Value.ToString();
            depNameComboBox.Text = row.Cells[3].Value.ToString();
            centerComboBox.Text = row.Cells[4].Value.ToString();
            buildingComboBox.Text = row.Cells[5].Value.ToString();
            lecLevelComboBox.Text = row.Cells[6].Value.ToString();
            lecRankComboBox.Text = row.Cells[7].Value.ToString();
        }

        private void lecLevelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void update()
        {
            String fname = fullNameTextBox.Text;
            String faname = faNameComboBox.Text;
            String depname = depNameComboBox.Text;
            String center = centerComboBox.Text;
            String building = buildingComboBox.Text;
            String lvl = lecLevelComboBox.Text;
            int lrank = int.Parse(lecRankComboBox.Text);
            String emId = label2.Text;

            if (Mode == true)
            {

                sql = "UPDATE addlect set fname = @fname, faname= @faname, depname= @depname, center = @center, building = @building, lvl = @lvl, lrank = @lrank where emId = '" + label2.Text + "'";
                con.Open();
                cmd = new SqlCommand(sql, con);


                cmd.Parameters.AddWithValue("@fname", fname);
                cmd.Parameters.AddWithValue("@faname", faname);
                cmd.Parameters.AddWithValue("@depname", depname);
                cmd.Parameters.AddWithValue("@center", center);
                cmd.Parameters.AddWithValue("@building", building);
                cmd.Parameters.AddWithValue("@lvl", lvl);
                cmd.Parameters.AddWithValue("@lrank", lrank);
                cmd.Parameters.AddWithValue("@emId", emId);

                //Execute the Query
                cmd.ExecuteNonQuery();
                MessageBox.Show(" All Lecturer Details are Successfuly Updated!! ");

                label2.Enabled = true;

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
            id = addlectDataGridView.CurrentRow.Cells[0].Value.ToString();
            sql = "delete from addlect where emId = '" + label2.Text + "'";
            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@emId", id);
            cmd.ExecuteNonQuery();
            MessageBox.Show(" Record Successfull Deleted!. ");

            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            delete();
            clear();
            load();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADDSUB AD = new ADDSUB();
            AD.Show();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchLecturer AD = new SearchLecturer();
            AD.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
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
