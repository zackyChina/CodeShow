using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************* 2019.3 chenxu****************");
            Console.WriteLine("\n*************test for find duplict elements in string**************");

            //int[] repeats = new int[] { 4, 3, 2, 7, 8, 2, 3, 1, 9, 1, 3, 1};
            int[] repeats = new int[] { 4, 5, 4, 3, 2, 7, 8, 2, 3, 1, 9, 1, 3, 1, 7, 12, 11, 2, 23, 3, 1, 9 ,5 };
            //int[] repeats = new int[] { 4, 5 };
            Console.WriteLine("test data: {0}", PrintData(repeats));

            var result2 = Utils.SearchByCompare(repeats);
            Console.WriteLine("SearchByCompare data: {0}", PrintData(result2));

            var result4 = Utils.SearchByCount(repeats);
            Console.WriteLine("SearchByCount data: {0}", PrintData(result4));

            var result3 = Utils.SearchByDictionary(repeats);
            Console.WriteLine("SearchByDictionary data: {0}", PrintData(result3));



            Console.WriteLine("\n\n\n\n*************test for reversion words from string**************\n");

            List<String> testList = new List<string>(){ "who",
                "who you are",
                "we have space    ",
                "   ",""};

            foreach (var test in testList)
            {
                try
                {
                    String result = Utils.ReverseWord(test);
                    Console.WriteLine(String.Format("test: [{0}]\nreversed: [{1}]\n", test, result));
                    Console.WriteLine();
                }
                catch (ArgumentNullException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }




            Console.WriteLine("\n\n\n\n*************test for find approximate integer in array**************\n");
            //int[] repeats = new int[] { 4, 3, 2, 7, 8, 2, 3, 1, 9, 1, 3, 1};
            //int[] repeats = new int[] { 4, 5, 4, 3, 2, 7, 8, 2, 3, 1, 9, 1, 3, 1, 7, 12, 11, 2, 23, 3, 1, 9 ,5 };
            int sum = 23;
            List<int> sortedList = new List<int> { 9, 1, 3, 1, 7, 12, 11, 2, 16, 27, 32, 3, 1, 9, 5 };
            sortedList.Sort();

            Console.WriteLine("approximate sorted test data: {0}", PrintData(sortedList.ToArray()));
            var resultApprox = Utils.SeachApproximateValue(sum, sortedList.ToArray());
            Console.WriteLine("approximate data: {0}", PrintData(resultApprox));

            Console.ReadKey();
        }

        static String PrintData(int[] data)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sb.Append(string.Format("{0} ", data[i]));
            }

            return sb.ToString();
        }
    }

}
