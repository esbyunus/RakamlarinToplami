using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace justmath
{
    internal class math
    {
        /// <summary>
        /// Parametere olarak aldigi sayinin rakamlari toplamini doner
        /// </summary>
        /// <param name="n">sayi</param>
        /// <returns>rakamlarin toplami</returns>
        public static int RakamToplam(int n)
        {
            int toplam = 0, rakam = 0;
            while (n>0)
            {
                rakam = n % 10; // n'nin 10 modunu alır. Yani rakamın 10 ile bolumunun kalani alinir.
                toplam += rakam; // rakam, toplama aktarılır
                n = n / 10; // n 10'a bolunur.
            }
            return toplam;
        }
    }
}
