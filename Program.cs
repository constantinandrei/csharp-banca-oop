﻿
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

Banca banca1 = new Banca("MPS");
List<String> menuBanca = new List<String> { "Aggiungere un Cliente", "Modificare un cliente", "Ricerca un cliente", "Aggiungi un prestito", "Ricerca prestito per cliente",
"Ricerca rate da pagare per cliente", "Stampa prospetto clienti", "Stampa prospetto utenti"};
// Gestione menu console

string userChoise = "start";

while (!userChoise.Equals("esc"))
{
    InizioMenu();
    switch (userChoise)
    {
        case "1":
            AggiungiCliente(banca1);
            break;
        case "7":
            StampaListaClienti(banca1.clienti);
            break;
        case "3":
            CercaCliente(banca1);
            break;
        default:
            break;
    }
}

void InizioMenu()
{
    Console.WriteLine("Menu principale - " + banca1.Nome);

    PrintMenu(menuBanca);
    Console.WriteLine("Per uscire digitare 'esc' e premere Invio");
    userChoise = Console.ReadLine();
}


void PrintMenu(List<String> vociMenu)
{
    Console.WriteLine("--------------------------------------");
    for (int i = 0; i < vociMenu.Count; i++)
    {
        Console.WriteLine("{0}. {1}", i+1, vociMenu[i]);
    }
    Console.WriteLine("--------------------------------------");
}

// test per i riferimenti

void AggiungiCliente(Banca banca)
{
    Console.WriteLine("Inserisci il nome cliente");
    string nome = Console.ReadLine();
    Console.WriteLine("Inserisci il cognome del cliente");
    string cognome = Console.ReadLine();
    Console.WriteLine("Inserisci il codice fiscale del cliente");
    string codiceFiscale = Console.ReadLine();
    Console.WriteLine("Inserisci lo stipendio del cliente");
    int stipendio = Convert.ToInt32(Console.ReadLine());

    banca.AggiungiCliente(nome, cognome, codiceFiscale, stipendio);
}

void StampaListaClienti(List<Cliente> clienti)
{
    Console.WriteLine("Lista Clienti Banca");
    Console.WriteLine("----------------");
    foreach (Cliente cliente in clienti)
    {
        StampaCliente(cliente);
    }
}

void StampaCliente(Cliente cliente)
{
    Console.WriteLine("Nome:      " + cliente.Nome);
    Console.WriteLine("Cognome:   " + cliente.Cognome);
    Console.WriteLine("C.F.:      " + cliente.CodiceFiscale);
    Console.WriteLine("Stipendio: " + cliente.Stipendio);
}

void CercaCliente(Banca banca)
{
    Console.WriteLine("Inserire il Codice Fiscale del Cliente");
    Cliente trovato = banca.RicercaCliente(Console.ReadLine());
    if (trovato != null)
    {
        StampaCliente(trovato);
    } else
    {
        Console.WriteLine("Non abbiamo questo codice fiscale nel nostro database");
    }
}