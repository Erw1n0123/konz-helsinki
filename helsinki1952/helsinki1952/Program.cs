using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helsinki1952
{
    public class Program
    {
        public static int Pont(int helyezes)
        {
            if (helyezes == 1)
            {
                return 7;
            }
            else if (helyezes > 1 && helyezes < 7)
            {
                return 7 - helyezes;
            }
            else
            {
                return 0;
            }
        }
        static void Main(string[] args)
        {
            List<Eredmenyek> list = new List<Eredmenyek>();
            StreamReader r = new StreamReader("helsinki.txt");
            while (!r.EndOfStream)
            {
                list.Add(new Eredmenyek(r.ReadLine()));
            }
            r.Close();

            int pontszerzo = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].helyezes<7)
                {
                    pontszerzo += 1;
                }
                
            }
            Console.WriteLine("3. feladat\n\tpontszerző helyezések: " + pontszerzo);

            int pont = 0;
            foreach (var item in list)
            {

                if (item.sportag == "torna")
                {
                    pont += Pont(item.helyezes);
                }
            }
            Console.WriteLine("5. feladat\n\ttorna sportágban szerzett pont összesen: " + pont);

            StreamWriter w = new StreamWriter("asztalfoglalas.txt");
            int fo = 0;
            for (int i = 0; i < list.Count; i++)
            {
                fo += list[i].embred_db;
            }
            w.WriteLine($"Szeretnék asztalt foglalni {fo} főre!");
            w.Close();

            Console.ReadKey();
        }
    }
}
