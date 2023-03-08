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

	public class ServiziDatabaseCliente : ServizioPersistenzaCliente 
	{
        private readonly ClientiDB clientiDB;

        public ServiziDatabaseCliente(ClientiDB clientiDB)
        {
            this.clientiDB = clientiDB;
        }

        /// <summary>
        /// Salva il cliente nel database.
        /// </summary>
        /// <param name="cliente"></param>
        public void SalvaNelDatabase(Cliente cliente)
        {
            this.clientiDB.Save(cliente);
        }

        /// <summary>
        /// Stampa a console tutto il database.
        /// </summary>
        public void StampaDatabaseOnConsole()
        {
            Console.WriteLine(this.clientiDB.ToString());
        }

        public void StampaSuFile(Cliente cliente)
        {
            throw new NotImplementedException();
        }


    }
}

