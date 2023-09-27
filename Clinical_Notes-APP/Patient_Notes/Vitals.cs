using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Notes
{
    public class Vitals
    {
        
        public Vitals()
        {
            
        }

        //Method made for derived classes to inherit.
        public virtual List<string> ShowDetails()
        {
            List<string> result = new List<string>();

            return result;
        }

    }
}
