using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace projektni_zadatak_g1
{
    internal class DBKonekcija
    {
        private MySqlConnection konekcija;
        private string server;
        private string port;
        private string baza;
        private string user;
        private string pass;
        private string konekcioniString;

        public DBKonekcija()
        {
            InicijalizirajKonekciju();
        }

        // Inicijalizacija varijabli za uspostavu konekcije
        private void InicijalizirajKonekciju()
        {
            server = "localhost"; // ili 192.168.4.64 ili IP računara gdje je podešen MySql
            port = "3306";
            baza = "baza_podataka_g1";
            user = "root";
            pass = "programiranje123#";

            konekcioniString = "SERVER=" + server + ";" + "DATABASE=" + baza + ";" +
                "PORT=" + port + ";" + "UID=" + user + ";" + "PASSWORD=" + pass + ";";

            // konekcija - objekat klase MySqlConnection - služi za kreiranje
            // konekcije prema bazi, prima jedan parametar, a to je konekcioniString
            konekcija = new MySqlConnection(konekcioniString);
        }

        public MySqlConnection OtvoriKonekciju()
        {
            try
            {
                // Nad objektom konekcija pozivamo funkciju Open() - koja omogućava 
                // otvaranje konekcije nad bazom ukoliko je konekcija zatvorena
                if (konekcija.State == ConnectionState.Closed)
                    konekcija.Open();
                return konekcija;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return konekcija;
            }
        }

        public void ZatvoriKonekciju()
        {
            try
            {
                if (konekcija.State == ConnectionState.Open)
                    konekcija.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}