using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projektni_zadatak_g1
{
    public partial class DodavanjeAžuriranjeArtikla : Form
    {
        public DodavanjeAžuriranjeArtikla()
        {
            InitializeComponent();
            PrikaziArtikle();
        }

        DBKonekcija konekcija = new DBKonekcija();

        private void PrikaziArtikle()
        {
            try
            {
                string upit = "SELECT * FROM artikal ";
                if (textBoxTražiŠifra.Text != "" && textBoxTražiNazivArtikla.Text != "")
                {
                    upit += "WHERE naziv_artikla LIKE '" + textBoxTražiNazivArtikla.Text + "%' AND artikal_id = '" + textBoxTražiŠifra.Text + "' ";
                }
                MySqlDataAdapter adapter = new MySqlDataAdapter(upit, konekcija.OtvoriKonekciju());
                DataTable tabela = new DataTable();
                adapter.Fill(tabela);
                dataGridView1.DataSource = tabela;
                adapter.Dispose();
                konekcija.ZatvoriKonekciju();
                textBoxTražiŠifra.Text = "";
                textBoxTražiNazivArtikla.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonDodavanjeArtikla_Click(object sender, EventArgs e)
        {
            try
            {
                string upit = "INSERT INTO artikal (naziv_artikla, vrsta_artikla, cijena, količina) " +
                    "VALUES ('" + textBoxNazivArtikla.Text + "', " +
                    "'" + textBoxVrstaArtikla.Text + "', '" + Convert.ToDouble(textBoxCijena.Text) + "', " +
                    "'" + Convert.ToInt16(textBoxKoličina.Text) + "') ";
                MySqlCommand cmd = new MySqlCommand(upit, konekcija.OtvoriKonekciju());
                if (cmd.ExecuteNonQuery() != 0)
                {
                    MessageBox.Show("Uspješno ste dodali novi artikal!");
                }
                konekcija.ZatvoriKonekciju();
                textBoxNazivArtikla.Text = "";
                textBoxVrstaArtikla.Text = "";
                textBoxCijena.Text = "";
                textBoxKoličina.Text = "";
                PrikaziArtikle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PopuniTextBoxove()
        {
            try
            {
                string upit = "SELECT * FROM artikal " +
                    "WHERE artikal_id = '" + textBoxIDArtikla.Text + "' ";
                MySqlCommand cmd = new MySqlCommand(upit, konekcija.OtvoriKonekciju());
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if (textBoxNazivArtikla.Text == "")
                        textBoxNazivArtikla.Text = reader["naziv_artikla"].ToString();
                    if (textBoxVrstaArtikla.Text == "")
                        textBoxVrstaArtikla.Text = reader["vrsta_artikla"].ToString();
                    if (textBoxCijena.Text == "")
                        textBoxCijena.Text = reader["cijena"].ToString();
                    if (textBoxKoličina.Text == "")
                        textBoxKoličina.Text = reader["količina"].ToString();
                }
                reader.Close();
                konekcija.ZatvoriKonekciju();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonAžuriranjeArtikla_Click(object sender, EventArgs e)
        {
            try
            {
                PopuniTextBoxove();
                string upit = "UPDATE artikal SET " +
                    "naziv_artikla = '" + textBoxNazivArtikla.Text + "', " +
                    "vrsta_artikla = '" + textBoxVrstaArtikla.Text + "', cijena = '" + Convert.ToDouble(textBoxCijena.Text) + "', " +
                    "količina = " + Convert.ToInt16(textBoxKoličina.Text) + " + " + Convert.ToInt16(numericUpDownKoličina.Value) + " " +
                    "WHERE artikal_id = '" + textBoxIDArtikla.Text + "' ";

                MySqlCommand cmd = new MySqlCommand(upit, konekcija.OtvoriKonekciju());
                if (cmd.ExecuteNonQuery() != 0)
                {
                    MessageBox.Show("Uspješno ste ažurirali artikal!");
                }
                konekcija.ZatvoriKonekciju();
                textBoxNazivArtikla.Text = "";
                textBoxVrstaArtikla.Text = "";
                textBoxCijena.Text = "";
                textBoxKoličina.Text = "";
                numericUpDownKoličina.Value = 0;
                PrikaziArtikle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonTraži_Click(object sender, EventArgs e)
        {
            PrikaziArtikle();
        }
    }
}
