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

namespace LibraryManagementSystem
{
    public partial class MemberForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\LibrarySystemdb.mdf;Integrated Security=True;Connect Timeout=30");
        public MemberForm()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void populate()
        {
            Con.Open();
            string query = "select * from StudentTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            StudentDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (StdID.Text == "" || StdName.Text == "" || StdPhone.Text == "")
            {
                MessageBox.Show("Missisng Information");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into StudentTbl values(" + StdID.Text + ",'" + StdName.Text + "','" + StdDep.Text + "','" + StdEdu.SelectedItem.ToString() + "','" + StdPhone.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Member Added Successfully");
                Con.Close();
                populate();
            }
        }

        private void MemberForm_Load_1(object sender, EventArgs e)
        {
            populate();
        }

        private void StudentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (StdID.Text == "")
            {
                MessageBox.Show("Enter member ID");
            }
            else
            {
                Con.Open();
                string query = "delete from StudentTbl where StdID = " + StdID.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Member Successfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (StdID.Text == "" || StdName.Text == "" || StdPhone.Text == "")
            {
                MessageBox.Show("Missisng Information");
            }
            else
            {
                Con.Open();
                string query = "update StudentTbl set StdName='" + StdName.Text + "',StdDep='" + StdDep.Text + "',StdEdu='" + StdEdu.SelectedItem.ToString() + "',StdPhone='" + StdPhone.Text + "' where StdID=" + StdID.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Member Successfully Updated");
                Con.Close();
                populate();
            }
        }

        private void StudentDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow row = StudentDGV.Rows[indexRow];

            StdID.Text = row.Cells[0].Value.ToString();
            StdName.Text = row.Cells[1].Value.ToString();
            StdDep.Text = row.Cells[2].Value.ToString();
            StdEdu.Text = row.Cells[3].Value.ToString();
            StdPhone.Text = row.Cells[4].Value.ToString();
        }
    }
}
