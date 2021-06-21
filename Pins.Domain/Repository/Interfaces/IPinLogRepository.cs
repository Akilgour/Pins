using Pins.Domain.Model;
using System.Threading.Tasks;

namespace Pins.Domain.Repository.Interfaces
{
    public interface IPinLogRepository
    {
        Task<bool> IsAnyByPIN(string pin);
        Task Create(PinLog pin);
    }
}
