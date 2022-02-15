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
                int a = 0;
                int b = 0;
                int s = 0;
               
                for (int d =0 ; k > b;d++ )
                {
                    a = g[i];
                    b += a;

                    if (d == g.Length)
                    {
                        b = 8;
                    }

                    if(k < b)
                    {
                        continue;
                    }
                    s = b;

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
