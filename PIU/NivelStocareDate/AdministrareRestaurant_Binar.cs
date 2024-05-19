using LibrarieModele;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace NivelStocareDate
{
    //clasa AdministrareStudenti_FisierBinar implementeaza interfata IStocareData
    public class AdministrareRestaurante_Binar : IStocareDataRestaurante
    {
        private const int ID_PRIMUL_RESTAURANT = 1;
        private const int INCREMENT = 1;

        string NumeFisier { get; set; }
        public AdministrareRestaurante_Binar(string numeFisier)
        {
            this.NumeFisier = numeFisier;
            Stream sBinFile = File.Open(NumeFisier, FileMode.OpenOrCreate);
            sBinFile.Close();

            //liniile de mai sus pot fi inlocuite cu linia de cod urmatoare deoarece
            //instructiunea 'using' va apela sBinFile.Close();
            //using (Stream sBinFile = File.Open(numeFisier, FileMode.OpenOrCreate)) { }
        }

        public void AddRestaurant(Restaurant r)
        {
            r.Id_Restaurant = GetId();

            try
            {
                BinaryFormatter b = new BinaryFormatter();

                //instructiunea 'using' va apela sBinFile.Close();
                using (Stream sBinFile = File.Open(NumeFisier, FileMode.Append, FileAccess.Write))
                {
                    //serializarea unui obiect
                    b.Serialize(sBinFile, r);
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

        public List<Restaurant> GetRestaurante()
        {
            List<Restaurant> restaurante = new List<Restaurant>();
            try
            {
                BinaryFormatter b = new BinaryFormatter();

                //instructiunea 'using' va apela sBinFile.Close();
                using (Stream sBinFile = File.Open(NumeFisier, FileMode.Open))
                {

                    while (sBinFile.Position < sBinFile.Length)
                    {
                        //Observati conversia!!!
                        restaurante.Add((Restaurant)b.Deserialize(sBinFile));
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

            return restaurante;
        }
        public Restaurant GetRestaurant(int idRestaurant)
        {
            throw new Exception("Optiunea GetStudent by Id nu este implementata");
        }

        public Restaurant GetRestaurant(string denumire, int an_fondator)
        {
            BinaryFormatter b = new BinaryFormatter();

            //instructiunea 'using' va apela sBinFile.Close();
            using (Stream sBinFile = File.Open(NumeFisier, FileMode.Open))
            {

                while (sBinFile.Position < sBinFile.Length)
                {
                    //Observati conversia!!!
                    Restaurant restaurant = (Restaurant)b.Deserialize(sBinFile);
                    if (restaurant.denumire.Equals(denumire) && restaurant.an_fondator.Equals(an_fondator))
                        return restaurant;
                }
            }

            return null;
        }

        public bool UpdateRestaurant(Restaurant r)
        {
            throw new Exception("Optiunea UpdateStudent nu este implementata");
        }

        public int GetId()
        {
            int IdRestaurant = ID_PRIMUL_RESTAURANT;
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
                        Restaurant r = (Restaurant)b.Deserialize(sBinFile);
                        IdRestaurant = r.Id_Restaurant + INCREMENT;
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
            return IdRestaurant;
        }

        public Restaurant GetRestaurantByIndex(int index)
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
                        Restaurant r = (Restaurant)b.Deserialize(sBinFile);
                        if (r.Id_Restaurant == index)
                            return r;
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
        public bool StergeRestaurant(Restaurant restaurant)
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
        public void CautareRestaurantNume(List<Restaurant> restaurante)
        {
            throw new Exception("Optiunea de cautare dupa nume in Binar nu este implementata!");
        }
        public void CautareRestaurantAn(List<Restaurant> restaurante)
        {
            throw new Exception("Optiunea de cautare dupa an in Binar nu este implementata!");
        }
        public void RestauranteAlfabet(List<Restaurant> restaurante)
        {
            throw new Exception("Optiunea de ordonare alfabetica in Binar nu este implementata!");
        }
    }
}