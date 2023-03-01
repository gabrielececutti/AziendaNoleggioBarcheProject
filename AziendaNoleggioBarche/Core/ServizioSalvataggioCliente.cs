using System;
using AziendaNoleggioBarche.Infrastruttura;

namespace AziendaNoleggioBarche.Core
{
	/*
	 * cosa sa:
	 * Cliente da salvare
	 * database clienti
	 * 
	 * 
	 * stato concreto:
	 * 
	 * 
	 * cosa sa fare:
	 * 
	 * 
	 */

	public class ServizioSalvataggioCliente : ServizioPersistenzaCliente
	{
		private ClientiDB S {get ; init; }
		public ServizioSalvataggioCliente 
		
	

		public override void Salva (Cliente cliente)
		{
			this.DatabaseClienti.save(cliente);
		}
	}
}

