using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cryptography
{
    class calcmethods
    {
        public int mod(int x, int m)
        { 
            return (x % m + m) % m; 
        }

        public List<gcd_mi> CalcGcdMi(int domain)
        {
            List<gcd_mi> gcdList = new List<gcd_mi>();

            for (int loop = 2; loop < domain; loop++)
            {
                gcdList.Add(CalcGcdMi(domain, loop));
            }

            return gcdList;
        }

        public gcd_mi CalcGcdMi(int domain, int number)
        {
            int r = 1;
            int r1 = domain;
            int r2 = number;

            int t = 0;
            int t1 = 0;
            int t2 = 1;
            int q = 0;
            int mi = 0;

            while (r != 0)
            {
                r = mod(r1, r2);
                double temp = (r1 / r2);
                q = Convert.ToInt32(Math.Floor(temp));
                t = t1 - (q * t2);
                r1 = r2;
                r2 = r;
                t1 = t2;
                t2 = t;
            }

            if (r1 == 1)
                mi = mod(t1, domain);

            gcd_mi domnum = new gcd_mi();
            domnum.Domain = domain;
            domnum.Number = number;
            domnum.Gcd = r1;
            domnum.Mi = mi;

            return domnum;
        }
    }
}
