using Pins.Domain.Repository.Interfaces;

namespace Pins.Application.Helper
{
    public class IsNewPINValidHelper
    {
        public static bool Resolve(string pin, IPinsRepository pinsRepository)
        {
            if (IsPINConsecutiveAccendingNumbersHelpers.Resolve(pin) ||
                IsPINConsecutiveDescendingNumbersHelpers.Resolve(pin) ||
                IsPINSameFourDigitsHelper.Resolve(pin) ||
                IsPINUniqueHelper.Resolve(pin, pinsRepository))
            {
                return false;
            }

            return true;
        }
    }
}