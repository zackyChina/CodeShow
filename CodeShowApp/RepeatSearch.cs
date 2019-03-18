using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace ReverseApp
{
    /// <summary>
    /// just for code show, of course it can be run :)
    /// 
    /// Chenxu zhang
    /// 2019.3
    /// </summary>
    public partial class Utils
    {
        public static String NULL_ARGUMENT = "arguments for search not allow empty!";
        /// <summary>
        /// Getting repeat elements.
        /// it compares element via for loop on sorted list
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static int[] SearchByCompare(int[] data)
        {
            if (data == null || data.Length == 0)
                throw new ArgumentNullException(NULL_ARGUMENT);

            if (data.Length == 1)
                return data;

            List<int> f = new List<int>(data);
            f.Sort();
            List<int> ano = new List<int>();
            for (int i = 0; i < f.Count - 1; i++)
            {
                for (int j = i + 1; j < f.Count; j++)
                {
                    if (f[i] == f[j])
                    {
                        if (ano.Any() == false)
                            ano.Add(f[i]);
                        if (ano[ano.Count - 1] != f[i])
                        {
                            ano.Add(f[i]);
                            break;
                        }
                    }
                }
            }

            return ano.ToArray();
        }

        /// <summary>
        /// get repeat elements by count of appear
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static int[] SearchByCount(int[] data)
        {
            if (data == null || data.Length == 0)
                throw new ArgumentNullException(NULL_ARGUMENT);

            if (data.Length == 1)
                return data;

            Dictionary<int, int> values = new Dictionary<int, int>();
            for (int i = 0; i < data.Length; i++)
            {
                if (values.ContainsKey(data[i]))
                {
                    values[data[i]]++;
                }
                else
                {
                    values.Add(data[i], 1);
                }
            }

            var result = from a in values
                         where a.Value > 1
                         select a.Key;
            return result.ToArray();
        }

        /// <summary>
        /// find repeat elements by dictionary.contains 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static int[] SearchByDictionary(int[] data)
        {
            if (data == null || data.Length == 0)
                throw new ArgumentNullException(NULL_ARGUMENT);

            if (data.Length == 1)
                return data;

            HybridDictionary hd = new HybridDictionary();
            List<int> ano = new List<int>();
            for (int i = 0; i < data.Length; i++)
            {
                if (hd.Contains(data[i]))
                {
                    if (ano.Contains(data[i]) == false)
                        ano.Add(data[i]);
                }
                else
                {
                    hd.Add(data[i], data[i]);
                }
            }

            return ano.ToArray();
        }

    }
}
