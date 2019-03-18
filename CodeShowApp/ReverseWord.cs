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
        ///  reverse string word by word
        /// </summary>
        /// <param name="data">the string that want to be reversed</param>
        /// <returns></returns>
        public static String ReverseWord(String data)
        {
            if (String.IsNullOrEmpty(data))
                throw new ArgumentNullException("input data for reverse is empty!");

            String[] vals = data.TrimEnd((' ')).Split(' ').ToArray();
            if (vals.Length < 2)
                return data;

            //better performance we got if choice 'for' loop
            StringBuilder reversedSB = new StringBuilder();
            for (int i = vals.Length - 1; i >= 0; i--)
            {
                reversedSB.Append(vals[i]);
                if (i != 0)
                {
                    reversedSB.Append(" ");
                }
            }

            /*
             * another way: Stack class can be used, but performance impact we got
             
            Stack<String> valStack = new Stack<string>();
            valStack.Push("aa");
            */

            return reversedSB.ToString();

        }
    }
}
