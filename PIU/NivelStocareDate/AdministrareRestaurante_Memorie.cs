using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;

namespace NivelStocareDate
{
    public class AdministrareRestaurante_Memorie : IStocareDataRestaurante
    {
        private string numeFisierR;
        private const int ID_PRIMUL_RESTAURANT = 1;
        private const int INCREMENT = 1;

        public AdministrareRestaurante_Memorie(string numeFisierR)
        {
            this.numeFisierR = numeFisierR;
            // se incearca deschiderea fisierului in modul OpenOrCreate
            // astfel incat sa fie creat daca nu exista
            Stream streamFisierText = File.Open(numeFisierR, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AddRestaurant(Restaurant restaurant)
        {
            restaurant.Id_Restaurant = GetId();
            // instructiunea 'using' va apela la final streamWriterFisierText.Close();
            // al doilea parametru setat la 'true' al constructorului StreamWriter indica
            // modul 'append' de deschidere al fisierului
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisierR, true))
            {
                streamWriterFisierText.WriteLine(restaurant.ConversieLaSir_PentruFisier());
            }
        }

        public List<Restaurant> GetRestaurante()
        {
            List<Restaurant> restaurante = new List<Restaurant>();

            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisierR))
            {
                string linieFisier;

                // citeste cate o linie si creaza un obiect de tip Client
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    restaurante.Add(new Restaurant(linieFisier));
                }
            }

            return restaurante;
        }

        public Restaurant GetRestaurant(string denumire1, int an_fondator1)
        {
            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisierR))
            {
                string linieFisier;

                // citeste cate o linie si creaza un obiect de tip Student
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Restaurant restaurant = new Restaurant(linieFisier);
                    if (restaurant.denumire.Equals(denumire1) && restaurant.an_fondator.Equals(an_fondator1))
                        return restaurant;
                }
            }

            return null;
        }
        public Restaurant GetRestaurant(int idRestaurant)
        {
            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisierR))
            {
                string linieFisier;

                // citeste cate o linie si creaza un obiect de tip Student
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Restaurant restaurant = new Restaurant(linieFisier);
                    if (restaurant.Id_Restaurant == idRestaurant)
                        return restaurant;
                }
            }

            return null;
        }

        public bool UpdateRestaurant(Restaurant RestaurantActualizat)
        {
            List<Restaurant> restaurante = GetRestaurante();
            bool actualizareCuSucces = false;

            //instructiunea 'using' va apela la final swFisierText.Close();
            //al doilea parametru setat la 'false' al constructorului StreamWriter indica modul 'overwrite' de deschidere al fisierului
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisierR, false))
            {
                foreach (Restaurant restaurant in restaurante)
                {
                    Restaurant restaurantPentruScrisInFisier = restaurant;
                    //informatiile despre studentul actualizat vor fi preluate din parametrul "studentActualizat"
                    if (restaurant.Id_Restaurant == RestaurantActualizat.Id_Restaurant)
                    {
                        restaurantPentruScrisInFisier = RestaurantActualizat;
                    }
                    streamWriterFisierText.WriteLine(restaurantPentruScrisInFisier.ConversieLaSir_PentruFisier());
                }
                actualizareCuSucces = true;
            }

            return actualizareCuSucces;
        }
        /*public int GetLastId()
        {
            int lastID = 0;
            using (StreamReader streamReader = new StreamReader(numeFisierR))
            {
                string linieFisier;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    lastID++;
                }
            }
            return lastID;
        }*/

        /*public void RestauranteAlfabet()
        {
            string[][] sir = new string[26][];
            Restaurant[] restaurante = new Restaurant[NR_MAX_RESTAURANTE];
            int[] contor = new int[26];

            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisierR))
            {
                string linieFisier;
                int nrRestaurante = 0;

                // citeste cate o linie si creaza un obiect de tip Client
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    restaurante[nrRestaurante++] = new Restaurant(linieFisier);
                    for (int i = 0; i < 26; i++)
                    {
                        //sir[i] = new string[NR_MAX_CLIENTI];
                        if (restaurante[nrRestaurante - 1].denumire[0] == (i + 65))
                        {
                            sir[i][contor[i]] = restaurante[nrRestaurante - 1].denumire;
                            contor[i]++;
                        }
                    }
                }
            }
            for (int i = 65; i < 91; i++)
            {
                for (int j = 0; j < NR_MAX_RESTAURANTE; j++)
                    Console.Write("{0} ", sir[i][j]);
                Console.WriteLine();
            }
        }*/
        public void CautareRestaurantNume(List<Restaurant> restaurante)
        {
            Console.WriteLine("\nIntroduceti denumirea restaurantului cautat: ");
            string nume1 = Console.ReadLine();
            int valid = 0;
            for (int contor = 0; contor < restaurante.Count; contor++)
            {
                if (nume1 == restaurante[contor].denumire)
                {
                    Console.WriteLine($"Restaurantul cu denumirea {restaurante[contor].denumire} a fost gasit si a fost fondat in anul {restaurante[contor].an_fondator}.");
                    valid = 1;
                }
            }
            if (valid == 0)
                Console.WriteLine($"Restaurantul cu denumirea {nume1} nu a fost gasit !!!");
        }
        public void CautareRestaurantAn(List<Restaurant> restaurante)
        {
            Console.WriteLine("\nIntroduceti anul fondator al restaurantului cautat: ");
            int an1 = Int32.Parse(Console.ReadLine());
            int valid = 0;
            for (int contor = 0; contor < restaurante.Count; contor++)
            {
                if (an1 == restaurante[contor].an_fondator)
                {
                    Console.WriteLine($"Restaurantul fondat in anul {restaurante[contor].an_fondator} a fost gasit si se numeste {restaurante[contor].denumire}");
                    valid = 1;
                }
            }
            if (valid == 0)
                Console.WriteLine($"Restaurantul fondat in anul {an1} nu a fost gasit !!!");
        }
        public void RestauranteAlfabet(List<Restaurant> restaurante)
        {
            string[][] sir = new string[26][];
            int[] contor = new int[26];
            int curent;


            // citeste cate o linie si creaza un obiect de tip Client
            // pe baza datelor din linia citita
            for (curent = 0; curent < restaurante.Count; curent++)
            {
                for (int i = 0; i < 26; i++)
                {
                    sir[i] = new string[restaurante.Count];
                    if (restaurante[curent].denumire[0] == (i + 65))
                    {
                        sir[i][contor[i]] = restaurante[curent].denumire;
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
        public int GetId()
        {
            int IdRestaurant = ID_PRIMUL_RESTAURANT;

            // instructiunea 'using' va apela sr.Close()
            using (StreamReader streamReader = new StreamReader(numeFisierR))
            {
                string linieFisier;

                //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Restaurant student = new Restaurant(linieFisier);
                    IdRestaurant = student.Id_Restaurant + INCREMENT;
                }
            }

            return IdRestaurant;
        }
        public Restaurant GetRestaurantByIndex(int index)
        {
            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader(numeFisierR))
                {
                    string line;
                    //citeste cate o linie si creaza un obiect de tip Carte pe baza datelor din linia citita
                    while ((line = sr.ReadLine()) != null)
                    {
                        Restaurant restaurant = new Restaurant(line);
                        if (restaurant.Id_Restaurant == index)
                            return restaurant;
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
            List<Restaurant> restaurante = GetRestaurante();
            bool actualizareCuSucces = false;
            try
            {
                //instructiunea 'using' va apela la final swFisierText.Close();
                //al doilea parametru setat la 'false' al constructorului StreamWriter indica modul 'overwrite' de deschidere al fisierului
                using (StreamWriter swFisierText = new StreamWriter(numeFisierR, false))
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

            return actualizareCuSucces;
        }
    }
}
