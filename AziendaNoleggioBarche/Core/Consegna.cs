
using System;
namespace AziendaNoleggioBarche.Core
{
    /// <summary>
    /// Rappresenta la fine del noleggio con la consegna della barca nel luogo e data concordata o diversa con  possibili danni.
    /// </summary>
	public class Consegna
	{
		public Noleggio Noleggio { get; }
		public string LuogoDiConsegnaEffettivo { get; }
		public DateOnly DataDiConsegnaEffettiva { get; }
		public decimal Danni { get; }

        public Consegna(Noleggio noleggio, string luogoDiConsegnaEffettivo, DateOnly dataDiConsegnaEffettiva, decimal danni)
        {
            Noleggio = noleggio;
            LuogoDiConsegnaEffettivo = luogoDiConsegnaEffettivo;
            DataDiConsegnaEffettiva = dataDiConsegnaEffettiva;
            Danni = danni;
        }

        public Consegna(Noleggio noleggio, string luogoDiConsegnaEffettivo, DateOnly dataDiConsegnaEffettiva)
        {
            Noleggio = noleggio;
            LuogoDiConsegnaEffettivo = luogoDiConsegnaEffettivo;
            DataDiConsegnaEffettiva = dataDiConsegnaEffettiva;
        }

        public decimal GetImportoPenalità ()
        {
            return Danni + GetImportoLuogoConsegnaErrato() + GetImportoRitardoConsegna();
        }

        public decimal GetImportoLuogoConsegnaErrato ()
        {
            return 0;
        }

        public decimal GetImportoRitardoConsegna ()
        {
            return 0;
        }


    }
}

