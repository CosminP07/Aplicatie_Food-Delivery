using LibrarieModele;
using System.Collections.Generic;


namespace NivelStocareDate
{
    public interface IStocareDataClienti
    {
        void AddClient(Client c);
        List<Client> GetClienti();
        Client GetClient(string nume, int varsta);
        Client GetClient(int idClient);
        bool UpdateClient(Client c);
        int GetId();
        void CautareClientNume(List<Client> clienti);
        void CautareClientVarsta(List<Client> clienti);
        void ClientiAlfabet(List<Client> clienti);
        bool StergeClient(Client client);
        Client GetClientByIndex(int index);
    }
}
