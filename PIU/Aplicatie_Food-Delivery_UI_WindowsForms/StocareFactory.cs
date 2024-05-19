using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NivelStocareDate;
using System.Configuration;

namespace Aplicatie_Food_Delivery_UI_WindowsForms
{
    public static class StocareFactory
    {
        private const string FORMAT_SALVARE = "FormatSalvare";
        private const string NUME_FISIER1 = "NumeFisierR";
        private const string NUME_FISIER2 = "NumeFisier";
        //private const string NUME_FISIER2 = "NumeFisier2";
        public static IStocareDataRestaurante GetAdministratorStocare() //restaurante
        {
            var formatSalvare = ConfigurationManager.AppSettings[FORMAT_SALVARE];
            var numeFisier = ConfigurationManager.AppSettings[NUME_FISIER1];
            if (formatSalvare != null)
            {
                switch (formatSalvare)
                {
                    default:
                    case "bin":
                        return new AdministrareRestaurante_Binar(numeFisier + "." + formatSalvare);
                    case "txt":
                        return new AdministrareRestaurante_Fisier(numeFisier + "." + formatSalvare);
                }
            }

            return null;
        }
        public static IStocareDataClienti GetAdministratorStocare2() //cititori
        {
            var formatSalvare = ConfigurationManager.AppSettings[FORMAT_SALVARE];
            var numeFisier = ConfigurationManager.AppSettings[NUME_FISIER2];
            if (formatSalvare != null)
            {
                switch (formatSalvare)
                {
                    default:
                    /*case "bin":
                        return new AdministrareCititori_FisierBinar(numeFisier + "." + formatSalvare);*/
                    case "txt":
                        return new AdministrareClienti_Fisier(numeFisier + "." + formatSalvare);
                }
            }

            return null;
        }
    }
}
