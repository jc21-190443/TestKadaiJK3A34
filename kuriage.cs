using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class kuriage
    {

        public static int Kuriage10(int j)
        {
            int s = j / 10;
            if (j % 10 != 0)
            {
               if(j < 0){
                   s--;
               }
               if(j > 0)
                {
                    s++;
                }
            }
            s = s * 10;
            return s;

        }
    }
}
