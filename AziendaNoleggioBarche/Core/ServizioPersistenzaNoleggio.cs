using System;
namespace AziendaNoleggioBarche.Core
{
	public interface ServizioPersistenzaNoleggio
	{
		/// <summary>
		/// Salva il noleggio nel database.
		/// </summary>
		/// <param name="noleggio"></param>
		public void SalvaNelDatabase(Noleggio noleggio);

		/// <summary>
		/// Stampa a console tutto il database.
		/// </summary>
		public void StampaOnConsole();

		/// <summary>
		/// Salva il noleggio in un file .txt sul desktop.
		/// </summary>
		/// <param name="noleggio"></param>
		public void SalvaSuFileDiTesto(Noleggio noleggio);


	}
}

