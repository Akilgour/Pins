using System.Linq;

namespace Pins.Application.Helper
{
    public class IsPINSameFourDigitsHelper
    {
        public static bool Resolve(string PIN)
        {
            var numbers = PIN.ToList();
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] != numbers[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}