using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;

namespace NivelStocareDate
{
    public class AdministrareClienti_Fisier
    {
        private const int NR_MAX_CLIENTI = 50;
        private string numeFisier;

        public AdministrareClienti_Fisier(string numeFisier)
        {
            this.numeFisier = numeFisier;
            // se incearca deschiderea fisierului in modul OpenOrCreate
            // astfel incat sa fie creat daca nu exista
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AddClient(Client client)
        {
            // instructiunea 'using' va apela la final streamWriterFisierText.Close();
            // al doilea parametru setat la 'true' al constructorului StreamWriter indica
            // modul 'append' de deschidere al fisierului
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(client.ConversieLaSir_PentruFisier());
            }
        }

        public Client[] GetClienti(out int nrClienti)
        {
            Client[] clienti = new Client[NR_MAX_CLIENTI];

            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                nrClienti = 0;

                // citeste cate o linie si creaza un obiect de tip Client
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    clienti[nrClienti++] = new Client(linieFisier);
                }
            }

            return clienti;
        }
        public int GetLastId()
        {
            int lastID = 0;
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier; 
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    lastID++;
                }
            }
            return lastID;
        }

        /*public void ClientiAlfabet()
        {
            string[][] sir = new string[26][];
            Client[] clienti = new Client[NR_MAX_CLIENTI];
            int[] contor = new int[26];

            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                int nrClienti = 0;

                // citeste cate o linie si creaza un obiect de tip Client
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    clienti[nrClienti++] = new Client(linieFisier);
                    for(int i=0; i<26; i++)
                    {
                        //sir[i] = new string[NR_MAX_CLIENTI];
                        if (clienti[nrClienti - 1].nume_prenume[0] == (i+65))
                        {
                            sir[i][contor[i]] = clienti[nrClienti - 1].nume_prenume;
                            contor[i]++;
                        }
                    }
                }
            }
            for (int i = 65; i < 91; i++)
            {
                for (int j = 0; j < NR_MAX_CLIENTI; j++)
                    Console.Write("{0} ", sir[i][j]);
                Console.WriteLine();
            }
        }*/
        public static void CautareClientNume(Client[] clienti, int nrClienti)
        {
            Console.WriteLine("\nIntroduceti numele clientului cautat: ");
            string nume1 = Console.ReadLine();
            int valid = 0;
            //Client[] clienti1 = adminClienti.GetClienti(out nrClienti1);
            for (int contor = 0; contor < nrClienti; contor++)
            {
                if (nume1 == clienti[contor].nume_prenume)
                {
                    Console.WriteLine($"Clientul cu numele {clienti[contor].nume_prenume} a fost gasit si are varsta de {clienti[contor].varsta} ani");
                    valid = 1;
                }
            }
            if(valid == 0)
                Console.WriteLine($"Clientul cu numele {nume1} nu a fost gasit !!!");
        }
        public static void CautareClientVarsta(Client[] clienti, int nrClienti)
        {
            Console.WriteLine("\nIntroduceti varsta clientului cautat: ");
            int varsta1 = Int32.Parse(Console.ReadLine());
            int valid = 0;
            //Client[] clienti1 = adminClienti.GetClienti(out nrClienti1);
            for (int contor = 0; contor < nrClienti; contor++)
            {
                if (varsta1 == clienti[contor].varsta)
                {
                    Console.WriteLine($"Clientul cu varsta de {clienti[contor].varsta} ani a fost gasit si se numeste {clienti[contor].nume_prenume}");
                    valid = 1;
                }
            }
            if(valid == 0)
                Console.WriteLine($"Clientul cu varsta de {varsta1} ani nu a fost gasit !!!");
        }
        public static void ClientiAlfabet(Client[] clienti, int nrClienti)
        {
            string[][] sir = new string[26][];
            int[] contor = new int[26];
            int curent;


            // citeste cate o linie si creaza un obiect de tip Client
            // pe baza datelor din linia citita
            for (curent = 0; curent < nrClienti; curent++)
            {
                for (int i = 0; i < 26; i++)
                {
                    sir[i] = new string[nrClienti];
                    if (clienti[curent].nume_prenume[0] == (i + 65))
                    {
                        sir[i][contor[i]] = clienti[curent].nume_prenume;
                        contor[i] += 1;
                    }
                }
            }

            for (int i = 0; i < 26; i++)
            {
                for (int j = 0; j < sir[i].Length; j++)
                    Console.Write("{0} ", sir[i][j]);
                Console.WriteLine();
            }
        }
    }
}
