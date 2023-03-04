using System;
using AziendaNoleggioBarche.Core;

namespace AziendaNoleggioBarche.Infrastruttura
{
	/// <summary>
	/// Database che contiene tutti i clienti registrati.
	/// </summary>
	public class ClientiDB
	{
		List<Cliente>? Clienti { get; init; } // List???



		public void Save (Cliente cliente)
		{
			Clienti.Add(cliente);
		}
	}
}

