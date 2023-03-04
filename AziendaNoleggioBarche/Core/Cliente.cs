using System;
namespace AziendaNoleggioBarche.Core
{
	/*
	 * cosa sa:
	 * nome e cognome
	 * registro noleggi effettuati (da cui deriva fedeltà)
	 * 
	 * 
	 * stato concreto:
	 * 
	 * 
	 * 
	 * cosa sa fare:
	 * dire se il cliente è fedele
	 * aggiungere noleggio al registro personale
	 * 
	 * 
	 */
    public class Cliente
	{


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

