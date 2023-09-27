using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Patient_Notes
{
    public class T : Vitals
    {
        protected string _notes;
        public T(string notes)
        {
            _notes = notes;
        }

        //Method to extract important parameters from a string.
        public override List<string> ShowDetails()
        {
            string pattern = @"T[:]?[ ]\d{1,3}(?:\.\d{1,2})?";
            MatchCollection hrMatch = Regex.Matches(_notes, pattern);
            List<string> result = new List<string>();

            foreach (Match m in hrMatch)
            {
                result.Add(m.Value + "degree Celsius" + CalculateRange(m.Value));
            }

            return result;
        }

        //Method to calculate range.
        public string CalculateRange(string s)
        {
            string item1 = "";
            foreach (char k in s)
            {
                if (char.IsDigit(k) || k == '.')
                {
                    item1 += k;
                }
            }

            double num = double.Parse(item1);

            if (num < 36.5)
            {
                return " (Low)";
            }
            else if (num > 37.2)
            {
                return " (High)";
            }

            return "";

        }
    }
}
