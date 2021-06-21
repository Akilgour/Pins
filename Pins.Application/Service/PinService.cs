using Pins.Application.Contracts.Service;
using Pins.Application.Factory;
using Pins.Domain.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pins.Application.Service
{
    public class PinService : IPinService
    {
        private readonly IPinLogRepository pinLogRepository;

        public PinService(IPinLogRepository pinLogRepository)
        {
            this.pinLogRepository = pinLogRepository;
        }

        public async Task<string> Create()
        {
            return await CreateNewPinFactory.Resolve(pinLogRepository);
        }
    }
}
