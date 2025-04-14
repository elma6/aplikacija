using MySql.Data.MySqlClient;
using projektni_zadatak_g1;
using System.Data;

namespace projektni_zadatak_g1
{
    public partial class KreiranjeAûuriranjeKupca : Form
    {
        public KreiranjeAûuriranjeKupca()
        {
            InitializeComponent();
            PrikaziKupce();
        }
        DBKonekcija konekcija = new DBKonekcija();

        private void PrikaziKupce()
        {
            try
            {
                string upit = "SELECT * FROM kupac ";
                if (textBoxTraûiIme.Text != "" && textBoxTraûiPrezime.Text != "")
                {
                    upit += "WHERE ime LIKE '" + textBoxTraûiIme.Text + "%' AND prezime LIKE '" + textBoxTraûiPrezime.Text + "%' ";
                }
                MySqlDataAdapter adapter = new MySqlDataAdapter(upit, konekcija.OtvoriKonekciju());
                DataTable tabela = new DataTable();
                adapter.Fill(tabela);
                dataGridView1.DataSource = tabela;
                adapter.Dispose();
                konekcija.ZatvoriKonekciju();
                textBoxTraûiIme.Text = "";
                textBoxTraûiPrezime.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonKreiranjeKupca_Click(object sender, EventArgs e)
        {
            try
            {
                string upit = "INSERT INTO kupac (ime, prezime, grad, adresa, telefon, user, pass) " +
                    "VALUES ('" + textBoxIme.Text + "', " +
                    "'" + textBoxPrezime.Text + "', '" + textBoxGrad.Text + "', '" + textBoxAdresa.Text + "', '" + textBoxTelefon.Text + "', " +
                    "'" + textBoxUsername.Text + "', '" + textBoxäifra.Text + "') ";
                MySqlCommand cmd = new MySqlCommand(upit, konekcija.OtvoriKonekciju());
                if (cmd.ExecuteNonQuery() != 0)
                {
                    MessageBox.Show("Uspjeöno ste dodali korisnika!");
                }
                konekcija.ZatvoriKonekciju();
                textBoxIme.Text = "";
                textBoxPrezime.Text = "";
                textBoxGrad.Text = "";
                textBoxAdresa.Text = "";
                textBoxTelefon.Text = "";
                textBoxUsername.Text = "";
                textBoxäifra.Text = "";
                PrikaziKupce();
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
                string upit = "SELECT * FROM kupac " +
                    "WHERE kupac_id = '" + textBoxID_kupca.Text + "' ";
                MySqlCommand cmd = new MySqlCommand(upit, konekcija.OtvoriKonekciju());
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if (textBoxIme.Text == "")
                        textBoxIme.Text = reader["ime"].ToString();
                    if (textBoxPrezime.Text == "")
                        textBoxPrezime.Text = reader["prezime"].ToString();
                    if (textBoxGrad.Text == "")
                        textBoxGrad.Text = reader["grad"].ToString();
                    if (textBoxAdresa.Text == "")
                        textBoxAdresa.Text = reader["adresa"].ToString();
                    if (textBoxTelefon.Text == "")
                        textBoxTelefon.Text = reader["telefon"].ToString();
                    if (textBoxUsername.Text == "")
                        textBoxUsername.Text = reader["user"].ToString();
                    if (textBoxäifra.Text == "")
                        textBoxäifra.Text = reader["pass"].ToString();
                }
                reader.Close();
                konekcija.ZatvoriKonekciju();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonAûuriranjeKupca_Click(object sender, EventArgs e)
        {
            try
            {
                PopuniTextBoxove();
                string upit = "UPDATE kupac  " +
                    "SET ime = '" + textBoxIme.Text + "', " +
                    "prezime = '" + textBoxPrezime.Text + "', grad = '" + textBoxGrad.Text + "', adresa = '" + textBoxAdresa.Text + "', " +
                    "telefon = '" + textBoxTelefon.Text + "', " +
                    "user = '" + textBoxUsername.Text + "', pass = '" + textBoxäifra.Text + "' " +
                    "WHERE kupac_id = '" + textBoxID_kupca.Text + "' ";
                MySqlCommand cmd = new MySqlCommand(upit, konekcija.OtvoriKonekciju());
                if (cmd.ExecuteNonQuery() != 0)
                {
                    MessageBox.Show("Uspjeöno ste aûurirali korisnika!");
                }
                konekcija.ZatvoriKonekciju();
                textBoxIme.Text = "";
                textBoxPrezime.Text = "";
                textBoxGrad.Text = "";
                textBoxAdresa.Text = "";
                textBoxTelefon.Text = "";
                textBoxUsername.Text = "";
                textBoxäifra.Text = "";
                textBoxID_kupca.Text = "";
                PrikaziKupce();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonTraûi_Click(object sender, EventArgs e)
        {
            PrikaziKupce();
        }
    }
}
