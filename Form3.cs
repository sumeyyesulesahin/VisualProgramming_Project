using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ogrenci_otomasyonu
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'ogrenciDataSet7.persembe' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.persembeTableAdapter1.Fill(this.ogrenciDataSet7.persembe);
            // TODO: Bu kod satırı 'ogrenciDataSet6.cumaa' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.cumaaTableAdapter.Fill(this.ogrenciDataSet6.cumaa);
            // TODO: Bu kod satırı 'ogrenciDataSet5.persembe' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.persembeTableAdapter.Fill(this.ogrenciDataSet5.persembe);
            // TODO: Bu kod satırı 'ogrenciDataSet4.carsamba' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.carsambaTableAdapter.Fill(this.ogrenciDataSet4.carsamba);
            // TODO: Bu kod satırı 'ogrenciDataSet3.pazartesi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.pazartesiTableAdapter1.Fill(this.ogrenciDataSet3.pazartesi);
            // TODO: Bu kod satırı 'ogrenciDataSet2.sali' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.saliTableAdapter.Fill(this.ogrenciDataSet2.sali);
            // TODO: Bu kod satırı 'ogrenciDataSet1.pazartesi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.pazartesiTableAdapter.Fill(this.ogrenciDataSet1.pazartesi);

        }

        private void tabPage2_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2PictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
