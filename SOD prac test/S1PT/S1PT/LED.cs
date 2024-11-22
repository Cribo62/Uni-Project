using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1PT
{
    public class LED : SemiDiode
    {
        public string Color { get; set; } = "RED"; 

        public LED()
        { }

        public object GetCopy() => MemberwiseClone();

        internal void shade()
        {
            
        }

        internal void shade2()
        {
           
        }

        internal void shade3()
        {
            
        }
    }
}
