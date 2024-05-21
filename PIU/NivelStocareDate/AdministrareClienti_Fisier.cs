using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;

namespace NivelStocareDate
{
    public class AdministrareClienti_Fisier : IStocareDataClienti
    {
        private const int ID_PRIMUL_RESTAURANT = 1;
        private const int INCREMENT = 1;
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
            client.Id_Client = GetId();
            // instructiunea 'using' va apela la final streamWriterFisierText.Close();
            // al doilea parametru setat la 'true' al constructorului StreamWriter indica
            // modul 'append' de deschidere al fisierului
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(client.ConversieLaSir_PentruFisier());
            }
        }

        public List<Client> GetClienti()
        {
            List<Client> clienti = new List<Client>();

            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;

                // citeste cate o linie si creaza un obiect de tip Client
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    clienti.Add(new Client(linieFisier));
                }
            }

            return clienti;
        }
        /*public int GetLastId()
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
        }*/

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

        public Client GetClient(string nume_prenume, int varsta)
        {
            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;

                // citeste cate o linie si creaza un obiect de tip Student
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Client client = new Client(linieFisier);
                    if (client.nume_prenume.Equals(nume_prenume) && client.varsta.Equals(varsta))
                        return client;
                }
            }

            return null;
        }

        public Client GetClient(int idClient)
        {
            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;

                // citeste cate o linie si creaza un obiect de tip Student
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Client client = new Client(linieFisier);
                    if (client.Id_Client == idClient)
                        return client;
                }
            }

            return null;
        }


        public bool UpdateClient(Client ClientActualizat)
        {
            List<Client> clienti = GetClienti();
            bool actualizareCuSucces = false;

            //instructiunea 'using' va apela la final swFisierText.Close();
            //al doilea parametru setat la 'false' al constructorului StreamWriter indica modul 'overwrite' de deschidere al fisierului
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, false))
            {
                foreach (Client client in clienti)
                {
                    Client clientPentruScrisInFisier = client;
                    //informatiile despre studentul actualizat vor fi preluate din parametrul "studentActualizat"
                    if (client.Id_Client == ClientActualizat.Id_Client)
                    {
                        clientPentruScrisInFisier = ClientActualizat;
                    }
                    streamWriterFisierText.WriteLine(clientPentruScrisInFisier.ConversieLaSir_PentruFisier());
                }
                actualizareCuSucces = true;
            }

            return actualizareCuSucces;
        }
        public void CautareClientNume(List<Client> clienti)
        {
            Console.WriteLine("\nIntroduceti numele clientului cautat: ");
            string nume1 = Console.ReadLine();
            int valid = 0;
            //Client[] clienti1 = adminClienti.GetClienti(out nrClienti1);
            for (int contor = 0; contor < clienti.Count; contor++)
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
        public void CautareClientVarsta(List<Client> clienti)
        {
            Console.WriteLine("\nIntroduceti varsta clientului cautat: ");
            int varsta1 = Int32.Parse(Console.ReadLine());
            int valid = 0;
            //Client[] clienti1 = adminClienti.GetClienti(out nrClienti1);
            for (int contor = 0; contor < clienti.Count; contor++)
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
        public List<Client> ClientiAlfabet(List<Client> clienti)
        {
            List<Client> c = clienti;
            c.Sort();
            return c;
        }
        public int GetId()
        {
            int IdClient = ID_PRIMUL_RESTAURANT;

            // instructiunea 'using' va apela sr.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;

                //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Client client = new Client(linieFisier);
                    IdClient = client.Id_Client + INCREMENT;
                }
            }

            return IdClient;
        }
        public Client GetClientByIndex(int index)
        {
            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader(numeFisier))
                {
                    string line;
                    //citeste cate o linie si creaza un obiect de tip Carte pe baza datelor din linia citita
                    while ((line = sr.ReadLine()) != null)
                    {
                        Client client = new Client(line);
                        if (client.Id_Client == index)
                            return client;
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
            return null;
        }
        public bool StergeClient(Client client)
        {
            List<Client> clienti = GetClienti();
            bool actualizareCuSucces = false;
            try
            {
                //instructiunea 'using' va apela la final swFisierText.Close();
                //al doilea parametru setat la 'false' al constructorului StreamWriter indica modul 'overwrite' de deschidere al fisierului
                using (StreamWriter swFisierText = new StreamWriter(numeFisier, false))
                {
                    foreach (Client c in clienti)
                    {
                        if (c.Id_Client != client.Id_Client)
                        {
                            swFisierText.WriteLine(c.ConversieLaSir_PentruFisier());
                        }
                    }
                    actualizareCuSucces = true;
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return actualizareCuSucces;
        }
    }
}
