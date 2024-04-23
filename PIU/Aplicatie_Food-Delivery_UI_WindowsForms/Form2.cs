using LibrarieModele;
using NivelStocareDate;
using System;
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
    public partial class Form2 : Form
    {
        AdministrareRestaurante_Fisier adminRestaurante;

        private Label lblDenumire;
        private Label lblAn;
        private Label lblSpecific;

        private Label[] lblsDenumire;
        private Label[] lblsAn;
        private Label[] lblsSpecific;

        private const int LATIME_CONTROL = 100;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 120;
        public Form2()
        {
            InitializeComponent2();
            string numeFisier = ConfigurationManager.AppSettings["NumeFisierR"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            // setare locatie fisier in directorul corespunzator solutiei
            // astfel incat datele din fisier sa poata fi utilizate si de alte proiecte
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            adminRestaurante = new AdministrareRestaurante_Fisier(caleCompletaFisier);
            int nrRestaurante = 0;

            Restaurant[] restaurante = adminRestaurante.GetRestaurante(out nrRestaurante);

            //setare proprietati
            this.Size = new Size(500, 200);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(440, 290);
            this.Font = new Font("Calibri", 12, FontStyle.Bold);
            this.ForeColor = Color.Cyan;
            this.BackColor = Color.DarkMagenta;
            this.Text = "Informatii restaurante";

            //adaugare control de tip Label pentru 'Denumire';
            lblDenumire = new Label();
            lblDenumire.Width = LATIME_CONTROL * 2;
            lblDenumire.Text = "Denumire";
            lblDenumire.Left = 0;
            lblDenumire.ForeColor = Color.Yellow;
            this.Controls.Add(lblDenumire);

            //adaugare control de tip Label pentru "Varsta";
            lblAn = new Label();
            lblAn.Width = LATIME_CONTROL;
            lblAn.Text = "An fondator";
            lblAn.Left = 2 * DIMENSIUNE_PAS_X;
            lblAn.ForeColor = Color.Yellow;
            this.Controls.Add(lblAn);

            //adaugare control de tip Label pentru 'Note';
            lblSpecific = new Label();
            lblSpecific.Width = LATIME_CONTROL;
            lblSpecific.Text = "Specific";
            lblSpecific.Left = 3 * DIMENSIUNE_PAS_X;
            lblSpecific.ForeColor = Color.Yellow;
            this.Controls.Add(lblSpecific);
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            AfiseazaRestaurante();
        }

        private void AfiseazaRestaurante()
        {
            Restaurant[] restaurante = adminRestaurante.GetRestaurante(out int nrRestaurante);

            lblsDenumire = new Label[nrRestaurante];
            lblsAn = new Label[nrRestaurante];
            lblsSpecific = new Label[nrRestaurante];

            int i = 0;
            foreach (Restaurant restaurant in restaurante)
            {
                //adaugare control de tip Label pentru numele si prenumele studentilor;
                lblsDenumire[i] = new Label();
                lblsDenumire[i].Width = LATIME_CONTROL * 2;
                lblsDenumire[i].Text = restaurant.denumire;
                lblsDenumire[i].Left = 0;
                lblsDenumire[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsDenumire[i]);

                //adaugare control de tip Label pentru varsta clientilor
                lblsAn[i] = new Label();
                lblsAn[i].Width = LATIME_CONTROL;
                lblsAn[i].Text = Convert.ToString(restaurant.an_fondator);
                lblsAn[i].Left = 2 * DIMENSIUNE_PAS_X;
                lblsAn[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsAn[i]);

                //adaugare control de tip Label pentru notele studentilor
                lblsSpecific[i] = new Label();
                lblsSpecific[i].Width = LATIME_CONTROL;
                lblsSpecific[i].Text = Convert.ToString(restaurant.specific);
                lblsSpecific[i].Left = 3 * DIMENSIUNE_PAS_X;
                lblsSpecific[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsSpecific[i]);
                i++;
            }
        }
    }
}
