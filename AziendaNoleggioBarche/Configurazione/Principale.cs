using System;
using AziendaNoleggioBarche.Core;
using AziendaNoleggioBarche.Infrastruttura;

/*
 * VERIFCA DISPONIBILITA' DI BARCHE:
   CERCARE tutte le disponibilità di una barca con date caratteristiche desiderate dal cliente,
   anche eventuali extra;

 * PRENOTAZIONE DI UN NOLEGGIO:
   PRENOTARE una barca (di quelle risultate disponibili dopo la verifca della disponibilità) in un certo luogo, da una data a una data con consegna in un certo luogo, determinando il costo eventualmente scontato (Noleggio)

 * prendere in consegna una barca e PAGARE il noleggio;

 * consegnarla e PAGARE eventuali penalità.
 * 
 * PROPRIETA' AGGIUNTIVE:
 * toString() dei database
 * stampare su un file di testo tutte le barche dell'azienda
 *
 */
List<string> list = new List<string>();
list.Add("condizionatore");list.Add("tv");
Barca b = new Barca(01, TipoDiBarca.VELA, "defefv", 12, list, false);
Barca b2 = new Barca(08, TipoDiBarca.VELA, "defefv", 12, list, false);
BarcheDB data = new BarcheDB();
data.SaveOnDB(b);
data.SaveOnDB(b2);

Console.WriteLine(data.ToString());








