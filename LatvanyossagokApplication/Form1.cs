using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatvanyossagokApplication
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        DataSet ds = new DataSet();
        MySqlCommand comm;
        MySqlDataAdapter da;
        DataTable table = new DataTable();


        const string varosok_tabla = @"
            CREATE TABLE IF NOT EXISTS varosok(
                id INTEGER AUTO_INCREMENT PRIMARY KEY,
                nev VARCHAR(80) NOT NULL UNIQUE,
                lakossag INT NOT NULL
            )

        ";
        const string latvanyossagok_tabla = @"
            CREATE TABLE IF NOT EXISTS latvanyossagok(
                id INTEGER AUTO_INCREMENT PRIMARY KEY,
                nev VARCHAR(80) NOT NULL,
                ar INT NOT NULL DEFAULT 0,
                varos_id INTEGER NOT NULL
            )

        ";
        const string adatbazis = "CREATE DATABASE IF NOT EXISTS `latvanyossagokdb`;";
        static private List<Varosok> varosok;
        const string masodlagos_kulcs = "ALTER TABLE latvanyossagok ADD FOREIGN KEY (varos_id) REFERENCES varosok(id) ON DELETE RESTRICT ON UPDATE RESTRICT;";

        public Form1()
        {

            InitializeComponent();
            try
            {
                conn = new MySqlConnection("Server=localhost;Database=latvanyossagokdb;Uid=root;Pwd=;Port=3306;");

                conn.Open();

                var database = new MySqlCommand(adatbazis, conn);
                database.ExecuteNonQuery();
                var belep = conn.CreateCommand();

                belep.CommandText = "USE latvanyossagokdb;";
                belep.ExecuteNonQuery();
                var comm = conn.CreateCommand();

                comm.CommandText = varosok_tabla;
                comm.ExecuteNonQuery();
                var comm2 = conn.CreateCommand();

                comm2.CommandText = latvanyossagok_tabla;
                comm2.ExecuteNonQuery();
                var kulso_kulcs = conn.CreateCommand();
                kulso_kulcs.CommandText = masodlagos_kulcs;
                kulso_kulcs.ExecuteNonQuery();


            }
            catch (Exception e)
            {
                MessageBox.Show("Hiba: " + e);
                throw;

            }
            VarosokListaFeltoltes();
            VarosokComboFeltoltes();

        }
        void VarosokComboFeltoltes()
        {
            table = new DataTable();
            da = new MySqlDataAdapter("Select * from varosok order by nev", conn);
            da.Fill(table);

            VarosNeveComboBox.Items.Clear();
            VarosNeveComboBox.DataSource = table;
            VarosNeveComboBox.DisplayMember = "nev";
            VarosNeveComboBox.SelectedIndex = -1;
        }

        void VarosokListaFeltoltes()
        {
            table = new DataTable();
            da = new MySqlDataAdapter("Select * from varosok order by id", conn);
            da.Fill(table);

            VarosokLista.Items.Clear();
            foreach (DataRow dr in table.Rows)
            {
                VarosokLista.Items.Add(dr["nev"].ToString()+ " - Lakosság: " + dr["lakossag"].ToString()+ " fő");
            }

            //VarosokLista.DataSource = null;
            //VarosokLista.DataSource = table;
           // VarosokLista.DisplayMember = "nev";

        }



        private void varos_hozzad_btn_Click(object sender, EventArgs e)
        {
            comm = new MySqlCommand("SELECT * FROM varosok where nev ='" + VarosNeve.Text + "'", conn);
            MySqlDataAdapter da = new MySqlDataAdapter(comm);
            da.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (string.IsNullOrWhiteSpace(VarosNeve.Text) || VarosLakossag.Value == 0)
            {
                MessageBox.Show("Minden mezőt ki kell tölteni!!");
                return;
            }
            else if (i > 0)
            {
                MessageBox.Show("Ez a város már létezik");
                ds.Clear();
            }
            else
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = " INSERT INTO varosok (nev,lakossag) VALUES (@nev,@lakossag)";
                cmd.Parameters.AddWithValue("@nev", VarosNeve.Text);
                cmd.Parameters.AddWithValue("@lakossag", VarosLakossag.Value);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sikeres feltöltés!");
            }
            VarosokListaFeltoltes();

        }

        private void latvanyossag_hozzad_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LatvanyossagNeve.Text))
            {
                MessageBox.Show("Nem adott meg látványosságot!");
                return;
            }else if (LatvanyossagAra.Value ==0)
            {
                MessageBox.Show("Nem adott meg árat!");
            }
            else if (VarosNeveComboBox.SelectedItem == null)
            {
                MessageBox.Show("Nem választott várost!!");
                return;
            }
            else
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = " INSERT INTO latvanyossagok (nev,ar,varos_id) VALUES (@nev,@ar,@varos_id)";
                cmd.Parameters.AddWithValue("@nev", LatvanyossagNeve.Text);
                cmd.Parameters.AddWithValue("@ar", LatvanyossagAra.Value);
                cmd.Parameters.AddWithValue("@varos_id", VarosNeveComboBox.SelectedItem);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sikeres feltöltés!");

            }


        }
        
        private void btn_varos_torles_Click(object sender, EventArgs e)
        {

            if (VarosokLista.SelectedIndex != null)
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM varosok WHERE id = @id";

                var varosok = (Varosok)VarosokLista.SelectedItem;
                cmd.Parameters.AddWithValue("@id", varosok.Id);

                cmd.ExecuteNonQuery();

                VarosokListaFeltoltes();  
            }
            
                MessageBox.Show("Nincs kiválasztva város!");
                return;
        }
    }
}
