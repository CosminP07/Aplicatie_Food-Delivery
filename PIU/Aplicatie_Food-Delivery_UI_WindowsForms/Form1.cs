using System;
using LibrarieModele;
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

        private Label[] lblsNume_Prenume;
        private Label[] lblsVarsta;
        private Label[] lblsStatut;

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
    }
}
