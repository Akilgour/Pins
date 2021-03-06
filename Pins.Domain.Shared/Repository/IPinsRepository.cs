using System.Threading.Tasks;
 

namespace Pins.Domain.Shared.Repository
{
    public interface IPinsRepository
    {
        bool IsAnyByPIN(string pin);
        Task Create(PinLog pin);
    }
}