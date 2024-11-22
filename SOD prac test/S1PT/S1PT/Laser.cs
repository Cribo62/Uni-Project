using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1PT
{
    public class Laser: SemiDiode
    {
        public int WaveLength { get; set; } = 405;

        public Laser()
        { }
        
    }
}
