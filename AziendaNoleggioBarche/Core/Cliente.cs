using System;
namespace AziendaNoleggioBarche.Core
{
	/*
	 * cosa sa:
	 * codice fiscale 
	 * nome e cognome
	 * data e luogo di nascita
	 * registro noleggi effettuati (da cui deriva fedeltà)
	 * 
	 * stato concreto:
	 * string CodiceFiscale
	 * string nome
	 * string cognome
	 * DateOnly DataDiNascita
	 * List<Noleggio> NoleggiEffettuati
	 * 
	 * cosa sa fare:
	 * dire se il cliente è fedele
	 * aggiungere noleggio al registro personale
	 * 
	 * 
	 */
    public class Cliente
	{
		public string CodiceFiscale { get; }
		public string Nome { get;  }
		public string Cognome { get; }
		public DateOnly DataDiNascita { get; }
		public List<Noleggio> NoleggiEffettuati { get; }

        public Cliente(string codiceFiscale, string nome, string cognome, DateOnly dataDiNascita, List<Noleggio> noleggiEffettuati)
        {
            CodiceFiscale = codiceFiscale;
            Nome = nome;
            Cognome = cognome;
            DataDiNascita = dataDiNascita;
            NoleggiEffettuati = noleggiEffettuati;
        }

        /// <summary>
        /// Aggiunge il noleggio al registro dei noleggi effettuati dal cliente.
        /// </summary>
        /// <param name="noleggio"></param>
        public  void AddNoleggio (Noleggio noleggio)
		{
			NoleggiEffettuati.Add(noleggio);
		}


		/// <summary>
		/// Ritorna un valore booleano in base alla fedeltà del cliente. Il cliente è fedele se ha fatto almeno 5 noleggi.
		/// </summary>
		/// <returns><c>true</c> se il cliente è fedele, 
		/// <c>false</c> altrimenti</returns>
		public bool IsFedele ()
		{
			return NoleggiEffettuati.Capacity >= 5 ?  true : false;
		}

		public string GetNoleggiEffettuati ()
		{
			string output = string.Empty;
			foreach (var noleggio in NoleggiEffettuati)
			{
				output += noleggio.ToString() + "\n";
			}
			return output;
		}

        public override string ToString()
        {
			return $"Nome: {Nome} | cognome: {Cognome} | data di nascita: {DataDiNascita} | numero di noleggi effettuati: {NoleggiEffettuati.Count}";
        }

    }
}

