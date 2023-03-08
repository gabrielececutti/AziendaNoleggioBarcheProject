using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AziendaNoleggioBarche.Core
{
    public interface ServizioPersistenzaBarche
    {
        /// <summary>
        /// 
        /// </summary>
        public void StampaDatabaseOnConsole();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="barca"></param>
        public void SalvaNelDatabase(Barca barca);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="barcaRichiesta"></param>
        /// <returns></returns>
        public Dictionary<int, Barca> TrovaBarcheDisponibili(Barca barcaRichiesta);
    }
}
