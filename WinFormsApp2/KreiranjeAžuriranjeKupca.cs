using MySql.Data.MySqlClient;
using projektni_zadatak_g1;
using System.Data;

namespace projektni_zadatak_g1
{
    public partial class KreiranjeA�uriranjeKupca : Form
    {
        public KreiranjeA�uriranjeKupca()
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
                if (textBoxTra�iIme.Text != "" && textBoxTra�iPrezime.Text != "")
                {
                    upit += "WHERE ime LIKE '" + textBoxTra�iIme.Text + "%' AND prezime LIKE '" + textBoxTra�iPrezime.Text + "%' ";
                }
                MySqlDataAdapter adapter = new MySqlDataAdapter(upit, konekcija.OtvoriKonekciju());
                DataTable tabela = new DataTable();
                adapter.Fill(tabela);
                dataGridView1.DataSource = tabela;
                adapter.Dispose();
                konekcija.ZatvoriKonekciju();
                textBoxTra�iIme.Text = "";
                textBoxTra�iPrezime.Text = "";
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
                    "'" + textBoxUsername.Text + "', '" + textBox�ifra.Text + "') ";
                MySqlCommand cmd = new MySqlCommand(upit, konekcija.OtvoriKonekciju());
                if (cmd.ExecuteNonQuery() != 0)
                {
                    MessageBox.Show("Uspje�no ste dodali korisnika!");
                }
                konekcija.ZatvoriKonekciju();
                textBoxIme.Text = "";
                textBoxPrezime.Text = "";
                textBoxGrad.Text = "";
                textBoxAdresa.Text = "";
                textBoxTelefon.Text = "";
                textBoxUsername.Text = "";
                textBox�ifra.Text = "";
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
                    if (textBox�ifra.Text == "")
                        textBox�ifra.Text = reader["pass"].ToString();
                }
                reader.Close();
                konekcija.ZatvoriKonekciju();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonA�uriranjeKupca_Click(object sender, EventArgs e)
        {
            try
            {
                PopuniTextBoxove();
                string upit = "UPDATE kupac  " +
                    "SET ime = '" + textBoxIme.Text + "', " +
                    "prezime = '" + textBoxPrezime.Text + "', grad = '" + textBoxGrad.Text + "', adresa = '" + textBoxAdresa.Text + "', " +
                    "telefon = '" + textBoxTelefon.Text + "', " +
                    "user = '" + textBoxUsername.Text + "', pass = '" + textBox�ifra.Text + "' " +
                    "WHERE kupac_id = '" + textBoxID_kupca.Text + "' ";
                MySqlCommand cmd = new MySqlCommand(upit, konekcija.OtvoriKonekciju());
                if (cmd.ExecuteNonQuery() != 0)
                {
                    MessageBox.Show("Uspje�no ste a�urirali korisnika!");
                }
                konekcija.ZatvoriKonekciju();
                textBoxIme.Text = "";
                textBoxPrezime.Text = "";
                textBoxGrad.Text = "";
                textBoxAdresa.Text = "";
                textBoxTelefon.Text = "";
                textBoxUsername.Text = "";
                textBox�ifra.Text = "";
                textBoxID_kupca.Text = "";
                PrikaziKupce();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonTra�i_Click(object sender, EventArgs e)
        {
            PrikaziKupce();
        }
    }
}
