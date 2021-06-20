using Pins.Domain.Model;
using Pins.Domain.Repository.Interfaces;
using System;
using System.Threading.Tasks;

namespace Pins.Domain.Repository
{
    public class PinsRepository : IPinsRepository
    {
        public Task Create(PinLog pin)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsAnyByPIN(string pin)
        {
            throw new NotImplementedException();
        }
    }
}