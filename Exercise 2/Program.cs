using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //mendeklarasikan array
            int i, n, AR, min_index, temp;
            int[] adi = new int[27];
            char ch;

            //tentukan banyaknya data (n)
            while (true)
            {
                Console.WriteLine("Masukkan data array");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 27))
                    break;
                else
                    Console.WriteLine("Data aray minimal 1 maksimal 27");
            }

            //input data ke array sebanyak n data
            for (i = 0; i <= n - 1; i++)
            {
                Console.Write("Data ke {0} : ", i + 1);
                adi[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Cetak data sebelum proses pengurutan
            Console.Write("\nData sebelum proses pengurutan\n");
            for (i = 0; i <= n - 1; i++)
            {
                Console.Write("{0} ", adi[i]);
            }
        }
    }
}
