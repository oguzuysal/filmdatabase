using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(@"server = OGUZ; database = filmdb ; UID = sa; password = 1234");


        private void Form1_Load(object sender, EventArgs e)
        {


        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlDataAdapter o1 = new SqlDataAdapter("SELECT film_adi, oyuncu_adi, yonetmen_adi, senarist, yapimci, puan, yapim_yili, film_turu, dil, ulke, butce, kazanc, yas_siniri, sure FROM fdb WHERE film_turu IN ('Komedi')", cn);


            DataSet dt = new DataSet();
            o1.Fill(dt, "fdb");
            dataGridView1.DataSource = dt.Tables["fdb"].DefaultView;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter o1 = new SqlDataAdapter("SELECT film_adi, oyuncu_adi, yonetmen_adi, senarist, yapimci, puan, yapim_yili, film_turu, dil, ulke, butce, kazanc, yas_siniri, sure FROM fdb WHERE film_turu IN ('Dram')", cn);


            DataSet dt = new DataSet();
            o1.Fill(dt, "fdb");
            dataGridView1.DataSource = dt.Tables["fdb"].DefaultView;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlDataAdapter o1 = new SqlDataAdapter("SELECT TOP 25 film_adi,yonetmen_adi,oyuncu_adi,film_turu,yapim_yili,puan FROM fdb ORDER BY puan DESC", cn);


            DataSet dt = new DataSet();
            o1.Fill(dt, "fdb");
            dataGridView1.DataSource = dt.Tables["fdb"].DefaultView;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlDataAdapter o1 = new SqlDataAdapter("SELECT film_adi, oyuncu_adi, yonetmen_adi, senarist, yapimci, puan, yapim_yili, film_turu, dil, ulke, butce, kazanc, yas_siniri, sure FROM fdb WHERE film_turu IN ('Aksiyon')", cn);


            DataSet dt = new DataSet();
            o1.Fill(dt, "fdb");
            dataGridView1.DataSource = dt.Tables["fdb"].DefaultView;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT film_adi,yonetmen_adi,oyuncu_adi,puan,kazanc FROM fdb ORDER BY kazanc DESC ", cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "fdb");
            dataGridView1.DataSource = ds.Tables["fdb"].DefaultView;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string oyuncu = textBox1.Text.Trim();

            string query = "SELECT film_adi, oyuncu_adi, yonetmen_adi, yapim_yili, film_turu, puan FROM fdb WHERE oyuncu_adi LIKE '%" + oyuncu + "%'";

            SqlDataAdapter adapter = new SqlDataAdapter(query, cn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string yonetmen = textBox2.Text.Trim();
            string query = "SELECT film_adi, oyuncu_adi, yonetmen_adi, yapim_yili, film_turu, puan FROM fdb WHERE yonetmen_adi LIKE '%" + yonetmen + "%'";

            SqlDataAdapter adapter = new SqlDataAdapter(query, cn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT film_adi, oyuncu_adi, yonetmen_adi, senarist, yapimci, puan, yapim_yili, film_turu, dil, ulke, butce, kazanc, yas_siniri, sure FROM fdb ", cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "fdb");
            dataGridView1.DataSource = ds.Tables["fdb"].DefaultView;
        }

        private void buttonkayit_Click(object sender, EventArgs e)
        {
            Form2 form2 = Application.OpenForms["Form2"] as Form2;
            if (form2 == null)
            {
                form2 = new Form2();
            }
            form2.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SqlDataAdapter o1 = new SqlDataAdapter("SELECT film_adi, oyuncu_adi, yonetmen_adi, senarist, yapimci, puan, yapim_yili, film_turu, dil, ulke, butce, kazanc, yas_siniri, sure FROM fdb WHERE film_turu IN ('Animasyon')", cn);


            DataSet dt = new DataSet();
            o1.Fill(dt, "fdb");
            dataGridView1.DataSource = dt.Tables["fdb"].DefaultView;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SqlDataAdapter o1 = new SqlDataAdapter("SELECT film_adi, oyuncu_adi, yonetmen_adi, senarist, yapimci, puan, yapim_yili, film_turu, dil, ulke, butce, kazanc, yas_siniri, sure FROM fdb WHERE film_turu IN ('Korku')", cn);


            DataSet dt = new DataSet();
            o1.Fill(dt, "fdb");
            dataGridView1.DataSource = dt.Tables["fdb"].DefaultView;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SqlDataAdapter o1 = new SqlDataAdapter("SELECT film_adi, oyuncu_adi, yonetmen_adi, senarist, yapimci, puan, yapim_yili, film_turu, dil, ulke, butce, kazanc, yas_siniri, sure FROM fdb WHERE film_turu IN ('Bilim Kurgu')", cn);


            DataSet dt = new DataSet();
            o1.Fill(dt, "fdb");
            dataGridView1.DataSource = dt.Tables["fdb"].DefaultView;
        }
    }
}