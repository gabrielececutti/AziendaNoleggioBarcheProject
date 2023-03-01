using System;
namespace AziendaNoleggioBarche.Core
{
	public interface ServizioPersistenzaCliente
	{

		/// <summary>
		/// salva il cliente nel database 
		/// </summary>
		/// <param name="cliente"></param>
		public void Salva (Cliente cliente);

		/// <summary>
		/// salva il cliente su un file di testo nel desktop
		/// </summary>
		/// <param name="cliente"></param>
		public void StampaSuFile (Cliente cliente);
	}
}

