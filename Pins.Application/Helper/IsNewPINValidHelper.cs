using Pins.Domain.Repository.Interfaces;
using System.Threading.Tasks;

namespace Pins.Application.Helper
{
    public class IsNewPINValidHelper
    {
        public static async Task<bool> Resolve(string PIN, IPinLogRepository pinsRepository)
        {
            if (IsPINConsecutiveAccendingNumbersHelpers.Resolve(PIN) ||
                IsPINConsecutiveDescendingNumbersHelpers.Resolve(PIN) ||
                IsPINSameFourDigitsHelper.Resolve(PIN) ||
                await IsPINUniqueHelper.Resolve(PIN, pinsRepository))
            {
                return false;
            }

            return true;
        }
    }
}