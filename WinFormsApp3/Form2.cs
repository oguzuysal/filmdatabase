using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"server = OGUZ; database = filmdb ; UID = sa; password = 1234");

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = Application.OpenForms["Form1"] as Form1;
            if (form1 == null)
            {
                form1 = new Form1();
            }
            form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e, cn.ConnectionString);
        }

        private void button2_Click(object sender, EventArgs e, string connectionString)
        {
            string filmAdi = txtfilmadi.Text;
            string oyuncu = txtoyuncu.Text;
            string yonetmen = txtyonetmen.Text;
            string senarist = txtsenarist.Text;
            string yapim = txtyapim.Text;
            decimal puan = decimal.Parse(txtpuan.Text);
            int yil = int.Parse(txtyil.Text);
            string tur = txttur.Text;
            string dil = txtdil.Text;
            string ulke = txtulke.Text;
            SqlMoney butce = SqlMoney.Parse(txtbutce.Text);
            SqlMoney kazanc = SqlMoney.Parse(txtkazanc.Text);
            string yassiNiri = txtyassiniri.Text;
            int sure = int.Parse(txtsure.Text);

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO fdb (film_adi, oyuncu_adi, yonetmen_adi, senarist, yapimci, puan, yapim_yili, film_turu, dil, ulke, butce, kazanc, yas_siniri, sure) " +
                                   "VALUES (@filmAdi, @oyuncu, @yonetmen, @senarist, @yapim, @puan, @yil, @tur, @dil, @ulke, @butce, @kazanc, @yassiNiri, @sure)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@filmAdi", filmAdi);
                        command.Parameters.AddWithValue("@oyuncu", oyuncu);
                        command.Parameters.AddWithValue("@yonetmen", yonetmen);
                        command.Parameters.AddWithValue("@senarist", senarist);
                        command.Parameters.AddWithValue("@yapim", yapim);
                        command.Parameters.AddWithValue("@puan", puan);
                        command.Parameters.AddWithValue("@yil", yil);
                        command.Parameters.AddWithValue("@tur", tur);
                        command.Parameters.AddWithValue("@dil", dil);
                        command.Parameters.AddWithValue("@ulke", ulke);
                        command.Parameters.AddWithValue("@butce", butce);
                        command.Parameters.AddWithValue("@kazanc", kazanc);
                        command.Parameters.AddWithValue("@yassiNiri", yassiNiri);
                        command.Parameters.AddWithValue("@sure", sure);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Başarılı");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cn.ConnectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM fdb WHERE film_id = (SELECT MAX(film_id) FROM fdb)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Son veri başarıyla silindi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }

}
