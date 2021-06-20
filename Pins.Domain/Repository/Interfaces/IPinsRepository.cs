using Pins.Domain.Model;
using System.Threading.Tasks;

namespace Pins.Domain.Repository.Interfaces
{
    public interface IPinsRepository
    {
        bool IsAnyByPIN(string pin);
        Task Create(PinLog pin);
    }
}
