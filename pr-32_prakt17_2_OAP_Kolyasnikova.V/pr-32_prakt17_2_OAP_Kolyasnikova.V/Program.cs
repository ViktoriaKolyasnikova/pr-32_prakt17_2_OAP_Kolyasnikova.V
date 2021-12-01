using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace pr_32_prakt17_2_OAP_Kolyasnikova.V
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("t.txt");

            List<P> p = new List<P>();
            string u;
            while ((u = sr.ReadLine()) != null)
            {
                string[] z = u.Split(' ');
                p.Add(new P { F = z[0], I = z[1], O = z[2], Vozrast = Convert.ToInt32(z[3]), Ves = Convert.ToInt32(z[4])});
            }

            var s = from x in p
                    where x.Vozrast % 3==0
                    select x;

            foreach (P z in s)
            Console.WriteLine($"{z.F} {z.I} {z.O} {z.Vozrast} {z.Ves}");

            Console.ReadKey();
        }
    }
}
