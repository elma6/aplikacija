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
    public partial class KreiranjeNarudžbe : Form
    {
       // public static string korisnik_id;
       
        public KreiranjeNarudžbe()
        {
            InitializeComponent();
            PrikazArtikala();
        }
        DBKonekcija konekcija = new DBKonekcija();
        private void PrikazArtikala() 
        {
            try
            {
                string upit = "SELECT a.artikal.id, naziv_artikla, vrsta_artikla, cijena, s.kolicina_stanje " +
                    "FROM artikal a, skladiste s " +
                    "WHERE a.artikal.id = s.artikal_id ";
                MySqlDataAdapter adapter = new MySqlDataAdapter(upit, konekcija.OtvoriKonekciju());
                DataTable tabela = new DataTable();
                adapter.Fill(tabela);
                dataGridViewPregledArtikala.DataSource = tabela;
                adapter.Dispose();
                konekcija.ZatvoriKonekciju();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       string narudzba_id;
        private void DodajNarudžbu()
        {
            try
            {
                string upit = "INSERT INTO narudzbenica (kupac_id)" +
                    "VALUES () ";
                MySqlCommand cmd = new MySqlCommand(upit, konekcija.OtvoriKonekciju());
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    narudzba_id = reader["narudzbenica_id"].ToString();
                    MessageBox.Show("Uspješno ste dodali narudžbu!");
                    reader.Close();
                    konekcija.ZatvoriKonekciju();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonKreirajNarudžbu_Click(object sender, EventArgs e)
        {
            try
            {
                DodajNarudžbu();
                string upit = "INSERT INTO stavka_narudzbenice (narudzbenica_id, artikal_id, kolicina) " +
                    "VALUES ('"+narudzba_id+"', '"+textBoxID.Text+"', '"+textBoxKoličina.Text+"')";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
