using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Patient_Notes
{
    public class BP : Vitals
    {
        protected string _notes;
        public BP(string notes)
        {
            _notes = notes;
        }
        
        //Method to extract important parameters from a string.
        public override List<string> ShowDetails()
        {
            string pattern = @"BP[:]?[ ]\d{2,3}[/]\d{2,3}";
            MatchCollection hrMatch = Regex.Matches(_notes, pattern);
            List<string> result = new List<string>();

            foreach (Match m in hrMatch)
            {
                result.Add(m.Value + "mmHg" + CalculateRange(m.Value));              
            }
                  
            return result;
        }

        //Method to calculate range.
        public string CalculateRange(string s)
        {
            string item1 = "";
            string sample = "";
            foreach (char k in s)
            {
                if (k == '/')
                {
                    item1 = sample;
                    sample = "";
                }
                if (char.IsDigit(k))
                {
                    sample += k;
                }
            }

            int systolic = int.Parse(item1);
            int diastolic = int.Parse(sample);
            if (systolic < 90 && diastolic < 60)
            {
                return " (Low)";
            }
            else if (systolic > 130 && diastolic > 80)
            {
                return " (High)";
            }

            return "";

        }

    }
}
