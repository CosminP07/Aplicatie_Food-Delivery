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
    public partial class FormAdaugaRestaurant : Form
    {
        IStocareDataRestaurante adminRestaurante;
        public FormAdaugaRestaurant()
        {
            InitializeComponent();
            adminRestaurante = StocareFactory.GetAdministratorStocare();
            this.FormClosed += OnFormClosed;
        }
        private void OnFormClosed(object sender, EventArgs e)
        {
            this.Close();
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
            if (rdbFastFood.Checked == false && rdbTraditional.Checked == false && rdbIndian.Checked == false && rdbChinezesc.Checked == false && rdbElegant.Checked == false)
            {
                lblEroareStatut.Text = "Alegeti un specific!!!";
                lblEroareStatut.ForeColor = Color.Red;
                valid = false;
            }
            if (valid)
            {
                Restaurant restaurantCuAcelasiNume = adminRestaurante.GetRestaurant(denumire, an);
                if (restaurantCuAcelasiNume != null)
                {
                    valid = false;
                    lblEroareExistent.Text = "Restaurantul exista deja!!!";
                    lblEroareExistent.ForeColor = Color.Red;
                }
            }

            return valid;
        }
        private void OnAdaugaClicked(object sender, EventArgs e)
        {
            if (DateIntrareValide() != true)
            {
                return;
            }

            Restaurant r = new Restaurant(txtDenumire.Text, Convert.ToInt32(txtAn.Text));
            r.specific = GetSpecificSelectat();
            adminRestaurante.AddRestaurant(r);
            lblEroareExistent.Text = "Restaurantul a fost adaugat cu succes!!!";
            lblEroareExistent.ForeColor = Color.Green;
            ResetareControale();

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

        private void lblAdaugaCLient_Click(object sender, EventArgs e)
        {

        }
    }
}
