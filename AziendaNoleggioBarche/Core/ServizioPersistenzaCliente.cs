using System;
namespace AziendaNoleggioBarche.Core
{
	public interface ServizioPersistenzaCliente
	{

        /// <summary>
        /// Stampa a console tutto il database.
        /// </summary>
        public void StampaDatabaseOnConsole();

        /// <summary>
        /// Salva il cliente nel database.
        /// </summary>
        /// <param name="barca"></param>
        public void SalvaNelDatabase(Cliente cliente);
    }
}

