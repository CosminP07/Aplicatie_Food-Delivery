using System;
using LibrarieModele;
using LibrarieModele.Enumerari;
using NivelStocareDate;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatie_Food_Delivery_UI_WindowsForms
{
    public partial class FormRestaurante : Form
    {
        IStocareDataRestaurante adminRestaurante;


        /*
        private Label[] lblsNume_Prenume;
        private Label[] lblsVarsta;
        private Label[] lblsStatut;


        private TextBox txtNume_Prenume;
        private TextBox txtVarsta;

        private const int LATIME_CONTROL = 100;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 120;*/
        public FormRestaurante()
        {
            InitializeComponent();
            adminRestaurante = StocareFactory.GetAdministratorStocare();

            List<Restaurant> restaurante = adminRestaurante.GetRestaurante();

            //setare proprietati
            this.Size = new Size(1000, 500);
            this.StartPosition = FormStartPosition.CenterScreen;
            //this.Location = new Point(240, 190);
            this.Font = new Font("Raleway", 12, FontStyle.Bold);
            this.ForeColor = Color.DarkCyan;
            this.BackColor = Color.NavajoWhite;
            this.Text = "Informatii clienti";


            this.FormClosed += OnFormClosed;
        }

        public void AfiseazaGrid(List<Restaurant> restaurante)
        {
            dataGridViewRestaurante.DataSource = null;
            //dataGridViewClienti.DataSource = clienti;
            dataGridViewRestaurante.DataSource = restaurante.Select(s => new {
                s.Id_Restaurant,
                s.denumire,
                s.an_fondator,
                s.specific,
            }).ToList();
        }

        private void AfisareRestauranteInControlListbox(List<Restaurant> restaurante)
        {
            lstRestaurante.Items.Clear();
            foreach (Restaurant restaurant in restaurante)
            {
                //pentru a adauga un obiect de tip Student in colectia de Items a unui control de tip ListBox, 
                // clasa Student trebuie sa implementeze metoda ToString() specificand cuvantul cheie 'override' in definitie
                //pentru a arata ca metoda ToString a clasei de baza (Object) este suprascrisa
                lstRestaurante.Items.Add(restaurant);

                //personalizare sursa de date
                //lstAfisare.Items.Add(client.NumeComplet);
            }
        }

        private void mtResetLista_Click(object sender, EventArgs e)
        {
            List<Restaurant> restaurante = adminRestaurante.GetRestaurante();
            AfiseazaGrid(restaurante);
            AfisareRestauranteInControlListbox(restaurante);
        }
        private void Form2_Load_1(object sender, EventArgs e)
        {
            //AfiseazaClienti();
            AfisareRestauranteInControlListbox(adminRestaurante.GetRestaurante());
            dataGridViewRestaurante.DataSource = null;
            AfiseazaGrid(adminRestaurante.GetRestaurante());
        }

        /*private void AfiseazaClienti()
        {
            List<Client> clienti = adminClienti.GetClienti();

            lblsNume_Prenume = new Label[clienti.Count];
            lblsVarsta = new Label[clienti.Count];
            lblsStatut = new Label[clienti.Count];

            int i = 0;
            foreach (Client client in clienti)
            {
                //adaugare control de tip Label pentru numele si prenumele studentilor;
                lblsNume_Prenume[i] = new Label();
                lblsNume_Prenume[i].Width = LATIME_CONTROL * 2;
                lblsNume_Prenume[i].Text = client.nume_prenume;
                lblsNume_Prenume[i].Left = 0;
                lblsNume_Prenume[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsNume_Prenume[i]);

                //adaugare control de tip Label pentru varsta clientilor
                lblsVarsta[i] = new Label();
                lblsVarsta[i].Width = LATIME_CONTROL;
                lblsVarsta[i].Text = Convert.ToString(client.varsta);
                lblsVarsta[i].Left = 2 * DIMENSIUNE_PAS_X;
                lblsVarsta[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsVarsta[i]);

                //adaugare control de tip Label pentru notele studentilor
                lblsStatut[i] = new Label();
                lblsStatut[i].Width = LATIME_CONTROL;
                lblsStatut[i].Text = Convert.ToString(client.statut);
                lblsStatut[i].Left = 3 * DIMENSIUNE_PAS_X;
                lblsStatut[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsStatut[i]);
                i++;
            }
        }*/
        private void OnFormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnCautaClicked(object sender, EventArgs e)
        {
            /*if (txtCautare.Text != "")
            {

                int valid = 0;
                List<Client> clienti = adminClienti.GetClienti();
                for (int contor = 0; contor < clienti.Count; contor++)
                {
                    if (txtCautare.Text == clienti[contor].nume_prenume)
                    {
                        lblCautare1.Text = "Varsta: " + clienti[contor].varsta.ToString();
                        lblCautare1.ForeColor = Color.Green;
                        lblCautare2.ForeColor = Color.Green;
                        lblCautare2.Text = "Statut: " + clienti[contor].statut.ToString();
                        valid = 1;
                    }
                }
                if (valid == 0)
                {
                    lblCautare1.Text = "Client Negasit";
                    lblCautare1.ForeColor = Color.Red;
                    lblCautare2.Text = "";
                }
            }
            else
            {
                lblCautare1.Text = "Caseta goala";
                lblCautare1.ForeColor = Color.Red;
                lblCautare2.Text = "";
            }*/
        }

        private void metroBtnInapoi_Click(object sender, EventArgs e)
        {
            FormMeniu frm = new FormMeniu();
            frm.Show();
            this.Hide();
        }
        private void btnAdaugaRestaurant_Click(object sender, EventArgs e)
        {
            FormAdaugaRestaurant frmAdauga = new FormAdaugaRestaurant();
            frmAdauga.ShowDialog();
        }

        private void btnSorteazaClicked(object sender, EventArgs e)
        {
            /*List<Client> c1 = adminClienti.ClientiAlfabet(adminClienti.GetClienti());
            dataGridViewClienti.DataSource = c1;
            AfiseazaGrid(c1);
            dataGridViewClienti.Sort(dataGridViewClienti.Columns[1], ListSortDirection.Ascending);
            lstClienti.Sorted = true;
            AfisareClientiInControlListbox(adminClienti.GetClienti());*/
            List<Restaurant> restaurante = adminRestaurante.GetRestaurante();

            // Sortează lista de clienți în ordine alfabetică după nume_prenume
            restaurante = restaurante.OrderBy(c => c.denumire).ToList();

            // Actualizează sursa de date pentru dataGridViewClienti
            AfiseazaGrid(restaurante);

            // Actualizează listbox-ul
            AfisareRestauranteInControlListbox(restaurante);
        }

        private void StergeSelectedClicked(object sender, EventArgs e)
        {
            adminRestaurante.StergeRestaurant(adminRestaurante.GetRestaurant(adminRestaurante.GetRestaurante()[lstRestaurante.SelectedIndex].Id_Restaurant));
            AfisareRestauranteInControlListbox(adminRestaurante.GetRestaurante());
            //AfiseazaGrid(adminClienti.GetClienti());
        }

        private void btnModificaClicked(object sender, EventArgs e)
        {
            if (lstRestaurante.SelectedItem == null)
            {
                return;
            }
            FormModificaRestaurant frm = new FormModificaRestaurant(adminRestaurante.GetRestaurant(adminRestaurante.GetRestaurante()[lstRestaurante.SelectedIndex].Id_Restaurant));
            frm.ShowDialog();
        }

        private void btnCautaClicked(object sender, EventArgs e)
        {
            FormCautaRestaurant frm = new FormCautaRestaurant();
            frm.ShowDialog();
        }
    }
}
