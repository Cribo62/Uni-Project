using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1PT
{//student number: 218006302

    public class SemiDiode
    {
        public double ForwardV { get; set; }
        public double ReverseV { get; set; }
        public double BreakdownV { get; set; }

        public SemiDiode()
        {}

        public SemiDiode(double forwardV, double reverseV, double breakdownV)
        {
            this.ForwardV = forwardV;
            this.ReverseV = reverseV;
            this.BreakdownV = breakdownV;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
    
}
