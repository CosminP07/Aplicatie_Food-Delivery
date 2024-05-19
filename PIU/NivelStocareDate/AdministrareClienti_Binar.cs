using LibrarieModele;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace NivelStocareDate
{
    public class AdministrareClienti_Binar : IStocareDataClienti
    {
        private const int ID_PRIMUL_CLIENT = 1;
        private const int INCREMENT = 1;

        string NumeFisier { get; set; }
        public AdministrareClienti_Binar(string numeFisier)
        {
            this.NumeFisier = numeFisier;
            Stream sBinFile = File.Open(NumeFisier, FileMode.OpenOrCreate);
            sBinFile.Close();

            //liniile de mai sus pot fi inlocuite cu linia de cod urmatoare deoarece
            //instructiunea 'using' va apela sBinFile.Close();
            //using (Stream sBinFile = File.Open(numeFisier, FileMode.OpenOrCreate)) { }
        }

        public void AddClient(Client c)
        {
            c.Id_Client = GetId();

            try
            {
                BinaryFormatter b = new BinaryFormatter();

                //instructiunea 'using' va apela sBinFile.Close();
                using (Stream sBinFile = File.Open(NumeFisier, FileMode.Append, FileAccess.Write))
                {
                    //serializarea unui obiect
                    b.Serialize(sBinFile, c);
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
        }

        public List<Client> GetClienti()
        {
            List<Client> clienti = new List<Client>();
            try
            {
                BinaryFormatter b = new BinaryFormatter();

                //instructiunea 'using' va apela sBinFile.Close();
                using (Stream sBinFile = File.Open(NumeFisier, FileMode.Open))
                {

                    while (sBinFile.Position < sBinFile.Length)
                    {
                        //Observati conversia!!!
                        clienti.Add((Client)b.Deserialize(sBinFile));
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

            return clienti;
        }
        public Client GetClient(int idClient)
        {
            throw new Exception("Optiunea GetStudent by Id nu este implementata");
        }

        public Client GetClient(string nume, int varsta)
        {
            BinaryFormatter b = new BinaryFormatter();

            //instructiunea 'using' va apela sBinFile.Close();
            using (Stream sBinFile = File.Open(NumeFisier, FileMode.Open))
            {

                while (sBinFile.Position < sBinFile.Length)
                {
                    //Observati conversia!!!
                    Client client = (Client)b.Deserialize(sBinFile);
                    if (client.nume_prenume.Equals(nume) && client.varsta.Equals(varsta))
                        return client;
                }
            }

            return null;
        }

        public bool UpdateClient(Client c)
        {
            throw new Exception("Optiunea UpdateStudent nu este implementata");
        }

        public int GetId()
        {
            int IdClient = ID_PRIMUL_CLIENT;
            try
            {
                //instructiunea 'using' va apela sBinFile.Close();
                using (Stream sBinFile = File.Open(NumeFisier, FileMode.Open))
                {
                    BinaryFormatter b = new BinaryFormatter();

                    //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                    while (sBinFile.Position < sBinFile.Length)
                    {
                        //Observati conversia!!!
                        Client c = (Client)b.Deserialize(sBinFile);
                        IdClient = c.Id_Client + INCREMENT;
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
            return IdClient;
        }

        public Client GetClientByIndex(int index)
        {
            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (Stream sBinFile = File.Open(NumeFisier, FileMode.Open))
                {
                    BinaryFormatter b = new BinaryFormatter();

                    //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                    while (sBinFile.Position < sBinFile.Length)
                    {
                        //Observati conversia!!!
                        Client c = (Client)b.Deserialize(sBinFile);
                        if (c.Id_Client == index)
                            return c;
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
            /*List<Restaurant> restaurante = GetRestaurante();
            bool actualizareCuSucces = false;
            try
            {
                //instructiunea 'using' va apela la final swFisierText.Close();
                //al doilea parametru setat la 'false' al constructorului StreamWriter indica modul 'overwrite' de deschidere al fisierului
                using (StreamWriter swFisierText = new StreamWriter(NumeFisier, false))
                {
                    foreach (Restaurant r in restaurante)
                    {
                        if (r.Id_Restaurant != restaurant.Id_Restaurant)
                        {
                            swFisierText.WriteLine(r.ConversieLaSir_PentruFisier());
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

            return actualizareCuSucces;*/
            throw new Exception("Optiunea de stergere in Binar nu este implementata!");
        }
        public void CautareClientNume(List<Client> clienti)
        {
            throw new Exception("Optiunea de cautare dupa nume in Binar nu este implementata!");
        }
        public void CautareClientVarsta(List<Client> clienti)
        {
            throw new Exception("Optiunea de cautare dupa an in Binar nu este implementata!");
        }
        public void ClientiAlfabet(List<Client> clienti)
        {
            throw new Exception("Optiunea de ordonare alfabetica in Binar nu este implementata!");
        }
    }
}
