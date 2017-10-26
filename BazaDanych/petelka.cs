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
    public partial class petelka : Form
    {
        //ZMIENNE
        int id;
        string konfiguracja = "datasource=localhost;port=3306;username=root;password=Darek80;database=baza";
        string tytul, kod, opis;
        //konstruktor
        public petelka(int nr, string x, string y, string z)
        {

            InitializeComponent();
            tytul = x;
            opis = y;
            kod = z;
            id = nr;
        }
        //przypisanie konstuktora do pól
        private void petelka_Load(object sender, EventArgs e)
        {
            if (tytul != null)
            {
                txtTitle.Text = tytul.ToUpper();
                tytul = " ";
                txtKod.Text = kod;
                kod = " ";
                txtDescription.Text = opis;
                opis = " ";
            }
            else
            {
                txtKod.Text = kod;
                txtDescription.Text = opis;
                txtTitle.Text = tytul;
                btnDelete.Enabled = false;
                btnModify.Enabled = false;
            }
        }
        // DODAJ PĘTLĘ
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtKod.BorderStyle = BorderStyle.FixedSingle;
            txtTitle.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.BackColor = Color.DimGray;
            txtKod.BackColor = Color.DimGray;
            txtTitle.BackColor = Color.DimGray;

            if (txtTitle.ReadOnly == true && txtDescription.ReadOnly == true && txtKod.ReadOnly == true)
            {
                odblokowaniePlansz();
                czyszczeniePlansz();
                btnAnuluj.Visible = true;
                btnModify.Visible = false;
                btnDelete.Visible = false;
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
                    "insert into baza.pętle set Nazwa='" + txtTitle.Text + "',Opis='" + txtDescription.Text + "',kod='" + txtKod.Text + "';";
                    zapytanie.ExecuteNonQuery();
                    transakcja.Commit();
                    MessageBox.Show("Dodano do bazy");
                    btnModify.Visible = true;
                    btnDelete.Visible = true;
                }
                catch (Exception komunikat)
                {
                    MessageBox.Show(komunikat.Message);
                    transakcja.Rollback();
                    laczBaze.Close();
                }

            }
        }
        //Modyfikacja Pętli
        private void btnModify_Click(object sender, EventArgs e)
        {

            btnAnuluj.Visible = true;
            btnAdd.Visible = false;
            btnDelete.Visible = false;

            if (txtTitle.ReadOnly == true && txtDescription.ReadOnly == true && txtKod.ReadOnly == true)
            {
                odblokowaniePlansz();
                txtDescription.BackColor = Color.DimGray;
                txtKod.BackColor = Color.DimGray;
                txtTitle.BackColor = Color.DimGray;
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
                    "update baza.pętle set Nazwa='" + txtTitle.Text + "',Opis='" + txtDescription.Text + "',kod='" + txtKod.Text + "' where idPętle=" + id + ";";
                    zapytanie.ExecuteNonQuery();
                    transakcja.Commit();
                    MessageBox.Show("Baza danych została zmdyfikowana");
                    txtDescription.BackColor = stworzKolor();
                    txtKod.BackColor = stworzKolor();
                    txtTitle.BackColor = stworzKolor();
                    zablokujPlansze();
                    btnAdd.Visible = true;
                    btnDelete.Visible = true;
                }
                catch (Exception komunikat)
                {
                    MessageBox.Show(komunikat.Message);
                    transakcja.Rollback();
                }
                laczBaze.Close();
            }
        }
        //Usunięcie Pętli
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
                    "Delete from baza.pętle  where idPętle=" + id + ";";
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
        //Przycisk Anuluj
        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            btnAdd.Visible = true;
            btnDelete.Visible = true;
            btnModify.Visible = true;
            txtDescription.BorderStyle = BorderStyle.None;
            txtKod.BorderStyle = BorderStyle.None;
            txtTitle.BorderStyle = BorderStyle.None;
            txtDescription.ReadOnly = true;
            txtKod.ReadOnly = true;
            txtTitle.ReadOnly = true;
            txtTitle.BackColor = stworzKolor();
            txtDescription.BackColor = stworzKolor();
            txtKod.BackColor = stworzKolor();
            btnAnuluj.Visible = false;
        }

        //Funkcje
        //funkcja czyszcząca planszę
        private void czyszczeniePlansz()
        {
            txtTitle.Text = "";
            txtDescription.Text = "";

            txtKod.Text = "";
        }
        //funkcja umożliwiająca pisanie
        private void odblokowaniePlansz()
        {
            txtTitle.ReadOnly = false;
            txtDescription.ReadOnly = false;
            txtKod.ReadOnly = false;
        }
        //Przypnij
        private void pRZYPNIJToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            TopMost = true;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
        }
        //Odepnij
        private void oDEPNIJToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        }

        private void zToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //FUNKCJE
        //funkcja stworzenie nowego koloru szarego (szesnastkowy zapis)
        private Color stworzKolor()
        {
            Color szary = new Color();
            szary = Color.FromArgb(64, 64, 64);
            return szary;
        }
        // blokuje możliwosc pisania
        private void zablokujPlansze()
        {
            txtTitle.ReadOnly = true;
            txtDescription.ReadOnly = true;
            txtKod.ReadOnly = true;
        }

    }
}
