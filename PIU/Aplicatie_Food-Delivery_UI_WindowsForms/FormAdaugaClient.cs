using LibrarieModele;
using LibrarieModele.Enumerari;
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

namespace Aplicatie_Food_Delivery_UI_WindowsForms
{
    public partial class FormAdaugaClient : Form
    {
        IStocareDataClienti adminClienti;
        public FormAdaugaClient()
        {
            InitializeComponent();
            adminClienti = StocareFactory.GetAdministratorStocare2();
            this.FormClosed += OnFormClosed;
        }
        private void OnFormClosed(object sender, EventArgs e)
        {
            this.Close();
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
            
                Client clientCuAcelasiNume = adminClienti.GetClient(nume, varsta);
                if (clientCuAcelasiNume != null)
                {
                    valid = false;
                    lblEroareExistent.Text = "Clientul exista deja!!!";
                    lblEroareExistent.ForeColor = Color.Red;
                }
            
            return valid;
        }
        private void OnAdaugaClicked(object sender, EventArgs e)
        {
           if(DateIntrareValide() != true)
            {
                return;
            }

            Client c = new Client(txtNume.Text, Convert.ToInt32(txtVarsta.Text));
            c.statut = GetProgramStudiuSelectat();
            adminClienti.AddClient(c);
            lblEroareExistent.Text = "Studentul a fost adaugat cu succes!!!";
            lblEroareExistent.ForeColor = Color.Green;
            ResetareControale();

        }

        private void ResetareControale()
        {
            txtNume.Text = txtVarsta.Text = string.Empty;

            rdbAngajat.Checked = false;
            rdbElev.Checked = false;
            rdbPensionar.Checked = false;
            rdbSomer.Checked = false;
            rdbStudent.Checked = false;
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

        private void lblAdaugaCLient_Click(object sender, EventArgs e)
        {

        }
    }
}
