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
    public partial class Msql : Form
    {
        //ZMIENNE
        int id;
        string konfiguracja = "datasource=localhost;port=3306;username=root;password=Darek80;database=baza";
        string tytul, kod, opis;
        //Konstruktor
        public Msql(int nr, string x, string y, string z)
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
        // DODAJ sql
        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnModify.Enabled = false;

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
                    "insert into baza.sql set Nazwa='" + txtTitle.Text + "',Opis='" + txtDescription.Text + "',kod='" + txtKod.Text + "';";
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
        //Usunięcie sql
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
                    "Delete from baza.sql  where idsql=" + id + ";";
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
        //Modyfikacja sql
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
                    "update baza.sql set Nazwa='" + txtTitle.Text + "',Opis='" + txtDescription.Text + "',kod='" + txtKod.Text + "' where idsql=" + id + ";";
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
        //funkcja czyszcząca plansze
        private void czyszczeniePlansz()
        {
            txtTitle.Text = "";
            txtTitle.Clear();
            txtDescription.Text = "";
            txtDescription.Clear();
            txtId.Text = "";
            txtId.Clear();
            txtKod.Text = "";
            txtKod.Clear();
        }
        //przypisanie konstuktora do pól
        private void Msql_Load(object sender, EventArgs e)
        {
            txtKod.Text = kod;
            txtTitle.Text = tytul;
            txtDescription.Text = opis;
            txtId.Text = Convert.ToString(id);
        }
    }
}
