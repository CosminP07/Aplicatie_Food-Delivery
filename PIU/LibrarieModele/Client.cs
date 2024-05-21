using LibrarieModele.Enumerari;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieModele
{
    public class Client
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';

        private const int ID = 0;
        private const int NUME = 1;
        private const int VARSTA = 2;
        private const int STATUT = 3;
        public string nume_prenume { set; get; }
        public int varsta { get; set; }
        public int Id_Client { get; set; }

        public Statut statut { get; set; }
        public Client()
        {
            nume_prenume = string.Empty;
            varsta = 0;
            Id_Client = 0;
        }
        public Client(string nume_prenume, int varsta)
        {
            this.nume_prenume = nume_prenume;
            this.varsta = varsta;
        }
        public Client(int id, string nume_prenume, int varsta)
        {
            this.nume_prenume = nume_prenume;
            this.varsta = varsta;
            Id_Client = id;
        }

        public Client(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            //ordinea de preluare a campurilor este data de ordinea in care au fost scrise in fisier prin apelul implicit al metodei ConversieLaSir_PentruFisier()
            this.Id_Client = Convert.ToInt32(dateFisier[ID]);
            this.nume_prenume = dateFisier[NUME];
            this.varsta = Convert.ToInt32(dateFisier[VARSTA]);
            this.statut = (Statut)Enum.Parse(typeof(Statut), dateFisier[STATUT]);
        }
        public string Major()
        {
            if (varsta == 0)
                return "Varsta clientului nu a fost setata!!!";
            if (varsta < 18)
                return "Clientul este major!";
            return "Clientul nu este major!";
        }

        public string ConversieLaSir_PentruFisier()
        {
            string obiectClientPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}",
                SEPARATOR_PRINCIPAL_FISIER,
                Id_Client.ToString(),
                (nume_prenume ?? " NECUNOSCUT "),
                (varsta.ToString() ?? " NECUNOSCUT "),
                statut);
            return obiectClientPentruFisier;
        }
        public string Info()
        {
            if (nume_prenume == string.Empty)
                return "Client nesetat!!!";
            return $"ID: {Id_Client} \nNume si prenume: {nume_prenume},\n Varsta: {varsta}\n Statut: {statut}";
        }
        public override string ToString()
        {
            return Info();
        }
    }
}