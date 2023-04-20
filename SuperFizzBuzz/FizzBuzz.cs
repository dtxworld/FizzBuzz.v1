using System;
using System.Collections.Generic;
using System.Linq;

namespace SuperFizzBuzz
{
    /// <summary>
    /// FizzBuzz v3.0
    /// </summary>
    public class FizzBuzz
    {
        /// <summary>
        /// Get range of numbers
        /// </summary>
        /// <param name="intList"></param>
        /// <returns>List of sequential integers</returns>
        public static List<int> GetRange(Tuple<int, int> rangeSet)
        {
            List<int> returnList = new List<int>();

            if (rangeSet != null)
            {
                int from = rangeSet.Item1;
                int end = rangeSet.Item2;
                if (from > end)
                {
                    for (int i = from; i >= end; i--)
                    {
                        returnList.Add(i);
                    }
                }
                else
                {
                    for (int i = from; i <= end; i++)
                    {
                        returnList.Add(i);
                    }
                }
            }
            return returnList;
        }

        /// <summary>
        /// Gets user supplied set of integers
        /// </summary>
        /// <param name="intList"></param>
        /// <returns>User defined set of integers</returns>
        public static List<int> GetUserSuppliedOutput(List<int> intList)
        {
            List<int> returnList = new List<int>();
            // 'output for a user supplied set of integers, even if they’re not sequential'
            foreach (int i in intList)
            {
                returnList.Add(i);
            }
            
            return returnList;
        }
    }
}
