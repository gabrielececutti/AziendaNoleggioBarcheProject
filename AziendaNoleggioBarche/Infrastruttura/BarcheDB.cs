using AziendaNoleggioBarche.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AziendaNoleggioBarche.Infrastruttura
{
    /// <summary>
    /// Memorizza tutte le barche in una struttura dati.
    /// </summary>
    public class BarcheDB
    {
        Dictionary<int, Barca> Barche { get; init; } 

        public BarcheDB() 
        { 
            Barche = new Dictionary<int, Barca>();
        }

        /// <summary>
        /// Salva la barca nel database.
        /// </summary>
        /// <param name="barca"></param>
        public void Save (Barca barca)
        {
            int codiceIdentificativo = barca.CodiceIdentificativo;
            Barche.Add(codiceIdentificativo, barca);
        }

        /// <summary>
        /// Ritorna tutte le barche disponibili di quella marca, di quel modello e con quelle caratteristiche.
        /// </summary>
        /// <param name="barca">La barca con quelle caratteristiche desiderate</param>
        /// <returns></returns>
        public Dictionary<int, Barca> GetBarcheDisponibili (Barca barcaRichiesta)
        {
            Dictionary<int, Barca> barcheDisponibili = new Dictionary<int, Barca>();

            foreach( var item in Barche)
            {
                Barca barca = item.Value; // mi riotrna la barca
                if (GetCorrispondenzaBarche(barcaRichiesta, barca))
                {
                    barcheDisponibili.Add(item.Key,barca);
                }
            }
            return barcheDisponibili;
        }

        /// <summary>
        /// Ritorna tutto il database in formato stringa.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string output = "";
            foreach ( var item in Barche)
            {
                string barcaToString = item.ToString();
                output += barcaToString + "\n";
            }
            return output;
        }

        /// <summary>
        /// Ritrona un valore booleano in base alla corrispondenza della barche.
        /// </summary>
        /// <param name="barcaRichiesta"></param>
        /// <param name="barcaDisponibile"></param>
        /// <returns> <c>true</c> se le barche corrispondono per marca, tipo, soddisfa tutte le carrateristiche richieste dal cliente e non è occupata. <c>false</c> altrimenti.</returns>
        private bool GetCorrispondenzaBarche (Barca barcaRichiesta, Barca barca)
        {
            string marcaRichiesta = barcaRichiesta.Marca;
            TipoDiBarca tipoDiBarcaRichiesto = barcaRichiesta.TipoDiBarca;
            List<string> caratteriticheRichieste = barcaRichiesta.AltreCaratteristiche;

            bool èLibera = !barca.Occupata;
            string marca = barca.Marca;
            TipoDiBarca tipoDiBarca = barca.TipoDiBarca;
            List<string> caratteristiche = barca.AltreCaratteristiche;

            // funzione lambda che verifica se le caratteristiche minime delle barca sono soddisfatte
            Func<List<string>, List<string>, bool> func = (caratteristiche, caratteristicheRichieste) =>
            {
                foreach (string caratteristica in caratteristiche)
                {
                    if (!caratteriticheRichieste.Contains(caratteristica.ToLower()))
                    {
                        return false;
                    }
                }
                return true;
            };

            if (èLibera && marca.Equals(marcaRichiesta) && tipoDiBarca.Equals(tipoDiBarcaRichiesto) && func(caratteristiche, caratteriticheRichieste)  )
            {
                return true;
            }
            return false;
        }

       

    }
}
