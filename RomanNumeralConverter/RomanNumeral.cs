using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanNumeralConverter
{
    internal enum RomanNumeralMilestone
    {
        I = 1,
        IV = 4,
        V = 5,
        IX = 9,
        X = 10,
        XL = 40,
        L = 50,
        XC = 90,
        C = 100,
        CD = 400,
        D = 500,
        CM = 900,
        M = 1000,
    }

    public static class RomanNumeralExtensions
    {
        #region To Roman
        public static string ToRoman(this int number)
        {
            if (number < 1) return "Zero or Negative Value";

            StringBuilder sb = new StringBuilder();
            int remain = number;
            while (remain > 0)
            {
                foreach (RomanNumeralMilestone milestone in FetchMilestonesDesc())
                {
                    if (remain >= (int)milestone)
                    {
                        int quotient = (remain / (int)milestone);
                        remain = remain % (int)milestone;
                        if (quotient > 0)
                        {
                            for (int i = 0; i < quotient; i++)
                            {
                                sb.Append(milestone.ToString());
                            }
                        }

                    }
                }
            }

            return sb.ToString();
        }
        #endregion

        #region FromRoman
        public static int FromRoman(this string roman)
        {
            if (string.IsNullOrWhiteSpace(roman)) return 0;
            var total = 0;
            var lastMilestone = RomanNumeralMilestone.I;
            for (var i = roman.Length - 1; i >= 0; i--)
            {
                bool validNumeral = false;
                foreach (RomanNumeralMilestone milestone in FetchMilestonesDesc())
                {
                    if (roman[i].ToString().ToUpper() == milestone.ToString())
                    {
                        if (lastMilestone > milestone)
                        {
                            total -= (int)milestone;
                        }
                        else
                        {
                            total += (int)milestone;
                        }
                        validNumeral = true;
                        lastMilestone = milestone;
                    }
                }
                if (!validNumeral) return 0;
            }
            return total;
        }
        #endregion

        #region Helpers
        private static List<RomanNumeralMilestone> FetchMilestonesDesc()
        {
            var milestones = new List<RomanNumeralMilestone>();
            milestones.AddRange(Enum.GetValues(typeof(RomanNumeralMilestone)).OfType<RomanNumeralMilestone>());
            return milestones.OrderByDescending(ms => (int)ms).ToList();
        }
        #endregion
    }
}
