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

    public partial class Form1 : Form
    {
        //zmienne
        int id;
        bool wcisniety = true;
        string tekst, tytul, opis, konfiguracja = "datasource=localhost;port=3306;username=root;password=Darek80;database=baza";
        //konstruktor
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (dgGrid.Visible == true)
            {
                CancelButton = btnIf;
            }
        }
        //przycisk szukaj- na razie nie dziła
        private void btnSeek_Click(object sender, EventArgs e)
        {
            //    MySqlConnection laczBaze = new MySqlConnection(konfiguracja);
            //    MySqlCommand zapytanie = new MySqlCommand("chwilowy problem z zapytaniem do kilku tabel", laczBaze);
        }
        //SIATKA wyświetlenie rzędów w nowej formie
        private void dgGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id = Convert.ToInt16(dgGrid.Rows[e.RowIndex].Cells[0].Value);
                tekst = dgGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                tytul = dgGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                opis = dgGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                wywolanie(groupBox1);
            }
        }
        //Przycisk STRING
        private void btnString_Click_1(object sender, EventArgs e)
        {
            wcisniety = true;
            // wcisnietyButton(groupBox1);
            if (wcisniety)
            {
                btnString.BackColor = Color.WhiteSmoke;
                btnString.ForeColor = Color.Black;
                btnLoop.Visible = false;
                btnInterface.Visible = false;
                btnOther.Visible = false;
                btnIf.Visible = false;
                btnTable.Visible = false;
                btnSql.Visible = false;
                btnProgram.Visible = false;
            }
            wcisniety = false;
            if (dgGrid.Visible == false && txtSeek.Visible == false && btnSeek.Visible == false && button1.Visible == false)
            {
                Tekst nowy = new Tekst(id, tytul, opis, tekst);
                nowy.ShowDialog();
                pokazElementy();
                pokazButtony();
            }
            else
            {
                MySqlConnection laczBaze = new MySqlConnection(konfiguracja);
                MySqlCommand zapytanie = new MySqlCommand("SELECT idString as Nr, Nazwa as Tytuł, Opis, kod FROM baza.string;", laczBaze);
                try
                {
                    laczBaze.Open();
                    MySqlDataAdapter moja = new MySqlDataAdapter();
                    moja.SelectCommand = zapytanie;
                    DataTable tabela = new DataTable();
                    moja.Fill(tabela);

                    BindingSource zrodlo = new BindingSource();
                    zrodlo.DataSource = tabela;
                    dgGrid.DataSource = zrodlo;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                laczBaze.Close();
                ukryj();
            }
        }
        //przycisk PĘTLA
        private void btnLoop_Click_1(object sender, EventArgs e)
        {
            wcisniety = true;
            if (wcisniety)
            {
                btnLoop.BackColor = Color.WhiteSmoke;
                btnLoop.ForeColor = Color.Black;
                btnString.Visible = false;
                btnInterface.Visible = false;
                btnOther.Visible = false;
                btnIf.Visible = false;
                btnTable.Visible = false;
                btnSql.Visible = false;
                btnProgram.Visible = false;
            }
            wcisniety = false;
            if (dgGrid.Visible == false && txtSeek.Visible == false && btnSeek.Visible == false && button1.Visible == false)
            {
                petelka nowy = new petelka(id, tytul, opis, tekst);
                nowy.ShowDialog();
                pokazElementy();
                pokazButtony();
            }
            else
            {
                MySqlConnection laczBaze = new MySqlConnection(konfiguracja);
                MySqlCommand zapytanie = new MySqlCommand("SELECT idPętle as Nr, Nazwa as Tytuł, Opis, kod FROM baza.pętle;", laczBaze);
                try
                {
                    laczBaze.Open();
                    MySqlDataAdapter moja = new MySqlDataAdapter();
                    moja.SelectCommand = zapytanie;
                    DataTable tabela = new DataTable();
                    moja.Fill(tabela);

                    BindingSource zrodlo = new BindingSource();
                    zrodlo.DataSource = tabela;
                    dgGrid.DataSource = zrodlo;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                laczBaze.Close();
                ukryj();
            }
        }
        //przycisk INTERFEJSY
        private void btnInterface_Click_1(object sender, EventArgs e)
        {
            wcisniety = true;
            if (wcisniety == true)
            {
                btnInterface.BackColor = Color.WhiteSmoke;
                btnInterface.ForeColor = Color.Black;
                btnLoop.Visible = false;
                btnString.Visible = false;
                btnOther.Visible = false;
                btnIf.Visible = false;
                btnTable.Visible = false;
                btnSql.Visible = false;
                btnProgram.Visible = false;
            }
            wcisniety = false;
            if (dgGrid.Visible == false && txtSeek.Visible == false && btnSeek.Visible == false && button1.Visible == false)
            {
                Interfejsy nowy = new Interfejsy(id, tytul, opis, tekst);
                nowy.ShowDialog();
                pokazElementy();
                pokazButtony();
            }
            else
            {
                MySqlConnection laczBaze = new MySqlConnection(konfiguracja);
                MySqlCommand zapytanie = new MySqlCommand("SELECT idInterfejsy as Nr, Nazwa as Tytuł, Opis, kod FROM baza.interfejsy;", laczBaze);
                try
                {
                    laczBaze.Open();
                    MySqlDataAdapter moja = new MySqlDataAdapter();
                    moja.SelectCommand = zapytanie;
                    DataTable tabela = new DataTable();
                    moja.Fill(tabela);

                    BindingSource zrodlo = new BindingSource();
                    zrodlo.DataSource = tabela;
                    dgGrid.DataSource = zrodlo;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                laczBaze.Close();
                ukryj();
            }
        }
        //Programy Inne
        private void btnOther_Click(object sender, EventArgs e)
        {
            wcisniety = true;
            if (wcisniety == true)
            {
                btnOther.BackColor = Color.WhiteSmoke;
                btnOther.ForeColor = Color.Black;
                btnLoop.Visible = false;
                btnInterface.Visible = false;
                btnString.Visible = false;
                btnIf.Visible = false;
                btnTable.Visible = false;
                btnSql.Visible = false;
                btnProgram.Visible = false;
            }

            wcisniety = false;
            if (dgGrid.Visible == false && txtSeek.Visible == false && btnSeek.Visible == false && button1.Visible == false)
            {
                Other nowy = new Other(id, tytul, opis, tekst);
                nowy.ShowDialog();
                pokazElementy();
                pokazButtony();
            }
            else
            {
                MySqlConnection laczBaze = new MySqlConnection(konfiguracja);
                MySqlCommand zapytanie = new MySqlCommand("SELECT idOther as Nr, Nazwa as Tytuł, Opis, kod FROM baza.other;", laczBaze);
                try
                {
                    laczBaze.Open();
                    MySqlDataAdapter moja = new MySqlDataAdapter();
                    moja.SelectCommand = zapytanie;
                    DataTable tabela = new DataTable();
                    moja.Fill(tabela);

                    BindingSource zrodlo = new BindingSource();
                    zrodlo.DataSource = tabela;
                    dgGrid.DataSource = zrodlo;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                laczBaze.Close();
                ukryj();
            }
        }
        //IF Else
        private void btnIf_Click_1(object sender, EventArgs e)
        {
            wcisniety = true;
            if (wcisniety == true)
            {
                btnIf.BackColor = Color.WhiteSmoke;
                btnIf.ForeColor = Color.Black;
                btnLoop.Visible = false;
                btnInterface.Visible = false;
                btnOther.Visible = false;
                btnString.Visible = false;
                btnTable.Visible = false;
                btnSql.Visible = false;
                btnProgram.Visible = false;
            }
            wcisniety = false;

            if (dgGrid.Visible == false && txtSeek.Visible == false && btnSeek.Visible == false && button1.Visible == false)
            {
                Ifek nowy = new Ifek(id, tytul, opis, tekst);
                nowy.ShowDialog();
                pokazElementy();
                pokazButtony();
            }
            else
            {
                MySqlConnection laczBaze = new MySqlConnection(konfiguracja);
                MySqlCommand zapytanie = new MySqlCommand("SELECT idIf as Nr, Nazwa as Tytuł, Opis, kod FROM baza.ifek;", laczBaze);
                try
                {
                    laczBaze.Open();
                    MySqlDataAdapter moja = new MySqlDataAdapter();
                    moja.SelectCommand = zapytanie;
                    DataTable tabela = new DataTable();
                    moja.Fill(tabela);

                    BindingSource zrodlo = new BindingSource();
                    zrodlo.DataSource = tabela;
                    dgGrid.DataSource = zrodlo;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                laczBaze.Close();
                ukryj();
            }
        }
        //Tablice
        private void btnTable_Click_1(object sender, EventArgs e)
        {
            wcisniety = true;
            if (wcisniety == true)
            {
                btnTable.BackColor = Color.WhiteSmoke;
                btnTable.ForeColor = Color.Black;
                btnLoop.Visible = false;
                btnInterface.Visible = false;
                btnOther.Visible = false;
                btnIf.Visible = false;
                btnString.Visible = false;
                btnSql.Visible = false;
                btnProgram.Visible = false;
            }
            wcisniety = false;

            if (dgGrid.Visible == false && txtSeek.Visible == false && btnSeek.Visible == false && button1.Visible == false)
            {
                Tabl nowy = new Tabl(id, tytul, opis, tekst);
                nowy.ShowDialog();
                pokazElementy();
                pokazButtony();
            }
            else
            {
                MySqlConnection laczBaze = new MySqlConnection(konfiguracja);
                MySqlCommand zapytanie = new MySqlCommand("SELECT idTablice as Nr, Nazwa as Tytuł, Opis, kod FROM baza.tablice;", laczBaze);
                try
                {
                    laczBaze.Open();
                    MySqlDataAdapter moja = new MySqlDataAdapter();
                    moja.SelectCommand = zapytanie;
                    DataTable tabela = new DataTable();
                    moja.Fill(tabela);

                    BindingSource zrodlo = new BindingSource();
                    zrodlo.DataSource = tabela;
                    dgGrid.DataSource = zrodlo;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                laczBaze.Close();
            }
            ukryj();
        }
        //Programy MySql
        private void btnSql_Click(object sender, EventArgs e)
        {
            wcisniety = true;
            if (wcisniety == true)
            {
                btnSql.BackColor = Color.WhiteSmoke;
                btnSql.ForeColor = Color.Black;
                btnLoop.Visible = false;
                btnInterface.Visible = false;
                btnOther.Visible = false;
                btnIf.Visible = false;
                btnTable.Visible = false;
                btnString.Visible = false;
                btnProgram.Visible = false;
            }
            wcisniety = false;

            if (dgGrid.Visible == false && txtSeek.Visible == false && btnSeek.Visible == false && button1.Visible == false)
            {
                Msql nowy = new Msql(id, tytul, opis, tekst);
                nowy.ShowDialog();
                pokazElementy();
                pokazButtony();
            }
            else
            {
                MySqlConnection laczBaze = new MySqlConnection(konfiguracja);
                MySqlCommand zapytanie = new MySqlCommand("SELECT idsql as Nr, Nazwa as Tytuł, Opis, kod FROM baza.sql;", laczBaze);
                try
                {
                    laczBaze.Open();
                    MySqlDataAdapter moja = new MySqlDataAdapter();
                    moja.SelectCommand = zapytanie;
                    DataTable tabela = new DataTable();
                    moja.Fill(tabela);

                    BindingSource zrodlo = new BindingSource();
                    zrodlo.DataSource = tabela;
                    dgGrid.DataSource = zrodlo;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                laczBaze.Close();
                ukryj();
            }
        }
        //Programy Złożone
        private void btnProgram_Click_1(object sender, EventArgs e)
        {
            wcisniety = true;
            if (wcisniety == true)
            {
                btnProgram.BackColor = Color.WhiteSmoke;
                btnProgram.ForeColor = Color.Black;
                btnLoop.Visible = false;
                btnInterface.Visible = false;
                btnOther.Visible = false;
                btnIf.Visible = false;
                btnTable.Visible = false;
                btnSql.Visible = false;
                btnString.Visible = false;
            }
            wcisniety = false;

            if (dgGrid.Visible == false && txtSeek.Visible == false && btnSeek.Visible == false && button1.Visible == false)
            {
                Zlozone nowy = new Zlozone(id, tytul, opis, tekst);
                nowy.ShowDialog();
                pokazElementy();
                pokazButtony();
            }
            else
            {
                MySqlConnection laczBaze = new MySqlConnection(konfiguracja);
                MySqlCommand zapytanie = new MySqlCommand("SELECT idProgramy as Nr, Nazwa as Tytuł, Opis, kod FROM baza.zlozone;", laczBaze);
                try
                {
                    laczBaze.Open();
                    MySqlDataAdapter moja = new MySqlDataAdapter();
                    moja.SelectCommand = zapytanie;
                    DataTable tabela = new DataTable();
                    moja.Fill(tabela);

                    BindingSource zrodlo = new BindingSource();
                    zrodlo.DataSource = tabela;
                    dgGrid.DataSource = zrodlo;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                laczBaze.Close();
            }
            ukryj();
        }
        //przycisk DODAJ
        private void button1_Click(object sender, EventArgs e)
        {
            schowajElementy();
            pokazButtony();
            btnString.BackColor = Color.DimGray;
            btnString.ForeColor = Color.White;
            btnLoop.BackColor = Color.DimGray;
            btnLoop.ForeColor = Color.White;
            btnInterface.BackColor = Color.DimGray;
            btnInterface.ForeColor = Color.White;
            btnOther.BackColor = Color.DimGray;
            btnOther.ForeColor = Color.White;
            btnIf.BackColor = Color.DimGray;
            btnIf.ForeColor = Color.White;
            btnTable.BackColor = Color.DimGray;
            btnTable.ForeColor = Color.White;
            btnSql.BackColor = Color.DimGray;
            btnSql.ForeColor = Color.White;
            btnProgram.BackColor = Color.DimGray;
            btnProgram.ForeColor = Color.White;
        }
        //Przycisk Anuluj
        private void button2_Click(object sender, EventArgs e)
        {
            pokazButtony();
            pokazElementy();
            if (wcisniety == false)
            {
                btnString.BackColor = Color.DimGray;
                btnString.ForeColor = Color.White;
                btnLoop.BackColor = Color.DimGray;
                btnLoop.ForeColor = Color.White;
                btnInterface.BackColor = Color.DimGray;
                btnInterface.ForeColor = Color.White;
                btnOther.BackColor = Color.DimGray;
                btnOther.ForeColor = Color.White;
                btnIf.BackColor = Color.DimGray;
                btnIf.ForeColor = Color.White;
                btnTable.BackColor = Color.DimGray;
                btnTable.ForeColor = Color.White;
                btnSql.BackColor = Color.DimGray;
                btnSql.ForeColor = Color.White;
                btnProgram.BackColor = Color.DimGray;
                btnProgram.ForeColor = Color.White;
            }

        }
        //Funkcje
        //na razie nie dziala
        private void wcisnietyButton(Control zbior)
        {
            foreach (Control element in zbior.Controls)
            {
                if (element.GetType() == typeof(Button))
                {
                    if (wcisniety)
                    {
                        element.BackColor = Color.WhiteSmoke;
                        element.ForeColor = Color.Black;
                    }
                    else
                    {
                        element.Visible = false;
                    }
                }
            }

        }
        //funkcja pokazująca Buttony
        private void pokazButtony()
        {
            btnString.Visible = true;
            btnLoop.Visible = true;
            btnInterface.Visible = true;
            btnOther.Visible = true;
            btnIf.Visible = true;
            btnTable.Visible = true;
            btnSql.Visible = true;
            btnProgram.Visible = true;
        }
        //funkcja ukryj buttony
        private void schowajElementy()
        {
            dgGrid.Visible = false;
            txtSeek.Visible = false;
            btnSeek.Visible = false;
            button1.Visible = false;
        }
        //funkcja pokazująca elementy
        private void pokazElementy()
        {

            dgGrid.Visible = true;
            txtSeek.Visible = true;
            btnSeek.Visible = true;
            button1.Visible = true;
            btnAnuluj.Visible = true;
        }
        //funkcja ukrycie kolumny z siatki
        private void ukryj()
        {
            dgGrid.Columns[0].Visible = false;
            dgGrid.Columns[3].Visible = false;
        }
        // funkcja wyświetlenie nowego obiekut z siatki
        private void wywolanie(Control zbior)
        {
            foreach (Control element in zbior.Controls)
            {
                if (btnString.Visible == true)
                {
                    Tekst nowy = new Tekst(id, tytul, opis, tekst);
                    pokazButtony();
                    nowy.ShowDialog();
                    break;
                }
                else if (btnTable.Visible == true)
                {
                    Tabl nowy = new Tabl(id, tytul, opis, tekst);
                    pokazButtony();
                    nowy.ShowDialog();
                    break;
                }
                else if (btnLoop.Visible == true)
                {
                    petelka nowy = new petelka(id, tytul, opis, tekst);
                    pokazButtony();
                    nowy.ShowDialog();
                    break;
                }
                else if (btnIf.Visible == true)
                {
                    Ifek nowy = new Ifek(id, tytul, opis, tekst);
                    pokazButtony();
                    nowy.ShowDialog();
                    break;
                }
                else if (btnInterface.Visible == true)
                {
                    Interfejsy nowy = new Interfejsy(id, tytul, opis, tekst);
                    nowy.ShowDialog();
                    pokazButtony();
                    break;
                }
                else if (btnProgram.Visible == true)
                {
                    Zlozone nowy = new Zlozone(id, tytul, opis, tekst);
                    nowy.ShowDialog();
                    pokazButtony();
                    break;
                }
                else if (btnSql.Visible == true)
                {
                    Msql nowy = new Msql(id, tytul, opis, tekst);
                    nowy.ShowDialog();
                    pokazButtony();
                    break;
                }
                else if (btnOther.Visible == true)
                {
                    Other nowy = new Other(id, tytul, opis, tekst);
                    pokazButtony();
                    nowy.ShowDialog();
                    break;
                }
            }
        }
    }
}

