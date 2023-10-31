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
    public partial class IssueBookForm : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\LibrarySystemdb.mdf;Integrated Security=True;Connect Timeout=30");
        public IssueBookForm()
        {
            InitializeComponent();
        }
        private void FillStudent()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select StdID from StudentTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("StdID", typeof(int));
            dt.Load(rdr);
            StdCb.ValueMember = "StdID";
            StdCb.DataSource = dt;
            Con.Close();
        }
        private void FillBook()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select BookName from BookTbl where Qty>" + 0 + "", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("BookName", typeof(string));
            dt.Load(rdr);
            bookCb.ValueMember = "BookName";
            bookCb.DataSource = dt;
            Con.Close();
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (issueNumTb.Text == "" || StdNameTb.Text == "")
            {
                MessageBox.Show("Missisng Information");
            }
            else
            {
                string issuedate = issueDate.Value.Day.ToString() + "/" + issueDate.Value.Month.ToString() + "/" + issueDate.Value.Year.ToString();
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into IssueTbl values(" + issueNumTb.Text + "," + StdCb.SelectedValue.ToString() + ",'" + StdNameTb.Text + "','" + StdDepTb.Text + "','" + StdPhoneTb.Text + "','" + bookCb.SelectedValue.ToString() + "','" + issuedate + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Book Successfully Issued");
                Con.Close();
                UpdateBook();
                populate();
            }
        }
        public void populate()
        {
            Con.Open();
            string query = "select * from IssueTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            IssueBookDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void fetchstddata()
        {
            Con.Open();
            string query = "select * from StudentTbl where StdID=" + StdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                StdNameTb.Text = dr["StdName"].ToString();
                StdDepTb.Text = dr["StdDep"].ToString();
                StdPhoneTb.Text = dr["StdPhone"].ToString();
            }
            Con.Close();
        }
        private void UpdateBook()
        {
            int Qty, newQty;
            Con.Open();
            string query = "select * from BookTbl where  BookName='" + bookCb.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Qty = Convert.ToInt32(dr["Qty"].ToString());
                newQty = Qty - 1;
                string query1 = "update BookTbl set Qty=" + newQty + "where BookName='" + bookCb.SelectedValue.ToString() + "';";
                SqlCommand cmd1 = new SqlCommand(query1, Con);
                cmd1.ExecuteNonQuery();
                //StdDepTb.Text = dr["StdDep"].ToString();
                //StdPhoneTb.Text = dr["StdPhone"].ToString();
            }
            Con.Close();

        }
        private void UpdateBookCancellation()
        {
            int Qty, newQty;
            Con.Open();
            string query = "select * from BookTbl where  BookName='" + bookCb.SelectedItem.ToString() + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Qty = Convert.ToInt32(dr["Qty"].ToString());
                newQty = Qty - 1;
                string query1 = "update BookTbl set Qty=" + newQty + "where BookName='" + bookCb.SelectedItem.ToString() + "';";
                SqlCommand cmd1 = new SqlCommand(query1, Con);
                cmd1.ExecuteNonQuery();
                
            }
            Con.Close();

        }
        private void IssueBookForm_Load(object sender, EventArgs e)
        {
            FillStudent();
            FillBook();
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void StdCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void StdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchstddata();
        }

        private void IssueBookDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow row = IssueBookDGV.Rows[indexRow];

            issueNumTb.Text = row.Cells[0].Value.ToString();
            StdCb.SelectedItem = row.Cells[1].Value.ToString();
            StdNameTb.Text = row.Cells[2].Value.ToString();
            StdDepTb.Text = row.Cells[3].Value.ToString();
            StdPhoneTb.Text = row.Cells[4].Value.ToString();
            bookCb.SelectedItem = row.Cells[5].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (issueNumTb.Text == "")
            {
                MessageBox.Show("Enter the IssueNumber");
            }
            else
            {
                Con.Open();
                string query = "delete from IssueTbl where IssueNum = " + issueNumTb.Text + ";";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Isssue Successfully Canceled");
                Con.Close();
                UpdateBookCancellation();
                populate();
            }
        }
    }
}
