using Pins.Domain.Shared.Repository;

namespace Pins.Application.Helper
{
    public class IsPINUniqueHelper
    {
        public static bool Resolve(string pin, IPinsRepository pinsRepository) => pinsRepository.IsAnyByPIN(pin);
    }
}