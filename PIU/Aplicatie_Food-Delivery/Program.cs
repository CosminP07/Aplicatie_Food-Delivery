﻿using Aplicatie_Food_Delivery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;
using LibrarieModele.Enumerari;
using NivelStocareDate;
using System.Configuration;
using System.IO;
using System.Threading;


namespace Aplicatie_Food_Delivery
{
    class Program
    {

        static void Main()
        {
            //AdministrareClienti_Memorie adminClienti = new AdministrareClienti_Memorie();
            Client clientNou = new Client();
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            // setare locatie fisier in directorul corespunzator solutiei
            // astfel incat datele din fisier sa poata fi utilizate si de alte proiecte
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            IStocareDataClienti adminClientif;
            adminClientif = new AdministrareClienti_Fisier(caleCompletaFisier);

            
            Restaurant restaurantNou = new Restaurant();
            string numeFisierR = ConfigurationManager.AppSettings["NumeFisierR"];
            string locatieFisierSolutie1 = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            // setare locatie fisier in directorul corespunzator solutiei
            // astfel incat datele din fisier sa poata fi utilizate si de alte proiecte
            string caleCompletaFisier1 = locatieFisierSolutie1 + "\\" + numeFisierR;
            IStocareDataRestaurante adminRestaurante;
            adminRestaurante = new AdministrareRestaurante_Fisier(caleCompletaFisier1);
            //AdministrareRestaurante_Fisier adminRestaurante = new AdministrareRestaurante_Fisier(caleCompletaFisier1);

            string optiune;
            do
            {
                Console.WriteLine("\nClient - C\nRestaurant - R\nIesire - X\n");
                Console.WriteLine("Introduceti optiunea: ");
                optiune = Console.ReadLine();
                switch (optiune.ToUpper())
                {
                    case "C":
                        string optiuneC;
                        do
                        {


                            Console.WriteLine("\nC. Citire informatii client de la tastatura");
                            Console.WriteLine("I. Afisarea informatiilor despre ultimului client introdus");
                            //Console.WriteLine("A. Afisare client din vector de obiecte");
                            //Console.WriteLine("S. Salvare client in vector de obiecte");
                            Console.WriteLine("AF. Afisare clienti din fisier");
                            Console.WriteLine("SF. Salvare client in fisier");
                            Console.WriteLine("N. Cautare client dupa nume");
                            Console.WriteLine("V. Cautare client dupa varsta");
                            Console.WriteLine("AA. Afisare clienti in ordine alfabetica");
                            Console.WriteLine("X. Iesire catre meniul principal\n");
                            Console.WriteLine("Introduceti optiunea la client: ");
                            optiuneC = Console.ReadLine();
                            switch (optiuneC.ToUpper())
                            {
                                case "C":
                                    clientNou = CitireClientTastatura();
                                    break;
                                case "I":
                                    AfisareClient(clientNou);
                                    break;
                                /*case "A":
                                    Client[] clienti = adminClienti.GetClienti(out nrClienti1);
                                    AfisareClienti(clienti, nrClienti1);
                                    break;*/
                                case "AF":
                                    List<Client> clienti3 = adminClientif.GetClienti();
                                    AfisareClienti(clienti3);
                                    break;
                                /*case "S":
                                    int idClient = nrClienti1 + 1;
                                    clientNou.Id_Client = idClient;
                                    //adaugare client in vectorul de obiecte
                                    adminClienti.AddClient(clientNou);
                                    nrClienti1 += 1;
                                    break;*/
                                case "SF":
                                    int idClient1 = adminClientif.GetId();
                                    clientNou.Id_Client = ++idClient1;
                                    //adaugare client in fisier
                                    adminClientif.AddClient(clientNou);
                                    break;
                                case "N":
                                    List<Client> clienti1 = adminClientif.GetClienti();
                                    adminClientif.CautareClientNume(clienti1);
                                    break;
                                case "V":
                                    List<Client> clienti2 = adminClientif.GetClienti();
                                    adminClientif.CautareClientVarsta(clienti2);
                                    break;
                                case "AA":
                                    List<Client> clienti4 = adminClientif.GetClienti();
                                    adminClientif.ClientiAlfabet(clienti4);
                                    break;
                                case "X":
                                    break;
                                default:
                                    Console.WriteLine("Optiunea nu exista!");
                                    break;
                            }
                        } while (optiuneC.ToUpper() != "X");
                        if (optiuneC.ToUpper() != "X")
                        {
                            Console.WriteLine("Introduceti optiunea: ");
                            Console.ReadKey();
                        }
                        break;
                    case "R":
                        string optiuneR;
                        do
                        {


                            Console.WriteLine("\nC. Citire informatii restaurant de la tastatura");
                            Console.WriteLine("I. Afisarea informatiilor despre ultimului restaurant introdus");
                            //Console.WriteLine("A. Afisare restaurant din vector de obiecte");
                            //Console.WriteLine("S. Salvare restaurant in vector de obiecte");
                            Console.WriteLine("AF. Afisare restaurante din fisier");
                            Console.WriteLine("SF. Salvare restaurante in fisier");
                            Console.WriteLine("AA. Afisare restaurante in ordine alfabetica");
                            Console.WriteLine("N. Cautare restaurant dupa denumire");
                            Console.WriteLine("F. Cautare restaurant dupa an fondator");
                            Console.WriteLine("X. Iesire catre meniul principal\n");
                            Console.WriteLine("Introduceti optiunea la restaurant: ");
                            optiuneR = Console.ReadLine();
                            switch (optiuneR.ToUpper())
                            {
                                case "C":
                                    restaurantNou = CitireRestaurantTastatura();
                                    break;
                                case "I":
                                    AfisareRestaurant(restaurantNou);
                                    break;
                                case "AF":
                                    List<Restaurant> restaurante3 = adminRestaurante.GetRestaurante();
                                    AfisareRestaurante(restaurante3);
                                    break;
                                /*case "A":
                                    Restaurant[] restaurante = adminRestaurante.GetRestaurante(out nrRestaurante1);
                                    AfisareRestaurante(restaurante, nrRestaurante1);
                                    break;
                                case "S":
                                    int idRestaurant = nrRestaurante1 + 1;
                                    restaurantNou.Id_Restaurant = idRestaurant;
                                    //adaugare restaurant in vectorul de obiecte
                                    adminRestaurante.AddRestaurant(restaurantNou);
                                    nrRestaurante1 += 1;
                                    break;*/
                                case "SF":
                                    int idRestaurant1 = adminRestaurante.GetId();
                                    restaurantNou.Id_Restaurant = ++idRestaurant1;
                                    //adaugare restaurant in fisier
                                    adminRestaurante.AddRestaurant(restaurantNou);
                                    break;
                                case "N":
                                    List<Restaurant> restaurante1 = adminRestaurante.GetRestaurante();
                                    adminRestaurante.CautareRestaurantNume(restaurante1);
                                    break;
                                case "F":
                                    List<Restaurant> restaurante2 = adminRestaurante.GetRestaurante();
                                    adminRestaurante.CautareRestaurantAn(restaurante2);
                                    break;
                                case "AA":
                                    List<Restaurant> restaurante4 = adminRestaurante.GetRestaurante();
                                    adminRestaurante.RestauranteAlfabet(restaurante4);
                                    break;
                                case "X":
                                    break;
                                default:
                                    Console.WriteLine("Optiunea nu exista!");
                                    break;
                            }
                        } while (optiuneR.ToUpper() != "X");
                        if (optiuneR.ToUpper() != "X")
                        {
                            Console.WriteLine("Introduceti optiunea: ");
                            Console.ReadKey();
                        }
                        break;
                    case "X":
                        return;
                    default:
                        Console.WriteLine("Optiunea nu exista!");
                        break;
                }
            } while (optiune.ToUpper() != "X");
            Console.WriteLine("Introduceti optiunea: ");
            Console.ReadKey();
        }



        public static Restaurant CitireRestaurantTastatura()
        {
            Console.WriteLine("Introduceti denumirea: ");
            string denumire = Console.ReadLine();
            Console.WriteLine("Introduceti an fondator: ");
            int an_fondator = Int32.Parse(Console.ReadLine());
            Restaurant restaurant = new Restaurant(denumire, an_fondator);
            Console.WriteLine("Alegeti un specific: ");
            Console.WriteLine("1 - FastFood \n" +
            "2 - Traditional \n" +
            "3 - Chinezesc \n" +
            "4 - Indian \n" +
            "5 - Elegant \n");
            int optiune = Convert.ToInt32(Console.ReadLine());
            restaurant.specific = (Specific)optiune;
            /*Console.WriteLine("Alegeti un public tinta: ");
            Console.WriteLine("1 - Elev\n 2 - Student\n 3 - Angajat\n 4 - Somer\n 5 - Pensionar");
            int selectat = 0;
            int optiune1 = Convert.ToInt32(Console.ReadLine());
            while(optiune1 != 0) { 
                switch (optiune1)
                {
                    case 1:
                        selectat |= 0x0001; 
                        break;
                    case 2:
                        selectat |= 0x0010;
                        break;
                    case 3:
                        selectat |= 0x0100;
                        break;
                    case 4:
                        selectat |= 0x1000;
                        break;
                    case 5:
                        selectat |= 0x00010000;
                        break;
                    default:
                        Console.WriteLine("Optiune invalida!");
                        break;
                }
            }
            restaurant.clientitinta = selectat;*/
            return restaurant;
        }
        public static Client CitireClientTastatura()
        {
            Console.WriteLine("Introduceti numele si prenumele: ");
            string nume_prenume = Console.ReadLine();
            Console.WriteLine("Introduceti varsta: ");
            int varsta = Int32.Parse(Console.ReadLine());
            Client client = new Client(nume_prenume, varsta);
            Console.WriteLine("Alegeti un statut: ");
            Console.WriteLine("1 - Elev \n" +
            "2 - Student \n" +
            "3 - Angajat \n" +
            "4 - Somer \n" +
            "5 - Pensionar \n");
            int optiune = Convert.ToInt32(Console.ReadLine());
            client.statut = (Statut)optiune;
            return client;
        }
        public static void AfisareRestaurant(Restaurant restaurant)
        {
            string infoRestaurant = string.Format("Restaurantul cu denumirea {0} a fost fondat in anul {1} cu specificul {2}",
                    restaurant.denumire ?? "NECUNOSCUT",
                    restaurant.an_fondator,
                    restaurant.specific
                    );

            Console.WriteLine(infoRestaurant);
        }
        public static void AfisareClient(Client client)
        {
            string infoClient = string.Format("CLientul cu numele si prenumele {0} are varsta de {1} si este {2}",
                    client.nume_prenume ?? "NECUNOSCUT",
                    client.varsta,
                    client.statut
                    );

            Console.WriteLine(infoClient);
        }
        public static void AfisareRestaurante(List<Restaurant> restaurante)
        {
            Console.WriteLine("\nRestaurantele sunt:");
            for (int contor = 0; contor < restaurante.Count; contor++)
            {
                string infoRestaurant = restaurante[contor].Info();
                Console.WriteLine(infoRestaurant);
            }
        }
        public static void AfisareClienti(List<Client> clienti)
        {
            Console.WriteLine("\nClientii sunt:");
            for (int contor = 0; contor < clienti.Count; contor++)
            {
                string infoClient = clienti[contor].Info();
                Console.WriteLine(infoClient);
            }
        }
    }
}
