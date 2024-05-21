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
    public partial class FormCautaRestaurant : Form
    {
        IStocareDataRestaurante adminRestaurante;
        public FormCautaRestaurant()
        {
            InitializeComponent();
            adminRestaurante = StocareFactory.GetAdministratorStocare();
            foreach (Restaurant restaurant in adminRestaurante.GetRestaurante())
            {
                cmbDenumire.Items.Add(restaurant.denumire);
                cmbAn.Items.Add(restaurant.an_fondator.ToString());
            }
            rdbTraditional.Hide();
            rdbElegant.Hide();
            rdbFastFood.Hide();
            rdbChinezesc.Hide();
            rdbIndian.Hide();
        }

        private void OnBtnCautaClicked(object sender, EventArgs e)
        {
            if (adminRestaurante.GetRestaurant(cmbDenumire.Text, Convert.ToInt32(cmbAn.Text)) == null)
            {
                lblCauta.Text = "Restaurant INEXISTENT";
                lblCauta.ForeColor = Color.Red;
                this.Controls.Add(lblCauta);
                rdbTraditional.Hide();
                rdbElegant.Hide();
                rdbFastFood.Hide();
                rdbChinezesc.Hide();
                rdbIndian.Hide();
            }
            else
            {
                Restaurant r = adminRestaurante.GetRestaurant(cmbDenumire.Text, Convert.ToInt32(cmbAn.Text));
                if (r.specific.ToString() == rdbTraditional.Text)
                {
                    rdbTraditional.Show();
                    rdbElegant.Hide();
                    rdbFastFood.Hide();
                    rdbChinezesc.Hide();
                    rdbIndian.Hide();
                    rdbTraditional.Checked = true;
                }
                if (r.specific.ToString() == rdbElegant.Text)
                {
                    rdbTraditional.Hide();
                    rdbElegant.Show();
                    rdbFastFood.Hide();
                    rdbChinezesc.Hide();
                    rdbIndian.Hide();
                    rdbElegant.Checked = true;
                }
                if (r.specific.ToString() == rdbFastFood.Text)
                {
                    rdbTraditional.Hide();
                    rdbElegant.Hide();
                    rdbFastFood.Show();
                    rdbChinezesc.Hide();
                    rdbIndian.Hide();
                    rdbFastFood.Checked = true;
                }
                if (r.specific.ToString() == rdbChinezesc.Text)
                {
                    rdbTraditional.Hide();
                    rdbElegant.Hide();
                    rdbFastFood.Hide();
                    rdbChinezesc.Show();
                    rdbIndian.Hide();
                    rdbChinezesc.Checked = true;
                }
                if (r.specific.ToString() == rdbIndian.Text)
                {
                    rdbTraditional.Hide();
                    rdbElegant.Hide();
                    rdbFastFood.Hide();
                    rdbChinezesc.Hide();
                    rdbIndian.Show();
                    rdbIndian.Checked = true;
                }
                lblCauta.Text = "Restaurantul a fost gasit!!!";
                lblCauta.ForeColor = Color.Green;
            }
        }
        private void FormCautaClient_Load(object sender, EventArgs e)
        {

        }
    }
}
