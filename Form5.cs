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
using System.Windows.Forms.DataVisualization.Charting;
namespace ogrenci_otomasyonu
{
    public partial class Form5 : Form
    {
        

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=.;Data Source=DESKTOP-34SDHO0\\SQLEXPRESS;Initial Catalog=ogrenci;Integrated Security = True;";
            string query = "SELECT [Ders Adı], [Alınan Not] FROM sınav_sonucuu";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                chart1.Series.Clear(); 
                Series series = new Series("Not Ortalaması"); 
                series.ChartType = SeriesChartType.Column;

                while (reader.Read())
                {
                    string dersAdi = reader["Ders Adı"].ToString();      
                    double alinannot = Convert.ToInt32(reader["Alınan Not"]); 

                    series.Points.AddXY(dersAdi, alinannot);
                }
                chart1.Series.Add(series);
                reader.Close();

            }

        }

        private void UpdateProgressBar()
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
           Form2 form2 = new Form2();
           form2.Show();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }
    }
}


