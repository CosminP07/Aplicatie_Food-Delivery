using LibrarieModele;
using System.Collections.Generic;

namespace NivelStocareDate
{
    //definitia interfetei
    public interface IStocareDataRestaurante
    {
        void AddRestaurant(Restaurant r);
        List<Restaurant> GetRestaurante();
        Restaurant GetRestaurant(string denumire1, int an_fondator1);
        Restaurant GetRestaurant(int idRestaurant);
        bool UpdateRestaurant(Restaurant r);
        int GetId();
        void CautareRestaurantNume(List<Restaurant> restaurante);
        void CautareRestaurantAn(List<Restaurant> restaurante);
        void RestauranteAlfabet(List<Restaurant> restaurante);
        bool StergeRestaurant(Restaurant restaurant);
        Restaurant GetRestaurantByIndex(int index);
    }
}