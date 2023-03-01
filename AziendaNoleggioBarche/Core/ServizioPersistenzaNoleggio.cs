using System;
namespace AziendaNoleggioBarche.Core
{
	public interface ServizioPersistenzaNoleggio
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="noleggio"></param>
		public void Salva(Noleggio noleggio);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="noleggio"></param>
		/// <returns></returns>
		public bool IsPrenotato(Noleggio noleggio);
	}
}

