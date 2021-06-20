using Pins.Domain.Repository.Interfaces;

namespace Pins.Application.Helper
{
    public class IsNewPINValidHelper
    {
        public static bool Resolve(string PIN, IPinsRepository pinsRepository)
        {
            if (IsPINConsecutiveAccendingNumbersHelpers.Resolve(PIN) ||
                IsPINConsecutiveDescendingNumbersHelpers.Resolve(PIN) ||
                IsPINSameFourDigitsHelper.Resolve(PIN) ||
                IsPINUniqueHelper.Resolve(PIN, pinsRepository))
            {
                return false;
            }

            return true;
        }
    }
}