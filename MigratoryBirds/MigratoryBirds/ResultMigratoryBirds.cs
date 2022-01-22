using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigratoryBirds
{
    internal class ResultMigratoryBirds
    {
        public static int maxSightedBird(List<int> arr)
        {
            int[] count = new int[arr.Max()];
            int max = 0, c = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                count[arr[i] - 1]++;
            }

            for (int i = 0; i < count.Length; i++)
            {
                if (max < count[i]) { max = count[i]; c = i; }
            }

            return c + 1;
        }
    }
}
