using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSUniversalLib
{
    public class Calculation
    {
        public static int GetQuantityForProduct(int productType, int materialType, int count, float width, float length)
        {
            double answer = 0;
            if (productType != 1 && productType != 2 && productType != 3)
            {
                return -1;
            }
            if (productType == 1)
            {
                answer = count * 1.1 * width * length;
            }
            if (productType == 2)
            {
                answer = count * 2.5 * width * length;
            }
            if (productType == 3)
            {
                answer = count * 8.43 * width * length;
            }
            if (materialType == 1)
            {
                return (int)Math.Ceiling((answer * 0.3 / 100 + answer));
            }
            if (materialType != 1 || materialType != 2)
            {
                return -1;
            }
            else
            {
                return (int)Math.Ceiling((answer * 0.12 / 100 + answer));
            }
        }
    }
}
