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
    public partial class FormModificaRestaurant : Form
    {
        IStocareDataRestaurante adminRestaurante;
        public FormModificaRestaurant(Restaurant restaurant)
        {
            InitializeComponent();
            adminRestaurante = StocareFactory.GetAdministratorStocare();
            Restaurant r = restaurant;
            lblId.Text = restaurant.Id_Restaurant.ToString();
            int id = r.Id_Restaurant;
            txtDenumire.Text = r.denumire;
            txtAn.Text = r.an_fondator.ToString();
            if (rdbTraditional.Text == r.specific.ToString())
            {
                rdbTraditional.Checked = true;
            }
            if (rdbElegant.Text == r.specific.ToString()) { rdbElegant.Checked = true; }
            if (rdbFastFood.Text == r.specific.ToString()) { rdbFastFood.Checked = true; }
            if (rdbChinezesc.Text == r.specific.ToString()) { rdbChinezesc.Checked = true; }
            if (rdbIndian.Text == r.specific.ToString()) { rdbIndian.Checked = true; }
            this.FormClosed += OnFormClosed;
        }
        private bool DateIntrareValide()
        {
            bool valid = true;
            string denumire = txtDenumire.Text;


            int an = Convert.ToInt32(txtAn.Text);


            if (txtDenumire.Text == string.Empty)
            {
                lblEroareNume.Text = "Introduceti o denumire!!!";
                lblEroareNume.ForeColor = Color.Red;
                valid = false;
            }
            if (txtAn.Text == string.Empty)
            {
                lblEroareVarsta.Text = "Introduceti un an fondator!!!";
                lblEroareVarsta.ForeColor = Color.Red;
                valid = false;
            }
            if (rdbTraditional.Checked == false && rdbElegant.Checked == false && rdbFastFood.Checked == false && rdbChinezesc.Checked == false && rdbIndian.Checked == false)
            {
                lblEroareStatut.Text = "Alegeti un specific!!!";
                lblEroareStatut.ForeColor = Color.Red;
                valid = false;
            }

            return valid;
        }

        private void ResetareControale()
        {
            txtDenumire.Text = txtAn.Text = string.Empty;

            rdbFastFood.Checked = false;
            rdbTraditional.Checked = false;
            rdbIndian.Checked = false;
            rdbChinezesc.Checked = false;
            rdbElegant.Checked = false;
        }

        private LibrarieModele.Enumerari.Specific GetSpecificSelectat()
        {
            if (rdbTraditional.Checked)
                return LibrarieModele.Enumerari.Specific.Traditional;
            if (rdbElegant.Checked)
                return LibrarieModele.Enumerari.Specific.Elegant;
            if (rdbFastFood.Checked)
                return LibrarieModele.Enumerari.Specific.FastFood;
            if (rdbChinezesc.Checked)
                return LibrarieModele.Enumerari.Specific.Chinezesc;
            if (rdbIndian.Checked)
                return LibrarieModele.Enumerari.Specific.Indian;

            throw new Exception("Specific neales!");
        }
        private void btnModificaClicked(object sender, EventArgs e)
        {
            if (DateIntrareValide() != true)
            {
                return;
            }
            Restaurant r = new Restaurant(Convert.ToInt32(lblId.Text), txtDenumire.Text, Convert.ToInt32(txtAn.Text));
            r.specific = GetSpecificSelectat();
            if (adminRestaurante.UpdateRestaurant(r) == true)
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
