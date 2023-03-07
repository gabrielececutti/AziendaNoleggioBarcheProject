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

		public void GetDatabase();
	}
}

