using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;

namespace NivelStocareDate
{
    public class AdministrareRestaurante_Fisier
    {
        private const int NR_MAX_RESTAURANTE = 50;
        private string numeFisierR;

        public AdministrareRestaurante_Fisier(string numeFisierR)
        {
            this.numeFisierR = numeFisierR;
            // se incearca deschiderea fisierului in modul OpenOrCreate
            // astfel incat sa fie creat daca nu exista
            Stream streamFisierText = File.Open(numeFisierR, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AddRestaurant(Restaurant restaurant)
        {
            // instructiunea 'using' va apela la final streamWriterFisierText.Close();
            // al doilea parametru setat la 'true' al constructorului StreamWriter indica
            // modul 'append' de deschidere al fisierului
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisierR, true))
            {
                streamWriterFisierText.WriteLine(restaurant.ConversieLaSir_PentruFisier());
            }
        }

        public Restaurant[] GetRestaurante(out int nrRestaurante)
        {
            Restaurant[] restaurante = new Restaurant[NR_MAX_RESTAURANTE];

            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisierR))
            {
                string linieFisier;
                nrRestaurante = 0;

                // citeste cate o linie si creaza un obiect de tip Client
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    restaurante[nrRestaurante++] = new Restaurant(linieFisier);
                }
            }

            return restaurante;
        }
        public int GetLastId()
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
        }

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
        public static void CautareRestaurantNume(Restaurant[] restaurante, int nrRestaurante)
        {
            Console.WriteLine("\nIntroduceti denumirea restaurantului cautat: ");
            string nume1 = Console.ReadLine();
            int valid = 0;
            for (int contor = 0; contor < nrRestaurante; contor++)
            {
                if (nume1 == restaurante[contor].denumire)
                {
                    Console.WriteLine($"Restaurantul cu denumirea {restaurante[contor].denumire} a fost gasit si a fost fondat in anul {restaurante[contor].an_fondator}.");
                    valid = 1;
                }
            }
            if(valid == 0)
                Console.WriteLine($"Restaurantul cu denumirea {nume1} nu a fost gasit !!!");
        }
        public static void CautareRestaurantAn(Restaurant[] restaurante, int nrRestaurante)
        {
            Console.WriteLine("\nIntroduceti anul fondator al restaurantului cautat: ");
            int an1 = Int32.Parse(Console.ReadLine());
            int valid = 0;
            for (int contor = 0; contor < nrRestaurante; contor++)
            {
                if (an1 == restaurante[contor].an_fondator)
                {
                    Console.WriteLine($"Restaurantul fondat in anul {restaurante[contor].an_fondator} a fost gasit si se numeste {restaurante[contor].denumire}");
                    valid = 1;
                }
            }
            if(valid == 0)
                Console.WriteLine($"Restaurantul fondat in anul {an1} nu a fost gasit !!!");
        }
        public static void RestauranteAlfabet(Restaurant[] restaurante, int nrRestaurante)
        {
            string[][] sir = new string[26][];
            int[] contor = new int[26];
            int curent;


            // citeste cate o linie si creaza un obiect de tip Client
            // pe baza datelor din linia citita
            for (curent = 0; curent < nrRestaurante; curent++)
            {
                for (int i = 0; i < 26; i++)
                {
                    sir[i] = new string[nrRestaurante];
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


    }
}
