using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using static WindowsFormsApplication3.ProjectBDataSet;

namespace WindowsFormsApplication3
{
    public partial class manage_clos : Form

    {
        int Id;
        public string con = "Data Source=DESKTOP-A8281LO;Initial Catalog=ProjectB;Integrated Security=True";
        public manage_clos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-A8281LO;Initial Catalog=ProjectB;Integrated Security=True");
            string query = "INSERT INTO Clo VALUES (@Name,@DateCreated,@DateUpdated)";
            SqlCommand c = new SqlCommand(query, con);
            c.Parameters.AddWithValue("@Name", txtname.Text);
            c.Parameters.AddWithValue("@DateCreated", DateTime.Now.ToString("MM/dd/yyy  hh:mm tt"));
            c.Parameters.AddWithValue("@DateUpdated", DateTime.Now.ToString("MM/dd/yyy  hh:mm tt"));
            con.Open();
            int i = c.ExecuteNonQuery();

 
 
            if (i != 0)
            {
                MessageBox.Show(i + "DATA ADDED");
            }
            con.Close();
        }
        private void manage_clos_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-A8281LO;Initial Catalog=ProjectB;Integrated Security=True");
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * FROM Clo", con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            // TODO: This line of code loads data into the 'projectBDataSet.Clo' table. You can move, or remove it, as needed.
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            


           
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-A8281LO;Initial Catalog=ProjectB;Integrated Security=True");
            try
            {
                con.Open();
                if (txtname.Text != "" && DateTime.Now.ToString("MM/dd/yyy  hh:mm tt") != "" && DateTime.Now.ToString("MM/dd/yyy  hh:mm tt") !="")
                {

                    SqlCommand c= new SqlCommand("update Clo set Name=@Name,DateCreated=@DateCreated,DateUpdated=@DateUpdated where Id=@id", con);

                    c.Parameters.AddWithValue("@Name", txtname.Text);
                    c.Parameters.AddWithValue("@DateCreated", DateTime.Now.ToString("MM/dd/yyy  hh:mm tt"));
                    c.Parameters.AddWithValue("@DateUpdated", DateTime.Now.ToString("MM/dd/yyy  hh:mm tt"));

       

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

        private void btn_deleteclo_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-A8281LO;Initial Catalog=ProjectB;Integrated Security=True");

            if (Id != 0)
            {
                SqlCommand c = new SqlCommand("delete Clo where Id=@id", con);
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

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_view_Click(object sender, EventArgs e)
        {

        }
    }
}