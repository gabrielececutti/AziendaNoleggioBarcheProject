using System;
using AziendaNoleggioBarche.Infrastruttura;

namespace AziendaNoleggioBarche.Core
{
	public class ServiziDatabaseNoleggio : ServizioPersistenzaNoleggio
	{
        private readonly NoleggiDB noleggiDB;

		public ServiziDatabaseNoleggio(NoleggiDB noleggiDB)
		{
            this.noleggiDB = noleggiDB;
		}

        /// <summary>
        /// Salva il noleggio nel database.
        /// </summary>
        /// <param name="noleggio"></param>
        public void SalvaNelDatabase(Noleggio noleggio)
        {
            this.noleggiDB.Save(noleggio);
        }

        /// <summary>
        /// Salva il noleggio in un file .txt sul desktop.
        /// </summary>
        /// <param name="noleggio"></param>
        public void SalvaSuFileDiTesto(Noleggio noleggio)
        {
           // implementation
        }

        /// <summary>
        /// Stampa a console tutto il database.
        /// </summary>
        public void StampaOnConsole()
        {
            Console.WriteLine(this.noleggiDB.ToString());
        }
    }
}

