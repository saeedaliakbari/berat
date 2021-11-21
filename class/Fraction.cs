using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BeratAj
{
    class Fraction
    {
        public static int GCD(int a, int b)
        {
            int gcd = 0;
            if (a == 0 || b == 0)
            {
                gcd = 0;
            }
            else {
                if (a > b)
                {
                    for (int i = b; i > 0; i--)
                    {
                        if (a % i == 0 && b % i == 0)
                        {
                            gcd = i;
                            break;
                        }
                    }
                }
                else if (a < b)
                {
                    for (int i = a; i > 0; i--)
                    {
                        if (a % i == 0 && b % i == 0)
                        {
                            gcd = i;
                            break;
                        }
                    }
                }
                else {
                    // a == b
                    gcd = a;
                }
            }
            return gcd;
        }
    }
    
}
