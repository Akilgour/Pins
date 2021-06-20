using Pins.Domain.Repository.Interfaces;

namespace Pins.Application.Helper
{
    public class IsPINUniqueHelper
    {
        public static bool Resolve(string PIN, IPinsRepository pinsRepository) => pinsRepository.IsAnyByPIN(PIN);
    }
}