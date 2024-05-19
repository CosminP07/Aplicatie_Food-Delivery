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
    public partial class FormMeniu : Form
    {
        public FormMeniu()
        {
            InitializeComponent();
        }
        private void OnRestaurantClicked(object sender, EventArgs e)
        {
            this.Hide();
            var formRestaurante = new Form2();
            formRestaurante.Closed += (s, args) => this.Close();
            formRestaurante.Show();
        }

        private void OnClientiClicked(object sender, EventArgs e)
        {
            this.Hide();
            var formClienti = new Form1();
            formClienti.Closed += (s, args) => this.Close();
            formClienti.Show();
        }
        private void OnFormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

   
