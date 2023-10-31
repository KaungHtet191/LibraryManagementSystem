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

namespace LibraryManagementSystem
{
    public partial class LibrarianForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\LibrarySystemdb.mdf;Integrated Security=True;Connect Timeout=30");
        public LibrarianForm()
        {
            InitializeComponent();
        }
       
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void LibrarianForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void populate()
        {
            Con.Open();
            string query = "select * from LibrarianTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            LibrarianDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {          
        
            if(LibID.Text == "" || LibName.Text == "" || LibPassword.Text == "" || LibPhone.Text == "")
            {
                 MessageBox.Show("Missisng Information");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into LibrarianTbl values(" + LibID.Text + ",'" + LibName.Text + "','" + LibPassword.Text + "','" + LibPhone.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Librarian Added Successfully");
                Con.Close();
                populate();
            }
            if (LibID.Text == LibID.Text)
            {
                MessageBox.Show("ID Duplicate");
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (LibID.Text == "")
            {
                MessageBox.Show("Enter the librarian ID");
            }
            else
            {
                Con.Open();
                string query = "delete from LibrarianTbl where LibID = " + LibID.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Librarian Successfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (LibID.Text == "" || LibName.Text == "" || LibPassword.Text == "" || LibPhone.Text == "")
            {
                MessageBox.Show("Missisng Information");
            }
            else
            {
                Con.Open();
                string query = "update LibrarianTbl set LibName='" + LibName.Text + "',LibPassword='" + LibPassword.Text + "',LibPhone='" + LibPhone.Text + "' where LibID=" + LibID.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Librarian Successfully Updated");
                Con.Close();
                populate();
            }
        }

        private void LibrarianDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();

        }

        private void LibrarianDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow row = LibrarianDGV.Rows[indexRow];

            LibID.Text = row.Cells[0].Value.ToString();
            LibName.Text= row.Cells[1].Value.ToString(); 
            LibPassword.Text= row.Cells[2].Value.ToString();
            LibPhone.Text= row.Cells[3].Value.ToString(); 
        }
    }
}
