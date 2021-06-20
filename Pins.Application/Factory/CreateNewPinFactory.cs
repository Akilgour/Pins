using Pins.Application.Helper;
using Pins.Domain.Repository.Interfaces;
using System.Threading.Tasks;

namespace Pins.Application.Factory
{
    public class CreateNewPinFactory
    {
        public static async Task<string> Resolve(IPinsRepository pinsRepository)
        {
            string PIN;
            bool validPin;
            do
            {
                PIN = NewPinFactory.Resolve();
                validPin = await IsNewPINValidHelper.Resolve(PIN, pinsRepository);
            } while (!validPin);
            await pinsRepository.Create(PinFactory.Resolve(PIN));
            return PIN;
        }
    }
}