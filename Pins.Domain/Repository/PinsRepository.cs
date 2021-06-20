using Pins.Domain.Context;
using Pins.Domain.Model;
using Pins.Domain.Repository.Interfaces;
using System;
using System.Threading.Tasks;

namespace Pins.Domain.Repository
{
    public class PinsRepository : BaseRepository, IPinsRepository
    {
        public PinsRepository(PinsContext context) 
            : base (context)
        {

        }

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