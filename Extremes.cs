using System;
using System.Collections.Generic;
using System.Text;

namespace Cv6
{
    class Extremes
    {
        public static T Highest <T> (params T[] values) where T : IComparable
        {
            T max = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i].CompareTo(max) > 0)
                {
                    max = values[i];
                }
            }
            return max;

        }
        public static T Lowest <T> (params T[] values) where T : IComparable
        {
            T min = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i].CompareTo(min) < 0)
                {
                    min = values[i];
                }
            }  
            return min;

        }
    }
}
