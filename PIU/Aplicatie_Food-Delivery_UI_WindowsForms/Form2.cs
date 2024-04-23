using LibrarieModele;
using LibrarieModele.Enumerari;
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

        private Label lblAdaugaDenumire;
        private Label lblAdaugaAn;
        private Label lblAdaugaSpecific;

        private Label[] lblsDenumire;
        private Label[] lblsAn;
        private Label[] lblsSpecific;

        private Button btnAdauga;

        private TextBox txtDenumire;
        private TextBox txtAn;
        private TextBox txtSpecific;

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

            lblAdaugaDenumire = new Label();
            lblAdaugaDenumire.Width = LATIME_CONTROL * 2;
            lblAdaugaDenumire.Text = "Denumire:";
            lblAdaugaDenumire.Left = 4 * DIMENSIUNE_PAS_X;
            lblAdaugaDenumire.ForeColor = Color.DarkSeaGreen;
            this.Controls.Add(lblAdaugaDenumire);

            txtDenumire = new TextBox();
            txtDenumire.Width = LATIME_CONTROL * 2;
            txtDenumire.Left = 4 * DIMENSIUNE_PAS_X;
            txtDenumire.Top = DIMENSIUNE_PAS_Y;
            this.Controls.Add(txtDenumire);

            lblAdaugaAn = new Label();
            lblAdaugaAn.Width = LATIME_CONTROL;
            lblAdaugaAn.Text = "An fondator:";
            lblAdaugaAn.Left = 4 * DIMENSIUNE_PAS_X;
            lblAdaugaAn.Top = 2 * DIMENSIUNE_PAS_Y;
            lblAdaugaAn.ForeColor = Color.DarkSeaGreen;
            this.Controls.Add(lblAdaugaAn);

            txtAn = new TextBox();
            txtAn.Width = LATIME_CONTROL;
            txtAn.Left = 4 * DIMENSIUNE_PAS_X;
            txtAn.Top = 3 * DIMENSIUNE_PAS_Y;
            this.Controls.Add(txtAn);

            lblAdaugaSpecific = new Label();
            lblAdaugaSpecific.Width = LATIME_CONTROL;
            lblAdaugaSpecific.Text = "Specific:";
            lblAdaugaSpecific.Left = 4 * DIMENSIUNE_PAS_X;
            lblAdaugaSpecific.Top = 4 * DIMENSIUNE_PAS_Y;
            lblAdaugaSpecific.ForeColor = Color.DarkSeaGreen;
            this.Controls.Add(lblAdaugaSpecific);

            txtSpecific = new TextBox();
            txtSpecific.Width = LATIME_CONTROL;
            txtSpecific.Left = 4 * DIMENSIUNE_PAS_X;
            txtSpecific.Top = 5 * DIMENSIUNE_PAS_Y;
            this.Controls.Add(txtSpecific);

            btnAdauga = new Button();
            btnAdauga.Width = LATIME_CONTROL;
            btnAdauga.Location = new System.Drawing.Point(4 * DIMENSIUNE_PAS_X, 6 * DIMENSIUNE_PAS_Y);
            btnAdauga.Text = "Adauga";
            // "Click" este un *event* in clasa Button
            // si poate avea atasat unul sau mai multe handlere de eveniment (adrese de functii)
            // Acesta este motivul utilizarii operatorului +=
            btnAdauga.Click += OnButtonClicked1;
            this.Controls.Add(btnAdauga);

            this.FormClosed += OnFormClosed;
        }

        private void OnButtonClicked1(object sender, EventArgs e)
        {
            // obiectul *sender* este butonul btnCalculeaza
            // *e* reprezinta o lista de valori care se transmit la invocarea evenimentului Click al clasei Button
            // catre subscriber-ul curent care este forma FormularGeometrie 
            int valid = 0;
            if (string.IsNullOrWhiteSpace(txtAn.Text))
            {
                lblAdaugaAn.ForeColor = Color.Red;
                this.Controls.Add(lblAdaugaAn);
                valid = 1;
            }
            else if (Convert.ToInt32(txtAn.Text) < 1800 || Convert.ToInt32(txtAn.Text) > 2024)
            {
                lblAdaugaAn.ForeColor = Color.Red;
                this.Controls.Add(lblAdaugaAn);
                valid = 1;
            }
            if (string.IsNullOrWhiteSpace(txtSpecific.Text))
            {
                lblAdaugaSpecific.ForeColor = Color.Red;
                this.Controls.Add(lblAdaugaSpecific);
                valid = 1;
            }
            else if (txtSpecific.Text.ToUpper() != "FASTFOOD" && txtSpecific.Text.ToUpper() != "TRADITIONAL" && txtSpecific.Text.ToUpper() != "CHINEZESC" && txtSpecific.Text.ToUpper() != "INDIAN" && txtSpecific.Text.ToUpper() != "ELEGANT")
            {
                lblAdaugaSpecific.ForeColor = Color.Red;
                this.Controls.Add(lblAdaugaSpecific);
                valid = 1;
            }
            if (string.IsNullOrWhiteSpace(txtDenumire.Text))
            {
                lblAdaugaDenumire.ForeColor = Color.Red;
                this.Controls.Add(lblAdaugaDenumire);
                valid = 1;
            }


            if (valid == 0)
            {
                lblAdaugaDenumire.ForeColor = Color.Blue;
                this.Controls.Add(lblAdaugaDenumire);
                lblAdaugaSpecific.ForeColor = Color.Blue;
                this.Controls.Add(lblAdaugaSpecific);
                lblAdaugaAn.ForeColor = Color.Blue;
                this.Controls.Add(lblAdaugaAn);
                Restaurant restaurant = new Restaurant(adminRestaurante.GetLastId(), txtDenumire.Text, Convert.ToInt32(txtAn.Text));
                restaurant.specific = (Specific)Enum.Parse(typeof(Specific), txtSpecific.Text);
                adminRestaurante.AddRestaurant(restaurant);
                AfiseazaRestaurante();
            }
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
        private void OnFormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
