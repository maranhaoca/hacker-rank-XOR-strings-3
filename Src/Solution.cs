using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Src
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

            int result = Result.sockMerchant(n, ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}