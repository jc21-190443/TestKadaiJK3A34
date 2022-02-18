using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class JetCoaster
    {
        public static int ride
            (int k,int[] g,int r)
        {

            int p = 0;
            int i = 0;

            for (int c =0; c < r; c++)
            {
                
                int b = 0;
                int s = 0;
               
                for (int d =0 ; k > b;d++ )
                {
                     
                    b += g[i];

                   

                    if(k < b)
                    {
                        continue;
                    }
                   
                    s = b;

                    if (g.Length == 1)
                    {
                        break;
                    }

                    i += 1;
                   
                    if (i > g.Length-1)
                    {
                        i = 0;
                    }

                }
                p += s;
            }
            return p;



            




        }
    }
}
