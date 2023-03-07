using System;
using AziendaNoleggioBarche.Infrastruttura;
namespace AziendaNoleggioBarche.Core
{
	public class ServiziDatabaseBarche : ServizioPersistenzaBarche
	{
		public BarcheDB BarcheDB { get; init; }

		public ServiziDatabaseBarche(BarcheDB barcheDB	)
		{
			BarcheDB = barcheDB;
		}

		public void StampaDatabaseOnConsole()
		{
			Console.WriteLine(BarcheDB.ToString());
		}

        public void SalvaBarcaNelDatabase(Barca barca)
        {
			BarcheDB.SaveOnDB(barca);
        }

        public Dictionary<int, Barca> TrovaBarcheDisponibili(Barca barcaRichiesta)
        {
            throw new NotImplementedException();
        }

        public 

		
	
	}
}

