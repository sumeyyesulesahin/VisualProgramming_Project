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

namespace ogrenci_otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con;
     
        SqlCommand com = new SqlCommand();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = guna2TextBox1.Text;
            string password=guna2TextBox2.Text;
            con = new SqlConnection("Data Source=DESKTOP-34SDHO0\\SQLEXPRESS;Initial Catalog=ogrenci;Integrated Security=True");
            con.Open();
            com.Connection = con;
            com.CommandText = "SELECT * FROM login_page WHERE student_id = @user AND sifre = @password";
            com.Parameters.AddWithValue("@user", guna2TextBox1.Text);
            com.Parameters.AddWithValue("@password", guna2TextBox2.Text);
            using (SqlDataReader dr = com.ExecuteReader())
                if (dr.Read())
            {
                MessageBox.Show("Tebrikler Giriş Başarılı");
                this.Hide();
                    string studentId = guna2TextBox1.Text;
                    Form2 form2 = new Form2();
                    form2.StudentId = studentId;
                    form2.Show();
               
            }
            else
            {
                MessageBox.Show("Hatalı Giriş.Tekrar Deneyin!");
            }
            con.Close();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
