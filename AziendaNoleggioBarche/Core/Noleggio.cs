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

        public int NumeroNoleggio { get; init; }
		public Cliente Cliente { get; init; }
		public Barca Barca { get; init; }
		public List<string> Extra { get; init; }
		public DateOnly Inizio { get; init; }
		public DateOnly Fine { get; init; }
		public string LuogoInizio { get; init; }
		public string LuogoConsegana { get; set; }
		public double ImportoTotale { get; }

        public Noleggio(int numeroNoleggio, Cliente cliente, Barca barca, List<string> extra, DateOnly inizio, DateOnly fine, string luogoInizio, string luogoConsegana)
        {
            NumeroNoleggio = numeroNoleggio;
            Cliente = cliente;
            Barca = barca;
            Extra = extra;
            Inizio = inizio;
            Fine = fine;
            LuogoInizio = luogoInizio;
            LuogoConsegana = luogoConsegana;
			ImportoTotale = CalcolaImportoTotale(Cliente, Barca, Extra, Inizio, Fine);
        }

		private double CalcolaImportoTotale (Cliente cliente, Barca barca, List<string> extra, DateOnly inizio, DateOnly fine)
		{
			double tariffaGiornaliera = CalcolatoreTariffaGiornaliera.Calcola(barca, extra);
			double sconto = CalcolatoreSconto.Calcola(barca, cliente, inizio, fine);
			return tariffaGiornaliera - sconto;
			
		}

        public override string ToString()
        {
			string datiBarca = Barca.ToString();
			string datiCliente = Cliente.ToString();

            string intestazione = "---------------------------------------------------------------------";
			string core = $"Numero noleggio: {NumeroNoleggio}\nNoleggio effettuato dal cliente: {datiCliente}\nDati barca: {datiBarca}\nData inzio noleggio: {Inizio}, luogo di presa consegna: {LuogoConsegana}\nData fine noleggio: {Fine}, luogo di consegna: {LuogoConsegana}\nPrezzo totale: {ImportoTotale}euro.";
			string piè = "---------------------------------------------------------------------";

			return $"{intestazione}\n{core}\n{piè}";
        }

    }
}

