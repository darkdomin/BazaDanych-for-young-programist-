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
namespace BazaDanych
{
    public partial class Tabl : Form
    {
        //ZMIENNE
        int id;
        string konfiguracja = "datasource=localhost;port=3306;username=root;password=Darek80;database=baza";
        string tytul, kod, opis;
        public Tabl(int nr, string x, string y, string z)
        {
            InitializeComponent();
            tytul = x;
            opis = y;
            kod = z;
            id = nr;
        }
        //funkcja umozliwająca pisanie
        private void odblokowaniePlansz()
        {
            txtTitle.ReadOnly = false;
            txtDescription.ReadOnly = false;
            txtKod.ReadOnly = false;
        }
        //Modyfikacja Tablic
        private void btnModify_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            if (txtTitle.ReadOnly == true && txtDescription.ReadOnly == true && txtKod.ReadOnly == true)
            {
                odblokowaniePlansz();
            }
            else
            {
                MySqlConnection laczBaze = new MySqlConnection(konfiguracja);
                MySqlCommand zapytanie = laczBaze.CreateCommand();
                MySqlTransaction transakcja;
                laczBaze.Open();
                transakcja = laczBaze.BeginTransaction(IsolationLevel.ReadCommitted);
                zapytanie.Connection = laczBaze;
                zapytanie.Transaction = transakcja;
                try
                {
                    zapytanie.CommandText =
                    "update baza.tablice set Nazwa='" + txtTitle.Text + "',Opis='" + txtDescription.Text + "',kod='" + txtKod.Text + "' where idTablice= '"+id+"' ;";
                    zapytanie.ExecuteNonQuery();
                    transakcja.Commit();
                    MessageBox.Show("Dodane do bazy");
                }
                catch (Exception komunikat)
                {
                    MessageBox.Show(komunikat.Message);
                    transakcja.Rollback();
                }
                laczBaze.Close();
            }
        }
        // DODAJ Tablice
        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnModify.Enabled = false;
            btnDelete.Enabled = false;
            if (txtTitle.ReadOnly == true && txtId.ReadOnly == true && txtDescription.ReadOnly == true && txtKod.ReadOnly == true)
            {
                odblokowaniePlansz();
                czyszczeniePlansz();
            }
            else
            {
                MySqlConnection laczBaze = new MySqlConnection(konfiguracja);
                MySqlCommand zapytanie = laczBaze.CreateCommand();
                MySqlTransaction transakcja;
                laczBaze.Open();
                transakcja = laczBaze.BeginTransaction(IsolationLevel.ReadCommitted);
                zapytanie.Connection = laczBaze;
                zapytanie.Transaction = transakcja;
                try
                {
                    zapytanie.CommandText =
                    "insert into baza.tablice set Nazwa='" + txtTitle.Text + "',Opis='" + txtDescription.Text + "',kod='" + txtKod.Text + "';";
                    zapytanie.ExecuteNonQuery();
                    transakcja.Commit();
                    MessageBox.Show("Dodane do bazy");
                }
                catch (Exception komunikat)
                {
                    MessageBox.Show(komunikat.Message);
                    transakcja.Rollback();
                    laczBaze.Close();
                }
            }
        }
        //Usunięcie Tablicy
        private void btnDelete_Click(object sender, EventArgs e)
        {
            MySqlConnection laczBaze = new MySqlConnection(konfiguracja);
            MySqlCommand zapytanie = laczBaze.CreateCommand();
            MySqlTransaction transakcja;
            laczBaze.Open();
            transakcja = laczBaze.BeginTransaction(IsolationLevel.ReadCommitted);
            zapytanie.Connection = laczBaze;
            zapytanie.Transaction = transakcja;
            try
            {
                if (MessageBox.Show("Czy na pewno usunąć Plik? \nOperacja nie do odwrócenia", "Uwaga!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    zapytanie.CommandText =
                    "Delete from baza.tablice  where idTablice=" + id + ";";
                    zapytanie.ExecuteNonQuery();
                    transakcja.Commit();
                    MessageBox.Show("Plik usunięty");
                    czyszczeniePlansz();
                }
            }
            catch (Exception komunikat)
            {
                MessageBox.Show(komunikat.Message);
                transakcja.Rollback();
            }
            laczBaze.Close();
        }
        //funkcja czyszcząca plansze
        private void czyszczeniePlansz()
        {
            txtTitle.Text = "";
            txtDescription.Text = "";
            txtId.Text = "";
            txtKod.Text = "";
        }
        //przypisanie konstuktora do pól
        private void Tabl_Load(object sender, EventArgs e)
        {
            txtKod.Text = kod;
            txtTitle.Text = tytul;
            txtDescription.Text = opis;
            txtId.Text = Convert.ToString(id);
        }
    }
}
