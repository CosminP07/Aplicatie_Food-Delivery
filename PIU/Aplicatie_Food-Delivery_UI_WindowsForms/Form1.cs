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
        AdministrareClienti_Fisier adminClienti;

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
            adminClienti = new AdministrareClienti_Fisier(caleCompletaFisier);
            int nrClienti1 = 0;

            Client[] clienti = adminClienti.GetClienti(out nrClienti1);

            //setare proprietati
            this.Size = new Size(500, 200);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(440, 290);
            this.Font = new Font("Calibri", 12, FontStyle.Bold);
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
            lblAdaugaNume_Prenume.ForeColor = Color.DarkSeaGreen;
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
            btnAdauga.Width = LATIME_CONTROL;
            btnAdauga.Location = new System.Drawing.Point(4 * DIMENSIUNE_PAS_X, 6 * DIMENSIUNE_PAS_Y);
            btnAdauga.Text = "Adauga";
            // "Click" este un *event* in clasa Button
            // si poate avea atasat unul sau mai multe handlere de eveniment (adrese de functii)
            // Acesta este motivul utilizarii operatorului +=
            btnAdauga.Click += OnButtonClicked;
            this.Controls.Add(btnAdauga);

            this.FormClosed += OnFormClosed;
        }
        private void OnButtonClicked(object sender, EventArgs e)
        {
            // obiectul *sender* este butonul btnCalculeaza
            // *e* reprezinta o lista de valori care se transmit la invocarea evenimentului Click al clasei Button
            // catre subscriber-ul curent care este forma FormularGeometrie 
            int valid = 0;
            if (string.IsNullOrWhiteSpace(txtVarsta.Text))
            {
                lblAdaugaVarsta.ForeColor = Color.Red;
                this.Controls.Add(lblAdaugaVarsta);
                valid = 1;
            }else if (Convert.ToInt32(txtVarsta.Text) < 10 || Convert.ToInt32(txtVarsta.Text) > 100)
                {
                    lblAdaugaVarsta.ForeColor = Color.Red;
                    this.Controls.Add(lblAdaugaVarsta);
                    valid = 1;
                }
            if (string.IsNullOrWhiteSpace(txtStatut.Text))
            {
                lblAdaugaStatut.ForeColor = Color.Red;
                this.Controls.Add(lblAdaugaStatut);
                valid = 1;
            }
            else if (txtStatut.Text.ToUpper() != "ELEV" && txtStatut.Text.ToUpper() != "STUDENT" && txtStatut.Text.ToUpper() != "ANGAJAT" && txtStatut.Text.ToUpper() != "SOMER" && txtStatut.Text.ToUpper() != "PENSIONAR")
            {
                lblAdaugaStatut.ForeColor = Color.Red;
                this.Controls.Add(lblAdaugaStatut);
                valid = 1;
            }
            if (string.IsNullOrWhiteSpace(txtNume_Prenume.Text))
            {
                lblAdaugaNume_Prenume.ForeColor = Color.Red;
                this.Controls.Add(lblAdaugaNume_Prenume);
                valid = 1;
            }


            if (valid == 0)
            {
                lblAdaugaNume_Prenume.ForeColor = Color.Blue;
                this.Controls.Add(lblAdaugaNume_Prenume);
                lblAdaugaStatut.ForeColor = Color.Blue;
                this.Controls.Add(lblAdaugaStatut);
                lblAdaugaVarsta.ForeColor = Color.Blue;
                this.Controls.Add(lblAdaugaVarsta);
                Client client = new Client(adminClienti.GetLastId(),txtNume_Prenume.Text, Convert.ToInt32(txtVarsta.Text));
                client.statut = (Statut)Enum.Parse(typeof(Statut), txtStatut.Text);
                adminClienti.AddClient(client);
                AfiseazaClienti();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            AfiseazaClienti();
        }

        private void AfiseazaClienti()
        {
            Client[] clienti = adminClienti.GetClienti(out int nrClienti);

            lblsNume_Prenume = new Label[nrClienti];
            lblsVarsta = new Label[nrClienti];
            lblsStatut = new Label[nrClienti];

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
    }
}
