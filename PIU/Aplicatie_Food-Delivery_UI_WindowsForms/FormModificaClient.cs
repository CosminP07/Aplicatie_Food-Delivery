using LibrarieModele;
using NivelStocareDate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Aplicatie_Food_Delivery_UI_WindowsForms
{
    public partial class FormModificaClient : Form
    {
        IStocareDataClienti adminClienti;
        public FormModificaClient(Client client)
        {
            InitializeComponent();
            adminClienti = StocareFactory.GetAdministratorStocare2();
            Client c = client;
            lblId.Text = client.Id_Client.ToString();
            int id = c.Id_Client;
            txtNume.Text = c.nume_prenume;
            txtVarsta.Text = c.varsta.ToString();
            if(rdbAngajat.Text == c.statut.ToString())
            {
                rdbAngajat.Checked = true;
            }
            if(rdbElev.Text == c.statut.ToString()) {  rdbElev.Checked = true; }
            if(rdbPensionar.Text == c.statut.ToString()) { rdbPensionar.Checked = true; }
            if(rdbSomer.Text == c.statut.ToString()) { rdbSomer.Checked = true; }
            if(rdbStudent.Text == c.statut.ToString()) { rdbStudent.Checked = true; }
            this.FormClosed += OnFormClosed;
        }
        private bool DateIntrareValide()
        {
            bool valid = true;
            string nume = txtNume.Text;


            int varsta = Convert.ToInt32(txtVarsta.Text);


            if (txtNume.Text == string.Empty)
            {
                lblEroareNume.Text = "Introduceti un nume si prenume!!!";
                lblEroareNume.ForeColor = Color.Red;
                valid = false;
            }
            if (txtVarsta.Text == string.Empty)
            {
                lblEroareVarsta.Text = "Introduceti o varsta!!!";
                lblEroareVarsta.ForeColor = Color.Red;
                valid = false;
            }
            if (rdbAngajat.Checked == false && rdbElev.Checked == false && rdbPensionar.Checked == false && rdbSomer.Checked == false && rdbStudent.Checked == false)
            {
                lblEroareStatut.Text = "Alegeti un statut!!!";
                lblEroareStatut.ForeColor = Color.Red;
                valid = false;
            }

            return valid;
        }

        private LibrarieModele.Enumerari.Statut GetProgramStudiuSelectat()
        {
            if (rdbElev.Checked)
                return LibrarieModele.Enumerari.Statut.Elev;
            if (rdbStudent.Checked)
                return LibrarieModele.Enumerari.Statut.Student;
            if (rdbAngajat.Checked)
                return LibrarieModele.Enumerari.Statut.Angajat;
            if (rdbSomer.Checked)
                return LibrarieModele.Enumerari.Statut.Somer;
            if (rdbPensionar.Checked)
                return LibrarieModele.Enumerari.Statut.Pensionar;

            throw new Exception("Statut neales!");
        }
        private void btnModificaClicked(object sender, EventArgs e)
        {
            if (DateIntrareValide() != true)
            {
                return;
            }
            Client c = new Client(Convert.ToInt32(lblId.Text), txtNume.Text, Convert.ToInt32(txtVarsta.Text));
            c.statut = GetProgramStudiuSelectat();
            if (adminClienti.UpdateClient(c) == true)
            {
                lblModifica.Text = "Modificarea a avut loc cu succes!";
                lblModifica.ForeColor = System.Drawing.Color.Green;
                this.Controls.Add(lblModifica);
            }
            else
            {
                lblModifica.Text = "EROARE!";
                lblModifica.ForeColor = Color.Red;
                this.Controls.Add(lblModifica);
            }

        }
        private void OnFormClosed(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
