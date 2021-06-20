using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pins.Application.Helper
{
    public static class IsPINConsecutiveNumbers
    {

        public static bool Resolve(string pin)
        {
       
            var numbers = pin.ToList();

            for (int i = 0; i < numbers.Count -1; i++)
            {

                if (numbers[i] + 1 == numbers[i + 1])
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;

        }

    }
}
