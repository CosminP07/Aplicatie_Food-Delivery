using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Design.Serialization;
using System.Net.Sockets;
using LibrarieModele.Enumerari;

namespace LibrarieModele
{
    [Serializable]
    public class Restaurant
    {
        public string denumire { get; set; }
        public int an_fondator { get; set; }
        public int Id_Restaurant { get; set; }

        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const int ID = 0;
        private const int DEN = 1;
        private const int AN = 2;
        private const int SPECIFIC = 3;
        private const int CT = 4;

        public Specific specific { get; set; }
        public int clientitinta { get; set; }

        public ClientiTinta[] clientiTintas { get; set; }
        public Restaurant()
        {
            denumire = string.Empty;
            an_fondator = 0;
            Id_Restaurant = 0;
        }
        public Restaurant(string denumire, int an_fondator)
        {
            this.denumire = denumire;
            this.an_fondator = an_fondator;
        }
        public Restaurant(int id, string denumire, int an_fondator)
        {
            this.denumire = denumire;
            this.an_fondator = an_fondator;
            Id_Restaurant = id;
        }
        public string Vechi_Nou()
        {
            if (an_fondator == 0)
            {
                return "Anul restaurantului nu a fost setat!!!";
            }
            if (an_fondator <= 1990)
                return "Restaurantul este vechi!";
            return "Restaurantul este nou pe piata!";
        }
        public Restaurant(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            //ordinea de preluare a campurilor este data de ordinea in care au fost scrise in fisier prin apelul implicit al metodei ConversieLaSir_PentruFisier()
            this.Id_Restaurant = Convert.ToInt32(dateFisier[ID]);
            this.denumire = dateFisier[DEN];
            this.an_fondator = Convert.ToInt32(dateFisier[AN]);
            this.specific = (Specific)Enum.Parse(typeof(Specific), dateFisier[SPECIFIC]);

        }
        public string ConversieLaSir_PentruFisier()
        {
            string obiectRestaurantPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}",
                SEPARATOR_PRINCIPAL_FISIER,
                Id_Restaurant.ToString(),
                (denumire ?? " NECUNOSCUT "),
                (an_fondator.ToString() ?? " NECUNOSCUT "),
                specific);
            /*int rezultat = clientitinta & 0x0001;
            if (rezultat != 0) 
                {
                obiectRestaurantPentruFisier = string.Join(";","Elev");
                }
            rezultat = clientitinta & 0x0010;
            if (rezultat != 0)
            {
                obiectRestaurantPentruFisier = string.Join(";", "Student");
            }
            rezultat = clientitinta & 0x0100;
            if (rezultat != 0)
                obiectRestaurantPentruFisier = string.Join(";", "Angajat");
            rezultat = clientitinta & 0x1000;
            if (rezultat != 0)
                obiectRestaurantPentruFisier = string.Join(";", "Somer");
            rezultat = clientitinta & 0x00010000;
            if (rezultat != 0)
                obiectRestaurantPentruFisier = string.Join(";", "Pensionar");*/
            return obiectRestaurantPentruFisier;
        }
        public string Info()
        {
            if (denumire == string.Empty)
                return "Restaurant nesetat";
            return $"ID: {Id_Restaurant}\nDenumire: {denumire}\n An fondator: {an_fondator}\n Specific: {specific}";
        }
    }
}