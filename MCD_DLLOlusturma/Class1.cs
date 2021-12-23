using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_DLLOlusturma
{
    public class Class1
    {   //Açıklama yapmak için 3 defa "///" basılır otomatik olarak gelir.
        /// <summary>
        ///  Toplama İşlemi yapar.
        /// </summary>
        /// <param name="deger1"></param>
        /// <param name="deger2"></param>
        /// <returns></returns>
        
        public int Topla(int deger1, int deger2)
        {
            return deger1 + deger2;
        }
   
        public int Cikar(int deger1, int deger2)
        {
            return deger1 - deger2;
        }

        public int Carp(int deger1, int deger2)
        {
            return deger1 * deger2;
        }
        
        public int Bol(int deger1, int deger2)
        {
            if (deger2 == 0)
            {
                deger2 = 1;
            }

            return deger1 / deger2;
        }
    }
}
