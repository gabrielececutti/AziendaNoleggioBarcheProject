using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AziendaNoleggioBarche.Core
{
	/*
	 * cosa sa:
	 * numero noleggio
	 * cliente 
	 * barca 
	 * extra (pulizia a fine corciera, skipper, cuoco)
	 * data e ora inizio noleggio
	 * date e ora fine noleggio
	 * luogo presa in consegna
	 * luogo consegna (lo stesso)
	 * tariffa giornaliera 
	 * sconto
	 * 
	 * penalità: incidenti e danni, consegna in data o luogo diverso da quello concordato
	 * 
	 * stato concreto:
	 * 
	 * 
	 * cosa sa fare:   
	 * 
	 * 
	 */

    public class Noleggio
	{
        public int Numero { get; }
		public Cliente Cliente { get; }
		public Barca Barca { get; }
		public Dictionary<string, decimal> Extra { get; }
		public DateOnly Inizio { get; }
		public DateOnly Fine { get; }
		public string LuogoInizio { get; }
		public string LuogoConsegana { get; }
		public decimal ImportoTotale { get; }


        public Noleggio(int numeroNoleggio, Cliente cliente, Barca barca, Dictionary<string, decimal> extra, DateOnly inizio, DateOnly fine, string luogoInizio, string luogoConsegana)
        {
            Numero = numeroNoleggio;
            Cliente = cliente;
            Barca = barca;
            Extra = extra;
            Inizio = inizio;
            Fine = fine;
            LuogoInizio = luogoInizio;
            LuogoConsegana = luogoConsegana;
			ImportoTotale = CalcolaImportoTotale();
        }

        public override string ToString()
        {
			// aggiungere extra
            string intestazione = "-------------------------------------RIEPILOGO NOLEGGIO-------------------------------------";
            string core = $"Numero noleggio: {Numero}\nNoleggio effettuato dal cliente: {Cliente.ToString()}\nDati barca: {Barca.ToString()}\nData inzio noleggio: {Inizio}, luogo di presa consegna: {LuogoConsegana}\nData fine noleggio: {Fine}, luogo di consegna: {LuogoConsegana}\nPrezzo: {ImportoTotale} euro.";
            string piè = "--------------------------------------------------------------------------------------------";
            return $"{intestazione}\n{core}\n{piè}";
        }

        private decimal CalcolaImportoTotale()
        {
			decimal sconto = CalcolatoreSconto.Calcola(this) * CalcolatoreTariffaGiornaliera.Calcola(this);
            return CalcolatoreTariffaGiornaliera.Calcola(this) - sconto;
        }
    }
}

