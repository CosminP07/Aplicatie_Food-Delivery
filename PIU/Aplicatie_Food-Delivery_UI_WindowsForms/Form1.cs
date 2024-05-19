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
    public partial class Form1 : Form
    {
        IStocareDataClienti adminClienti;

        private Label lblNume_Prenume;
        private Label lblVarsta;
        private Label lblStatut;

        private Label lblAdaugaNume_Prenume;
        private Label lblAdaugaVarsta;
        private Label lblAdaugaStatut;

        private Label[] lblsNume_Prenume;
        private Label[] lblsVarsta;
        private Label[] lblsStatut;

        private Button btnAdauga;

        private TextBox txtNume_Prenume;
        private TextBox txtVarsta;
        private TextBox txtStatut;

        private const int LATIME_CONTROL = 100;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 120;
        public Form1()
        {
            InitializeComponent();
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            // setare locatie fisier in directorul corespunzator solutiei
            // astfel incat datele din fisier sa poata fi utilizate si de alte proiecte
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            adminClienti = StocareFactory.GetAdministratorStocare2();

            List<Client> clienti = adminClienti.GetClienti();

            //setare proprietati
            this.Size = new Size(1000, 500);
            this.StartPosition = FormStartPosition.CenterScreen;
            //this.Location = new Point(240, 190);
            this.Font = new Font("Raleway", 12, FontStyle.Bold);
            this.ForeColor = Color.DarkCyan;
            this.BackColor = Color.Yellow;
            this.Text = "Informatii clienti";

            //adaugare control de tip Label pentru 'Nume si prenume';
            lblNume_Prenume = new Label();
            lblNume_Prenume.Width = LATIME_CONTROL*2;
            lblNume_Prenume.Text = "Nume si prenume";
            lblNume_Prenume.Left = 0;
            lblNume_Prenume.ForeColor = Color.DarkMagenta;
            this.Controls.Add(lblNume_Prenume);

            //adaugare control de tip Label pentru "Varsta";
            lblVarsta = new Label();
            lblVarsta.Width = LATIME_CONTROL;
            lblVarsta.Text = "Varsta";
            lblVarsta.Left = 2 * DIMENSIUNE_PAS_X;
            lblVarsta.ForeColor = Color.DarkMagenta;
            this.Controls.Add(lblVarsta);

            //adaugare control de tip Label pentru 'Note';
            lblStatut = new Label();
            lblStatut.Width = LATIME_CONTROL;
            lblStatut.Text = "Statut";
            lblStatut.Left = 3 * DIMENSIUNE_PAS_X;
            lblStatut.ForeColor = Color.DarkMagenta;
            this.Controls.Add(lblStatut);

            lblAdaugaNume_Prenume = new Label();
            lblAdaugaNume_Prenume.Width= LATIME_CONTROL*2;
            lblAdaugaNume_Prenume.Text = "Nume si prenume:";
            lblAdaugaNume_Prenume.Left = 4 * DIMENSIUNE_PAS_X;
            lblAdaugaNume_Prenume.ForeColor = Color.DarkMagenta;
            this.Controls.Add (lblAdaugaNume_Prenume);

            txtNume_Prenume = new TextBox();
            txtNume_Prenume.Width = LATIME_CONTROL * 2;
            txtNume_Prenume.Left = 4 * DIMENSIUNE_PAS_X;
            txtNume_Prenume.Top = DIMENSIUNE_PAS_Y;
            this.Controls.Add(txtNume_Prenume);

            lblAdaugaVarsta = new Label();
            lblAdaugaVarsta.Width = LATIME_CONTROL;
            lblAdaugaVarsta.Text = "Varsta:";
            lblAdaugaVarsta.Left = 4 * DIMENSIUNE_PAS_X;
            lblAdaugaVarsta.Top = 2* DIMENSIUNE_PAS_Y;
            lblAdaugaVarsta.ForeColor = Color.DarkMagenta;
            this.Controls.Add(lblAdaugaVarsta);

            txtVarsta = new TextBox();
            txtVarsta.Width = LATIME_CONTROL;
            txtVarsta.Left = 4 * DIMENSIUNE_PAS_X;
            txtVarsta.Top = 3 * DIMENSIUNE_PAS_Y;
            this.Controls.Add(txtVarsta);

            lblAdaugaStatut = new Label();
            lblAdaugaStatut.Width = LATIME_CONTROL;
            lblAdaugaStatut.Text = "Statut:";
            lblAdaugaStatut.Left = 4 * DIMENSIUNE_PAS_X;
            lblAdaugaStatut.Top = 4 * DIMENSIUNE_PAS_Y;
            lblAdaugaStatut.ForeColor = Color.DarkMagenta;
            this.Controls.Add(lblAdaugaStatut);

            txtStatut = new TextBox();
            txtStatut.Width = LATIME_CONTROL;
            txtStatut.Left = 4 * DIMENSIUNE_PAS_X;
            txtStatut.Top = 5 * DIMENSIUNE_PAS_Y;
            this.Controls.Add(txtStatut);

            btnAdauga = new Button();
           // btnAdauga.Width = LATIME_CONTROL;
            btnAdauga.Location = new System.Drawing.Point(4 * DIMENSIUNE_PAS_X, 6 * DIMENSIUNE_PAS_Y);
            btnAdauga.Text = "Adauga";
            btnAdauga.BackColor = Color.White;
            btnAdauga.AutoSize = true;
            // "Click" este un *event* in clasa Button
            // si poate avea atasat unul sau mai multe handlere de eveniment (adrese de functii)
            // Acesta este motivul utilizarii operatorului +=
            btnAdauga.Click += OnButtonClicked;
            this.Controls.Add(btnAdauga);

            this.FormClosed += OnFormClosed;
        }
        private void OnButtonClicked(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            AfiseazaClienti();
        }

        private void AfiseazaClienti()
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
                lblsNume_Prenume[i].Width = LATIME_CONTROL*2;
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
        }
        private void OnFormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnCautaClicked(object sender, EventArgs e)
        {
            if (txtCautare.Text != "")
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
            }
         }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            FormMeniu frm = new FormMeniu();
            frm.Show();
            this.Hide();
        }
    }
}
