using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using static WindowsFormsApplication3.ProjectBDataSet;

namespace WindowsFormsApplication3
{
    public partial class form1 : Form
    {
        int Id;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-A8281LO;Initial Catalog=ProjectB;Integrated Security=True");
        public form1()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_addstudent_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("Data Source=NiluNilesh;Integrated Security=True");  
            string query = "INSERT INTO Student VALUES (@FirstName, @LastName, @Contact, @Email,@RegistrationNumber,@Status)";
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@FirstName", txtfirstname.Text);
            command.Parameters.AddWithValue("@LastName", txtlastname.Text);
            command.Parameters.AddWithValue("@Contact", txtcontact.Text);
            command.Parameters.AddWithValue("@Email", txtemail.Text);

            command.Parameters.AddWithValue("@RegistrationNumber", txtregistrationnumber.Text);
            string status = comboBox1.Text;
            if (status == "Active")
            {
                command.Parameters.AddWithValue("@Status", 5);
            }
            else
            {
                command.Parameters.AddWithValue("@Status", 6);
            }
            con.Open();
            int i = command.ExecuteNonQuery();

            

            if (i != 0)
            {
                MessageBox.Show(i + "DATA ADDED");
            }
            con.Close();



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_updatestudent_Click(object sender, EventArgs e)
        {
            
            try
            {
                con.Open();
                if (txtfirstname.Text != "" && txtlastname.Text != "" && txtcontact.Text != "" && txtemail.Text != "" && txtregistrationnumber.Text != "")
                {
                    
                    SqlCommand c = new SqlCommand("update Student set FirstName=@firstname,LastName=@lastname,Contact=@contact,Email=@email,RegistrationNumber=@registrationnumber,Status=@status where Id=@id", con);

                    c.Parameters.AddWithValue("@firstname", txtfirstname.Text);
                    c.Parameters.AddWithValue("@lastname", txtlastname.Text);
                    c.Parameters.AddWithValue("@contact", txtcontact.Text);

                    c.Parameters.AddWithValue("@email", txtemail.Text);

                    c.Parameters.AddWithValue("@registrationnumber", txtregistrationnumber.Text);
                    string status = comboBox1.Text;
                    if (status == "Active")
                    {
                        c.Parameters.AddWithValue("@Status", 5);
                    }
                    else
                    {
                        c.Parameters.AddWithValue("@Status", 6);
                    }

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
            catch(Exception ex)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

               
     
                con.Open();

                SqlCommand c = new SqlCommand("select * from Student", con);

                c.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter(c);

                DataSet ds = new DataSet();

                da.Fill(ds, "ss");

                dataGridView1.DataSource = ds.Tables["ss"]; ;
                con.Close();

                // dataGridView1.DataBind();

            }

            catch

            {

                MessageBox.Show("RECORD NOT FOUND");

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtfirstname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtlastname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

            txtcontact.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();


            txtemail.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtregistrationnumber.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void btn_deletestudent_Click(object sender, EventArgs e)
        {
            if (Id != 0)
            {
                SqlCommand cmd = new SqlCommand("delete Student where Id=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("SUCCESSFULLY DELETED");
               
            }
            else
            {
                MessageBox.Show("SELECT RECORD TO DELETE");
            }
        }
    }
}
   

