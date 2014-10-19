using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo.Utils
{
    public class Utils
    {
        public static List<int> GenerateNumbers(int p)
        {
            List<int> Ret = new List<int>();
            int Add = 0;
            Random Rnd = new Random();
            for (int i = 0; i < p; i++)
            {
                Add = Rnd.Next(Int32.MaxValue);
                Ret.Add(Add);
            }
            return Ret;
        }

        public static bool IsSorted(List<int> Liste)
        {
            if (Liste == null || Liste.Count == 0)
                return false;

            for (int i = 0; i < Liste.Count-1; i++)
            {
                if (Liste[i] > Liste[i + 1])
                    return false;
            }
            return true;
        }
    }
}
