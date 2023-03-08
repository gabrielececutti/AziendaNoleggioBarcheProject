using System;
namespace AziendaNoleggioBarche.Core
{
    /**
	 * cosa sa:
	 * cliente per sapere se è fedele per eventuali sconti e per salvare il noleggio nel suo registro noleggi personale
	 * servizi database barche per trovare barche disponibili
	 * servizio salvataggio noleggio per salvare il noleggio nel database
	 * 
	 * stato concreto:
	 * Cliente 
	 * ServizioSalvataggioNoleggio
	 * 
	 * 
	 * cosa sa fare:
	 * chiede la barca desiderata
	 * cerca le barche disponibili
	 * istanziare un nuovo noleggio (deve chiedere eventuali extra, data ed inzio noleggio, luogo di presa cosegna e consegna e fisso)
	 * calcolare la tariffa
	 * prenota il noleggio  per salvare nel databse e salvarlo registro noleggi del cliente
	 * 
	 */
    public class ServiziPrenotazioneNoleggio
	{

		public Cliente? Cliente { get; init; }
		public ServiziDatabaseNoleggio ServiziSalvataggioNoleggio { get;  init; }

		/// <summary>
		/// Ritrona la barca con le caratteristiche richieste dal cliente.
		/// </summary>
		/// <returns></returns>
		//public Barca GetBarcaRichiesta ()
		//{
		
		//}

		/// <summary>
		/// Ritorna tutte le barche che soddifano le richieste del cliente.
		/// </summary>
		/// <param name="barca"></param>
		/// <returns></returns>
		//public Dictionary<int, Barca> GetBarcheDisponibili (Barca barcaRichiesta)
		//{

		//}

		/// <summary>
		/// RETURN noleggio richiesto dal cliente con la prima barca risultata libera.
		/// </summary>
		/// <returns></returns>
		//public Noleggio GetNoleggioFromUser ()
		//{

		//}

		/// <summary>
		/// RETURN tariffa giornaliera calcolata con gli eventuali sconti.
		/// </summary>
		/// <returns></returns>
		//public decimal CalcolaTariffa(Noleggio noleggio)
		//{

		//}

		/// <summary>
		/// Salva il noleggio nel database dei noleggi e nel registro noleggi dell'user.
		/// </summary>
		public void Prenota (Noleggio noleggio)
		{
			
		}
		
	}
}

