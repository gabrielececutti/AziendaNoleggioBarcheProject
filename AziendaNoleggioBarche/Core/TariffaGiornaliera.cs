using System;
namespace AziendaNoleggioBarche.Core
{
    /*
	 * cosa sa:
	 * dimensione
	 * marca
	 * altre caratteristiche (ad es con condizionatore, con televisione, con tendalini, età della barca, modello)
	 * costi extra
	 * 
	 * stato concreto:
	 * double dimensione
	 * string marca
	 * List<string> altreCaratteristiche
	 * Dictionary<string, decimal> costiExtra
	 * 
	 * 
	 * cosa sa fare:
	 * calcolare la tariffa giornaliera in base alle variabili di istanza
	 * 
	 */

    public class TariffaGiornaliera
	{
		double Dimesione { get; init; }
		string Marca { get; init; }
		List<string> AltreCaratteristiche { get; init; }
		Dictionary<string, decimal> CostiExtra { get; init; }

		public decimal Costo()
		{
			// implmentation
			return 0;
		}
		
	}
}

