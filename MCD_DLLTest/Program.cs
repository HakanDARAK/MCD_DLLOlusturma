using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_DLLTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bu projeye oluşturdugumuz dll'i referans olarak attık. Atmak için Dll oluşturma projesindeki bin klasörünün içinde olan debug klasörünün içindeki dll dosyanı referans olarak atmamız gerekiyor ayrıca dll dosyası çalışmayacagı için bu projeyi set as startup olarak ayarlayın.


            MCD_DLLOlusturma.Class1 DllTest =new MCD_DLLOlusturma.Class1();

            Console.WriteLine(DllTest.Topla(2, 1));

            Console.WriteLine(DllTest.Cikar(2,1));

            Console.WriteLine(DllTest.Carp(2,1));

            Console.WriteLine(DllTest.Bol(2,1));

            Console.ReadKey();

          
        }
    }
}
