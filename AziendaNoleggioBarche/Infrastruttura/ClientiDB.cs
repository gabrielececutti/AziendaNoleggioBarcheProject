using System;
using AziendaNoleggioBarche.Core;

namespace AziendaNoleggioBarche.Infrastruttura
{
	/// <summary>
	/// Memorizza tutti i clienti in una struttura dati.
	/// </summary>
	public class ClientiDB
	{

		public Dictionary<string, Cliente> Clienti { get; init; }

        public ClientiDB()
        {
            Clienti = new Dictionary<string, Cliente>();
        }

        /// <summary>
        /// Salva il cliente nel database.
        /// </summary>
        /// <param name="cliente"></param>
        public void Save(Cliente cliente)
        {
            
            Clienti.Add(cliente.CodiceFiscale, cliente);
        }

        /// <summary>
        /// Ritorna tutto il database in formato stringa.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string output = "";
            foreach (var item in Clienti)
            {
                string clienteToString = item.ToString();
                output += clienteToString + "\n";
            }
            return output;
        }

    }

}

