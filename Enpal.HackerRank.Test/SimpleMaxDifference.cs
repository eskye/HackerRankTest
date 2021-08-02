using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enpal.HackerRank.Test
{
    public class SimpleMaxDifference
    {
        /// <summary>
        /// https://stackoverflow.com/questions/57325024/maximum-difference-in-an-array-not-passing-all-test-cases-in-hackerrank
        /// </summary>
        /// <param name="px"></param>
        /// <returns></returns>
        public static int MaxDifference(List<int> px)
        {
            int min = px[0];
            int diff = -1;
            for (int i = 1; i < px.Count; i++)
            {
                if (px[i] > min) diff = Math.Max(px[i] - min, diff);
                min = Math.Min(min, px[i]);
            }
            return diff;
        }


        /// <summary>
        /// The Jungle Book
        /// http://prochal.com/2019/06/the-jungle-book/
        /// </summary>
        /// <param name="ints"></param>
        /// <returns></returns>
        public static int MinimumGroups(List<int> ints)
        {
            
            int max = 1;
            int arrLen = ints.Count;
            for (var i = 0; i < ints.Count; i++)
            {
                var a = i;
                var counter = 1;
                while (ints[a] > -1 && ints[a] < arrLen && counter < arrLen)
                {
                    a = ints[a];
                    counter++;
                }

                if (counter > max)
                    max = counter;
            }
            return max;
        }
    }
}
