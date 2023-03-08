using System;
namespace AziendaNoleggioBarche.Core
{
    /*
	 * cosa sa:
	 * tipo di barca (se a vela) (noleggio)
	 * cliente (fedele)
	 * noleggio (più di due settimane) (noleggio)
	 * periodo dell'anno (da ottobre a marzo) (noleggio)
	 *
	 * 
	 */
    public static class CalcolatoreSconto
	{

		/// <summary>
		/// Calcola lo sconto in base alle caratteristiche del noleggio e alla fedeltà del cliente.
		/// </summary>
		/// <param name="noleggio"></param>
		/// <param name="cliente"></param>
		/// <returns></returns>
		public static double  Calcola (Barca barca, Cliente cliente, DateOnly inizio, DateOnly fine)
		{
			double sconto = 0;
			if (barca.TipoDiBarca.Equals(TipoDiBarca.VELA))
			{
				sconto += 100;
			} else if (cliente.IsFedele())
			{
				
			} else if (true)
			{

			} else if (true)
			{

			}
			return sconto;
		}

	}
}

