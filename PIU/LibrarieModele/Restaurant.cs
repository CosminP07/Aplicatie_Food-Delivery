﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Design.Serialization;
using System.Net.Sockets;
using LibrarieModele.Enumerari;

namespace LibrarieModele
{
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

        public Specific specific { get; set; }
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