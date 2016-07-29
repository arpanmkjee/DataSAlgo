using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1A1
{
    public static class AplusB
    {
        public static string Add(string A, string B)
        {

            string output=String.Empty;

            int a,b;
            //Check if the inputs are integers and other race conditions
            if (!int.TryParse(A, out a) || !int.TryParse(B, out b))
                return "0";

            output = (a + b).ToString();

            return output;
        }
    }
}
