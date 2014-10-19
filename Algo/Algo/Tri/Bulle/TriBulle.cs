using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo.Tri.Bulle
{
    public class TriBulle
    {
        public static List<int> Trier(List<int> Liste)
        {
            bool echange = true;
            int tmp;
            while (echange)
            {
                echange = false;
                for (int i = 0; i < Liste.Count-1; i++)
                {
                    if (Liste[i] > Liste[i + 1])
                    {
                        tmp = Liste[i];
                        Liste[i] = Liste[i + 1];
                        Liste[i + 1] = tmp;
                        echange = true;
                    }
                }
            }
            return Liste;
        }
    }
}
