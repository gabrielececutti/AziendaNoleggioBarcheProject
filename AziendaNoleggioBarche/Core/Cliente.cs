using System;
namespace AziendaNoleggioBarche.Core
{
	/*
	 * cosa sa:
	 * codice fiscale 
	 * nome e cognome
	 * data e luogo di nascita
	 * registro noleggi effettuati (da cui deriva fedeltà)
	 * 
	 * stato concreto:
	 * string CodiceFiscale
	 * string nome
	 * string cognome
	 * DateOnly DataDiNascita
	 * List<Noleggio> NoleggiEffettuati
	 * 
	 * cosa sa fare:
	 * dire se il cliente è fedele
	 * aggiungere noleggio al registro personale
	 * 
	 * 
	 */
    public class Cliente
	{
		public string CodiceFiscale { get; init; }
		public string Nome { get; init; }
		public string Cognome { get; init; }
		public DateOnly DataDiNascita { get; init; }
		public List<Noleggio> NoleggiEffettuati { get; init; }


		/// <summary>
		/// Aggiunge il noleggio al registro dei noleggi effettuati dal cliente.
		/// </summary>
		/// <param name="noleggio"></param>
		public  void AddNoleggio (Noleggio noleggio)
		{

		}


		/// <summary>
		/// Ritorna un valore booleano in base alla fedeltà del cliente.
		/// </summary>
		/// <returns><c>true</c> se il cliente è fedele, 
		/// <c>false</c> se il cliente non è fedele</returns>
		public bool IsFedele ()
		{
			return false;
		}
	
	}
}

