using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;

namespace NivelStocareDate
{
    public class AdministrareRestaurante_Memorie
    {
        private const int NR_MAX_RESTAURANTE = 50;

        private Restaurant[] restaurante;
        private int nrRestaurante;

        public AdministrareRestaurante_Memorie()
        {
            restaurante = new Restaurant[NR_MAX_RESTAURANTE];
            nrRestaurante = 0;
        }

        public void AddRestaurant(Restaurant restaurant)
        {
            restaurante[nrRestaurante] = restaurant;
            nrRestaurante++;
        }

        public Restaurant[] GetRestaurante(out int nrRestaurante)
        {
            nrRestaurante = this.nrRestaurante;
            return restaurante;
        }
    }
}
