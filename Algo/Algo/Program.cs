using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    public class Program
    {
        static void Main(string[] args)
        {
            int NbItems = 0;
            if (args.Length == 1)
                NbItems = Int32.Parse(args[0]);

            List<int> Table = null;
            Table = Utils.Utils.GenerateNumbers(NbItems);

            Console.WriteLine("=== LISTE AVANT ===");
            for (int i = 0; i < Table.Count; i++)
            {
                Console.WriteLine(Table[i] + ",");
            }
            Tri.Bulle.TriBulle.Trier(Table);
            Console.WriteLine("=== LISTE APRES");
            for (int i = 0; i < Table.Count; i++)
            {
                Console.WriteLine(Table[i] + ",");
            }
            Console.Read();
        }
    }
}
