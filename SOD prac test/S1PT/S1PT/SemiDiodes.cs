using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1PT
{
    public class SemiDiodes : CollectionBase
    {
        public void Add(SemiDiode newSemiDiode)
        {
            List.Add(newSemiDiode);
        }

        public void Remove(SemiDiode oldSemiDiode)
        {
            List.Remove(oldSemiDiode);
        }
        
        public SemiDiode this[int index]
        {
            get
            {
                return (SemiDiode)List[index];
            }
            set
            {
                List[index] = value;
            }
        }
    }
}
