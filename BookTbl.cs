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
    public partial class BookTbl : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\LibrarySystemdb.mdf;Integrated Security=True;Connect Timeout=30");
        public BookTbl()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BookTbl_Load(object sender, EventArgs e)
        {
            populate();
        }
        public void populate()
        {
            Con.Open();
            string query = "select * from BookTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            BookDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bookName.Text == "" || bookAuthor.Text == "" || bookPublisher.Text == "" || bookPrice.Text == "" || bookQty.Text == "")
            {
                MessageBox.Show("Missisng Information");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into BookTbl values('" + bookName.Text + "','" + bookAuthor.Text + "','" + bookPublisher.Text + "'," + bookPrice.Text + "," + bookQty.Text + ")", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book Added Successfully");
                Con.Close();
                populate();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bookName.Text == "")
            {
                MessageBox.Show("Enter Book Name");
            }
            else
            {
                Con.Open();
                string query = "delete from BookTbl where BookName = '" + bookName.Text + "';";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book Successfully Deleted");
                Con.Close();
                populate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bookName.Text == "" || bookAuthor.Text == "" || bookPublisher.Text == "" || bookPrice.Text == "" || bookQty.Text == "")
            {
                MessageBox.Show("Missisng Information");
            }
            else
            {
                Con.Open();
                string query = "update BookTbl set Author='" + bookAuthor.Text + "',Publisher='" + bookPublisher.Text + "',Price=" + bookPrice.Text + ", Qty=" + bookQty.Text + " where BookName='" + bookName.Text + "';";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book Successfully Updated");
                Con.Close();
                populate();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void BookDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow row = BookDGV.Rows[indexRow];

            bookName.Text = row.Cells[0].Value.ToString();
            bookAuthor.Text = row.Cells[1].Value.ToString();
            bookPublisher.Text = row.Cells[2].Value.ToString();
            bookPrice.Text = row.Cells[3].Value.ToString();
            bookQty.Text = row.Cells[4].Value.ToString();
        }
    }
}
