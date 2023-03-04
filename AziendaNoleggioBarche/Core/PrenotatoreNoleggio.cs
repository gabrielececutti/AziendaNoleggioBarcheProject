using System;
namespace AziendaNoleggioBarche.Core
{
	/**
	 * cosa sa:
	 * cliente
	 * servizio salvataggio noleggio
	 * 
	 * stato concreto:
	 * Cliente 
	 * ServizioSalvataggioNoleggio
	 * 
	 * cosa sa fare:
	 * chiede e istanzia un nolleggio desiderato dal cliente.
	 * vede se c'è un noleggio disponibile. (se c'è uno disponibile lo prenota, altirmenti chiede o di cambiare dati del noleggio o di non prenotare nulla).
	 * prenota il noleggio (salvare nel databse)
	 * salvare il noleggio nel registro noleggi del cliente
	 * 
	 */
	public class PrenotatoreNoleggio
	{

		public Cliente? Cliente { get; init; } // il cliente che vuole prenotare un noleggio.
		public ServizioSalvataggioNoleggio? ServizioSalvataggioNoleggio { get;  init; }

		/// <summary>
		/// Ritorna il noleggio deisderato dal cliente.
		/// </summary>
		/// <returns><c>Noleggio</c></returns>
		public Noleggio NoleggioFromUser ()
		{
			// implementation
			return new Noleggio();
		}

		/// <summary>
		/// Ritorna un valore booleano in base alla disponibilità del noleggio desiderato.
		/// </summary>
		/// <param name="noleggio"></param>
		/// <returns><c>true</c> se il noleggio è disponibile, <c>false</c> altrimenti</returns>
		public Boolean IsDisponibile(Noleggio noleggio)
		{
			// implmentation
			return false;
		}

		/// <summary>
		/// Salva il noleggio nel database dei noleggi e nel registro noleggi dell'user.
		/// </summary>
		public void Prenota (Noleggio noleggio)
		{
			// implementation
		}
		
	}
}

