using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S1PT
{
    
    class Program
    {
        static void Main(string[] args)
        {
            LED led1 = new LED
            {
                Color = "Blue"
            };
            
            LED led2 = new LED
            {
                Color = "GREEN"
            };

            LED led3 = (LED)led2.GetCopy();

         
            Laser l1 = new Laser();
            {
                l1.WaveLength = 1000;
            }

            Laser l2 = new Laser();
            {
                l2.WaveLength = 2000;
            }

            Laser l3 = new Laser();
            {
                l3.WaveLength = 3330;
            }

            SemiDiodes sDiodes = new SemiDiodes();
            {
                sDiodes.Add(led1);
                sDiodes.Add(l1);
                sDiodes.Add(led2);
                sDiodes.Add(l2);
                sDiodes.Add(led3);
                sDiodes.Add(l3);

                foreach (SemiDiode diodes in sDiodes)
                {

                    if (led1 is LED)
                    {
                        (led1 as LED).shade();
                        Console.WriteLine(led1.Color);
                    } 
                    if(led2 is LED)
                    {
                      (led2 as LED).shade2();
                      Console.WriteLine(led2.Color);
                    }
                    if(led3 is LED)
                    {
                        (led3 as LED).shade3();
                        Console.WriteLine(led3.Color);
                    }

                }
            }
            Console.ReadKey();
        }
    }
}
