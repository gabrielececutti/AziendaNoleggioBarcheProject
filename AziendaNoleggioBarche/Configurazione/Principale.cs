using System;
using AziendaNoleggioBarche.Core;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("PRESS ENTER TO EXIT");
Console.ReadLine();



/*
 * cercare disponibilità di una barca (noleggio) con date caratteristiche desiderate dal cliente,
    anche eventuali extra;

 * prenotare una barca in un certo luogo, da una data a una data con consegna in un
   certo luogo, determinando il costo eventualmente scontato (Noleggio)

 * prendere in consegna una barca e pagare il noleggio;

 * consegnarla e pagare eventuali penalità.
 */

// imposto i costi extra per ogni noleggio
Dictionary<string, decimal> costiExtra = new Dictionary<string, decimal>();
costiExtra.Add("skipper", 100);
costiExtra.Add("pulizia a fine crociera", 80);
costiExtra.Add("cuoco", 200);

          
    


