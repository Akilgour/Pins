using System.Linq;

namespace Pins.Application.Helper
{
    public static class IsPINConsecutiveAccendingNumbersHelpers
    {
        public static bool Resolve(string pin)
        {
            var numbers = pin.ToList();
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] + 1 != numbers[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}