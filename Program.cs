using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tulis angka ke-1 : ");

            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Tulis angka ke-2 : ");

            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hasil penjumlahan adalah : {0}", x + y);
            Console.WriteLine("Hasil pengurangan adalah : {0}", x - y);
            Console.WriteLine("Hasil perkalian adalah : {0}", x * y);
            Console.WriteLine("Hasil pembagian adalah : {0}", Convert.ToDouble(x) / Convert.ToDouble(y));
            Console.WriteLine("Hasil modulus adalah : {0}", x % y);

            Console.ReadLine();
        }
    }
}
