using System;
using AziendaNoleggioBarche.Core;

namespace AziendaNoleggioBarche.Infrastruttura
{
	/// <summary>
	/// Database che contiene tutti i noleggi prenotati dai clienti.
	/// </summary>
	public class NoleggiDB
	{
        Dictionary<int, Noleggio> Noleggi { get; init; }

        public NoleggiDB()
		{
            Noleggi = new Dictionary<int, Noleggio>();
		}


        /// <summary>
        /// Salva il noleggio nel database.
        /// </summary>
        /// <param name="noleggio"></param>
        public void Save(Noleggio noleggio)
        {
            Noleggi.Add(noleggio.Numero, noleggio);
        }

        /// <summary>
        /// Ritorna tutto il database in formato stringa.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string output = "";
            foreach (var item in Noleggi)
            {
                string noleggioToString = item.ToString();
                output += noleggioToString + "\n";
            }
            return output;
        }
    }
}

