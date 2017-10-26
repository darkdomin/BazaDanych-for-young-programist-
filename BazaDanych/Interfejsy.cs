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
    public partial class Interfejsy : Form
    {
        //ZMIENNE
        int id;
        string konfiguracja = "datasource=localhost;port=3306;username=root;password=Darek80;database=baza";
        string tytul, kod, opis;
        //Konstruktor
        public Interfejsy(int nr, string x, string y, string z)
        {
            InitializeComponent();
            tytul = x;
            opis = y;
            kod = z;
            id = nr;
        }
        //przypisanie konstuktora do pól
        private void Interfejsy_Load(object sender, EventArgs e)
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
        // DODAJ Interfejs
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
                    "insert into baza.interfejsy set Nazwa='" + txtTitle.Text + "',Opis='" + txtDescription.Text + "',kod='" + txtKod.Text + "';";
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
        //Modyfikacja INTERFEJSów
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
                    "update baza.interfejsy set Nazwa='" + txtTitle.Text + "',Opis='" + txtDescription.Text + "',kod='" + txtKod.Text + "' where idInterfejsy=" + id + ";";
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
        //Usunięcie Interfejsu
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
                    "Delete from baza.interfejsy  where idInterfejsy=" + id + ";";
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
        //Zamknij
        private void zAMKNIJToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Przypnij
        private void pRZYPNIJToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            TopMost = true;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
        }
        //odepnij
        private void oDEPNIJToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        }
        //przycisk Anuluj
        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            txtDescription.BorderStyle = BorderStyle.None;
            txtKod.BorderStyle = BorderStyle.None;
            txtTitle.BorderStyle = BorderStyle.None;
            btnAdd.Visible = true;
            btnModify.Visible = true;
            btnDelete.Visible = true;
            txtDescription.ReadOnly = true;
            txtKod.ReadOnly = true;
            txtTitle.ReadOnly = true;
            txtTitle.BackColor = stworzKolor();
            txtDescription.BackColor = stworzKolor();
            txtKod.BackColor = stworzKolor();
            btnAnuluj.Visible = false;
        }
        //FUNKCJE
        //funkcja stworzenie nowego koloru szarego (szesnastkowy zapis)
        private Color stworzKolor()
        {
            Color szary = new Color();
            szary = Color.FromArgb(64, 64, 64);
            return szary;
        }

        //funkcja umozliwająca pisanie
        private void odblokowaniePlansz()
        {
            txtTitle.ReadOnly = false;
            txtDescription.ReadOnly = false;
            txtKod.ReadOnly = false;
        }
        // blokuje możliwosc pisania
        private void zablokujPlansze()
        {
            txtTitle.ReadOnly = true;
            txtDescription.ReadOnly = true;
            txtKod.ReadOnly = true;
        }

        //funkcja czyszcząca plansze
        private void czyszczeniePlansz()
        {
            txtTitle.Text = "";
            txtTitle.Clear();
            txtDescription.Text = "";
            txtDescription.Clear();
            txtKod.Text = "";
            txtKod.Clear();
        }
    }
}
