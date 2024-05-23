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
using LibrarieModele;

namespace Aplicatie_Food_Delivery_UI_WindowsForms
{
    public partial class FormCautaClient : Form
    {
        IStocareDataClienti adminClienti;
        public FormCautaClient()
        {
            InitializeComponent();
            adminClienti = StocareFactory.GetAdministratorStocare2();
            foreach( Client client in adminClienti.GetClienti()){
                cmbNume.Items.Add(client.nume_prenume);
                cmbVarsta.Items.Add(client.varsta.ToString());
            }
            rdbAngajat.Hide();
            rdbElev.Hide();
            rdbPensionar.Hide();
            rdbSomer.Hide();
            rdbStudent.Hide();
        }

        private void OnBtnCautaClicked(object sender, EventArgs e)
        {
            if (adminClienti.GetClient(cmbNume.Text, Convert.ToInt32(cmbVarsta.Text)) == null)
            {
                lblCauta.Text = "CLIENT INEXISTENT";
                lblCauta.ForeColor = Color.Red;
                this.Controls.Add(lblCauta);
                rdbAngajat.Hide();
                rdbElev.Hide();
                rdbPensionar.Hide();
                rdbSomer.Hide();
                rdbStudent.Hide();
            }
            else
            {
                Client s = adminClienti.GetClient(cmbNume.Text, Convert.ToInt32(cmbVarsta.Text));
                if (s.statut.ToString() == rdbElev.Text)
                {
                    rdbAngajat.Hide();
                    rdbElev.Show();
                    rdbPensionar.Hide();
                    rdbSomer.Hide();
                    rdbStudent.Hide();
                    rdbElev.Checked = true;
                }
                if (s.statut.ToString() == rdbStudent.Text)
                {
                    rdbStudent.Show();
                    rdbAngajat.Hide();
                    rdbElev.Hide();
                    rdbPensionar.Hide();
                    rdbSomer.Hide();
                    rdbStudent.Checked = true;
                }
                if (s.statut.ToString() == rdbAngajat.Text)
                {
                    rdbAngajat.Show();
                    rdbElev.Hide();
                    rdbPensionar.Hide();
                    rdbSomer.Hide();
                    rdbStudent.Hide();
                    rdbAngajat.Checked = true;
                }
                if (s.statut.ToString() == rdbSomer.Text)
                {
                    rdbSomer.Show();
                    rdbAngajat.Hide();
                    rdbElev.Hide();
                    rdbPensionar.Hide();
                    rdbStudent.Hide();
                    rdbSomer.Checked = true;
                }
                if (s.statut.ToString() == rdbPensionar.Text)
                {
                    rdbPensionar.Show();
                    rdbAngajat.Hide();
                    rdbElev.Hide();
                    rdbSomer.Hide();
                    rdbStudent.Hide();
                    rdbPensionar.Checked = true;
                }
                lblCauta.Text = "Clientul a fost gasit!!!";
                lblCauta.ForeColor = Color.Green;
            }
        }
        private void FormCautaClient_Load(object sender, EventArgs e)
        {

        }
    }
}
