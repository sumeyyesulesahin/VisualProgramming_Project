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
    public partial class Form2 : Form
    {
        public string StudentId { get; set; }
        private string connectionString = ("Data Source=DESKTOP-34SDHO0\\SQLEXPRESS;Initial Catalog=ogrenci;Integrated Security=True");


        public Form2()
        {
            InitializeComponent();
        }
        private void SaveOptionToDatabase(string optionText)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO selected_option (student_id, selected_option) VALUES (@studentId, @selectedOption)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@studentId", StudentId);
                    command.Parameters.AddWithValue("@selectedOption", optionText);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close(); 
                }
            }
        }
        private void SaveSelectedOption(string selectedOption)
        { 

        }

            private void button1_Click(object sender, EventArgs e)
        {
            string selectedOption = "Ders Programı"; 
            SaveOptionToDatabase(selectedOption);
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selectedOption = "Sınav Sonuçları"; 
            SaveOptionToDatabase(selectedOption);
            this.Hide();
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
