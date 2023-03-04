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
		public ClientiDB DatabaseClienti { get; init; }


		/// <summary>
		/// Salva il cliente nel database.
		/// </summary>
		/// <param name="cliente"></param>
        public void Salva(Cliente cliente)
        {
			DatabaseClienti.Save(cliente);
        }


        /// <summary>
        /// Non implementato in questa classe
        /// </summary>
        /// <param name="cliente"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void StampaSuFile(Cliente cliente)
        {
            throw new NotImplementedException();
        }


    }
}

