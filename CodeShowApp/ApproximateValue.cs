using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseApp
{
    /// <summary>
    /// just for code show, it can work :)
    /// 
    /// Chenxu zhang
    /// 2019.3
    /// </summary>
    public partial class Utils
    {
        /// <summary>
        /// get 2 approx. values from sorted array
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static int[] SeachApproximateValue(int sum,int[] data)
        {
            if (data == null || data.Length == 0)
                throw new ArgumentNullException(NULL_ARGUMENT);

            if (data.Length < 2)
                return new int[0];

            int head=0, tail=0;

            //let leave the number which more than 'sum'
            for(int j=data.Length-1;j>0;j--)
            {
                if (data[j] < sum)
                {
                    tail = j;
                    break;
                }
            }


            for(int i=0;i<tail;i++)
            {
                if (data[i] > sum)
                    break;
                if (tail - head <= 1)
                    break;

                if (data[head] + data[tail] > sum)
                {
                    tail--;
                }
                else if (data[head] + data[tail] == sum)
                    break;
                else if (data[head] + data[tail] < sum)
                {
                    head++;
                    if (data[head] + data[tail] > sum)
                    {
                        --head;
                        break;
                    }
                }
            }

            Console.WriteLine("approx. index: [{0}] [{1}]", head, tail);
            List<int> result = new List<int>() { data[head], data[tail] };

            return result.ToArray();

        }
    }
}
