
//Sviluppare un’applicazione orientata agli oggetti per gestire i prestiti che una banca concede ai propri clienti.
//La banca è caratterizzata da
//un nome
//un insieme di clienti (una lista)
//un insieme di prestiti concessi ai clienti (una lista)
//I clienti sono caratterizzati da
//nome,
//cognome,
//codice fiscale
//stipendio
//I prestiti sono caratterizzati da
//ID
//intestatario del prestito (il cliente),
//un ammontare,
//una rata,
//una data inizio,
//una data fine.
//Per la banca deve essere possibile:
//aggiungere, modificare e ricercare un cliente.
//aggiungere un prestito.
//effettuare delle ricerche sui prestiti concessi ad un cliente dato il codice fiscale
//sapere, dato il codice fiscale di un cliente, l’ammontare totale dei prestiti concessi.
//sapere, dato il codice fiscale di un cliente, quante rate rimangono da pagare alla data odierna.
//Per i clienti e per i prestiti si vuole stampare un prospetto riassuntivo con tutti i dati che li caratterizzano in un formato di tipo stringa a piacere.
//Bonus:
//visualizzare per ogni cliente, la situazione dei suoi prestiti in formato tabellare.

using System.Reflection.Metadata.Ecma335;

public class Banca
{
    public string Nome { get;}
    public List<Cliente> clienti;
    public List<Prestito> prestito;

    public Banca(string nome)
    {
        Nome = nome;
        clienti = new List<Cliente>();
        prestito = new List<Prestito>();
    }

    public bool AggiungiCliente(string nome, string cognome, string codiceFiscale, int stipendio)
    {
        if (nome == null || cognome == null || codiceFiscale == null || stipendio <= 0)
            return false;
        clienti.Add(new Cliente(nome, cognome, codiceFiscale, stipendio));
        return true;
    }
    
    public Cliente RicercaCliente(string codiceFiscale)
    {
        foreach (Cliente cliente in clienti)
        {
            if (cliente.CodiceFiscale.Equals(codiceFiscale))
            {
                return cliente;
            }
        }
        return null;
    }
   
}