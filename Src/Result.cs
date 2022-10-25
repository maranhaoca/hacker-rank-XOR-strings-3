using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Src
{
    public class Result
    {
        /*
         * Complete the 'sockMerchant' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER n
         *  2. INTEGER_ARRAY ar
         */

        public static int sockMerchant(int n, List<int> ar)
        {
            List<int>  distinctAr = ar.Distinct().ToList();
            int count = 0;

            foreach (int item in distinctAr)
            {
                count = count + (ar.Where(a => a == item).Count() / 2);
            }

            return count;
        }
    }
}