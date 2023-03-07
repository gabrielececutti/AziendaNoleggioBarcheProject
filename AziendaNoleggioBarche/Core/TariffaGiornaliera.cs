using System;
namespace AziendaNoleggioBarche.Core
{
    /*
	 * cosa sa:
	 * barca
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
		
		Dictionary<string, decimal> CostiExtra { get; init; }

		public decimal Costo()
		{
			// implmentation
			return 0;
		}
		
	}
}

