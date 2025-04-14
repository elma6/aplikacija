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
    public partial class PrikazBrisanjeNarudžbe : Form
    {
        public PrikazBrisanjeNarudžbe()
        {
            InitializeComponent();
            PrikazNarudžbe();
        }

        DBKonekcija konekcija = new DBKonekcija();
        private void PrikazNarudžbe()
        {
            try
            {
                string upit = "SELECT narudzbenica_id, k.kupac_id, ime, prezime, datum_narudzbe " +
                    "FROM kupac k, narudzbenica n " +
                    "WHERE k.kupac_id = n.kupac_id ";
                MySqlDataAdapter adapter = new MySqlDataAdapter(upit, konekcija.OtvoriKonekciju());
                DataTable tabela = new DataTable();
                adapter.Fill(tabela);
                dataGridView1.DataSource = tabela;
                adapter.Dispose();
                konekcija.ZatvoriKonekciju();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BrisanjeNarudzbenice()
        {
            try
            {
                string upit = "DELETE FROM narudzbenica " +
                    "WHERE narudzbenica_id = '" + textBoxIDNarudžbe.Text + "' ";
                MySqlCommand cmd = new MySqlCommand(upit, konekcija.OtvoriKonekciju());
                if (cmd.ExecuteNonQuery() != 0)
                {
                    MessageBox.Show("Uspješno ste obrisali narudžbenicu!");
                }
                konekcija.ZatvoriKonekciju();
                PrikazNarudžbe();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BrisanjeStavkeNarudzbenice()
        {
            try
            {
                string upit = "DELETE FROM stavka_narudzbenice " +
                    "WHERE narudzbenica_id = '" + textBoxIDNarudžbe.Text + "' ";
                MySqlCommand cmd = new MySqlCommand(upit, konekcija.OtvoriKonekciju());
                if (cmd.ExecuteNonQuery() != 0)
                {
                    MessageBox.Show("Uspješno ste obrisali stavku narudžbenice!");
                }
                konekcija.ZatvoriKonekciju();
                PrikazNarudžbe();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BrisanjeStavkeNarudzbenice();
            BrisanjeNarudzbenice();
            textBoxIDNarudžbe.Text = "";
        }
    }
}


