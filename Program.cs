
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

Banca banca = new Banca("MPS");

// Gestione menu console

string userChoise = "start";

while (!userChoise.Equals("esc"))
{
    InizioMenu();

}

void InizioMenu()
{
    Console.WriteLine("Menu principale - " + banca.Nome);

    MenuBanca();
    Console.WriteLine("Per uscire digitare 'esc' e premere Invio");
    userChoise = Console.ReadLine();
}

void MenuBanca()
{
    Console.WriteLine("--------------------------------------");
    Console.WriteLine("1. Aggiungere un cliente");
    Console.WriteLine("2. Modificare un cliente");
    Console.WriteLine("3. Ricerca un cliente");
    Console.WriteLine("4. Aggiungi un prestito");
    Console.WriteLine("5. Ricerca prestito per cliente");
    Console.WriteLine("6. Ricerca rate da pagare per cliente");
    Console.WriteLine("7. Stampa prospetto clienti");
    Console.WriteLine("8. Stampa prospetto utenti");
    Console.WriteLine("--------------------------------------");
}