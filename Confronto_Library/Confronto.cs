﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confronto_Library
{
    public static class Confronto
    {
        public static int Max(int n1, int n2)
        {
            int max;
            if (n1 > n2)
            {
                max = n1;            
            }

            else
            {
                max = n2;             
            }
            return max;
        }
    }
}
