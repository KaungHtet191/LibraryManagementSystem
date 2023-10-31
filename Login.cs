using LibraryManagementSystem;
using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Login : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\LibrarySystemdb.mdf;Integrated Security=True;Connect Timeout=30");
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from LibrarianTbl where LibName='"+UnameTb.Text+"' and LibPassword='"+UPassTb.Text+"'",Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
               this.Hide();
               MainForm main = new MainForm();
               main.Show();
            }
            else
            {
                MessageBox.Show("Wrong UserName or Password");
            }
            Con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            UnameTb.Text = "";
            UPassTb.Text = "";
        }
    }
}