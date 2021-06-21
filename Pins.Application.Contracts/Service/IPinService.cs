using System.Threading.Tasks;

namespace Pins.Application.Contracts.Service
{
    public interface IPinService
    {
        Task<string> Create();
    }
}