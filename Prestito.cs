
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

public class Prestito
{
    public static int Conteggio = 0;
    public int Id { get; set; }
    public Cliente Cliente { get; set; }
    public int TotalePrestito { get; set; }
    public int TotaleRata { get; set; }
    public DateOnly Inizio { get; set; }
    public DateOnly Fine { get; set; }

    public Prestito(Cliente cliente, int totalePrestito, int totaleRata, DateOnly inizio, DateOnly fine)
    {
        
        Cliente = cliente;
        TotalePrestito = totalePrestito;
        TotaleRata = totaleRata;
        Inizio = inizio;
        Fine = fine;
        Conteggio++;
        Id = Conteggio;
    }

}