using Pins.Application.Helper;
using Pins.Domain.Repository.Interfaces;
using System.Threading.Tasks;

namespace Pins.Application.Factory
{
    public class CreateNewPinFactory
    {
        public static async Task<string> Resolve(IPinsRepository pinsRepository)
        {
            string pin;
            bool validPin;
            do
            {
                pin = NewPinFactory.Resolve();
                validPin = IsNewPINValidHelper.Resolve(pin, pinsRepository);
            } while (!validPin);
            await pinsRepository.Create(PinFactory.Resolve(pin));
            return pin;
        }
    }
}