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
    public class CalcolatoreSconto
	{

		public static DateOnly InizioStagione = new DateOnly (2023, 5, 1);
		public static DateOnly FineStagione = new DateOnly(2023, 10, 1);


		/// <summary>
		/// Calcola un numero decimale che rappresenta sconto in base alle caratteristiche del noleggio e alla fedeltà del cliente.
		/// </summary>
		/// <param name="noleggio"></param>
		/// <returns><c>decimal</c> sconto</returns>
		public static decimal Calcola (Noleggio noleggio)
		{
			decimal sconto = 0;
			if (noleggio.Cliente.IsFedele())
			{
				sconto += 0.05m;
			} else if ((noleggio.Inizio < InizioStagione && noleggio.Fine < InizioStagione) || (noleggio.Inizio > FineStagione && noleggio.Fine > FineStagione))
			{
				sconto += 0.2m;
			} else if (noleggio.Barca.TipoDiBarca == TipoDiBarca.VELA)
			{
				sconto += 0.04m;
			}
			foreach (var extra in noleggio.Extra)
			{
				sconto += extra.Value; // non è in percentuale !!!
			}
			return sconto;
        }
	}
}

