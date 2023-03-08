using System;
using AziendaNoleggioBarche.Infrastruttura;
namespace AziendaNoleggioBarche.Core
{
	/// <summary>
	/// Fornisce i servizi del database.
	/// </summary>
	public class ServiziDatabaseBarche : ServizioPersistenzaBarche
	{
		public readonly BarcheDB barcheDB;

		public ServiziDatabaseBarche(BarcheDB barcheDB	)
		{
			this.barcheDB = barcheDB;
		}

		/// <summary>
		/// Stampa a console tutto il database.
		/// </summary>
		public void StampaDatabaseOnConsole()
		{
			Console.WriteLine(this.barcheDB.ToString());
		}

		/// <summary>
		/// Salva la barca nel database.
		/// </summary>
		/// <param name="barca"></param>
        public void SalvaNelDatabase(Barca barca)
        {
			this.barcheDB.Save(barca);
        }

		/// <summary>
		/// Ritorna tutte le barche disponibili che rispettano le caratteristiche richieste del cliente.
		/// </summary>
		/// <param name="barcaRichiesta"></param>
		/// <returns></returns>
		public Dictionary<int, Barca> TrovaBarcheDisponibili(Barca barcaRichiesta)
		{
			return this.barcheDB.GetBarcheDisponibili(barcaRichiesta);
		}

	}
}

