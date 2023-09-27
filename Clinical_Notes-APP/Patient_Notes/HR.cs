using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Patient_Notes
{
    public class HR : Vitals
    {
        protected string _notes;
        public HR(string notes)
        {
            _notes = notes;
        }

        //Method to extract important parameters from a string.
        public override List<string> ShowDetails()
        {
            string pattern = @"HR[:]?[ ]\d{2,3}";
            MatchCollection hrMatch = Regex.Matches(_notes, pattern);
            List<string> result = new List<string>();   

            foreach (Match m in hrMatch) 
            {
                result.Add(m.Value + "bpm" + CalculateRange(m.Value));
            }

            return result;
        }

        //Method to calculate range.
        public string CalculateRange(string s)
        {
            string item1 = "";
            foreach (char k in s)
            {
                if (char.IsDigit(k))
                {
                    item1 += k;
                }
            }

            int num = int.Parse(item1);
        
            if (num < 60)
            {
                return " (Low)";
            }
            else if (num > 100)
            {
                return " (High)";
            }

            return "";

        }
    }
}
