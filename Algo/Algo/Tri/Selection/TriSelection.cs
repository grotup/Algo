using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo.Tri.Selection
{
    public class TriSelection
    {
        public static List<int> Trier(List<int> Liste)
        {
            int Min = 0;
            int Tmp;
            for (int i = 0; i < Liste.Count; i++)
            {
                Min = i;
                for (int j = i; j < Liste.Count; j++)
                {
                    if (Liste[j] < Liste[Min])
                        Min = j;
                }
                if (Min != i)
                {
                    Tmp = Liste[i];
                    Liste[i] = Liste[Min];
                    Liste[Min] = Tmp;
                }
            }
            return Liste;
        }
    }
}
