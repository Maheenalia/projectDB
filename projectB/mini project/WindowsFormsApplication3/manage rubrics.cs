using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApplication3
{
    public partial class manage_rubrics : Form
    {
        int Id;
        public string con = "Data Source=DESKTOP-A8281LO;Initial Catalog=ProjectB;Integrated Security=True";
        public manage_rubrics()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_addrubric_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-A8281LO;Initial Catalog=ProjectB;Integrated Security=True");  
            string query = "INSERT INTO Rubric VALUES (@CloId, @Details)";
            SqlCommand c = new SqlCommand(query, con);
            c.Parameters.AddWithValue("@CloId", txtcloid.Text);
            c.Parameters.AddWithValue("@Details", txtdetailrubric.Text);
            con.Open();
            int i = c.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show(i + "DATA ADDED");
            }
            con.Close();

        }


        private void txtdetailrubric_TextChanged(object sender, EventArgs e)
        {

        }

        private void manage_rubrics_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'projectBDataSet.Rubric' table. You can move, or remove it, as needed.
            this.rubricTableAdapter.Fill(this.projectBDataSet.Rubric);
           

        }

        private void txtcloid_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_deleterubric_Click(object sender, EventArgs e)
        {
           
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-A8281LO;Initial Catalog=ProjectB;Integrated Security=True");

            if (Id != 0) 
            {
                SqlCommand c = new SqlCommand("delete Rubric where Id=@id", con);
                con.Open();
                c.Parameters.AddWithValue("@id", Id);
                c.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("SUCCESSFULLY DELETED");

            }
            else
            {
                MessageBox.Show("SELECT RECORD TO DELETE  ");
            }
        }

        private void btn_updaterubric_Click(object sender, EventArgs e)
        {
            int Id;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-A8281LO;Initial Catalog=ProjectB;Integrated Security=True");
            try
            {
                con.Open();
                if (txtcloid.Text != "" && DateTime.Now.ToString("MM/dd/yyy  hh:mm tt") != "" && DateTime.Now.ToString("MM/dd/yyy  hh:mm tt") != "")
                {

                    SqlCommand c = new SqlCommand("update Rubric set CloId=@CloId,Details=@Details where Id=@id", con);

                    c.Parameters.AddWithValue("@CloId", txtcloid.Text);
                    c.Parameters.AddWithValue("@Details", txtdetailrubric.Text);


                    c.Parameters.AddWithValue("@id", this.Id);
                    c.ExecuteNonQuery();

                    MessageBox.Show("SUCCESSFULLY UPDATED");


                }
                else
                {
                    MessageBox.Show("SELECT RECORD TO UPDATE");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            try
            {
                con.Open();
            }

            finally
            {
                con.Close();
            }
        }

        private void btn_view_Click(object sender, EventArgs e)
        {

        }
    }
    }
    


    
 