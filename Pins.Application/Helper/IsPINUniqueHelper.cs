using Pins.Domain.Repository.Interfaces;
using System.Threading.Tasks;

namespace Pins.Application.Helper
{
    public class IsPINUniqueHelper
    {
        public static async Task<bool> Resolve(string PIN, IPinsRepository pinsRepository) => await pinsRepository.IsAnyByPIN(PIN);
    }
}