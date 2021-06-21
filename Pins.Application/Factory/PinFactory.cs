using Pins.Domain.Model;
using System;

namespace Pins.Application.Factory
{
    public class PinFactory
    {
        public static PinLog Resolve(string PIN)
        {
                return new PinLog() { PIN = PIN, CreatedDate = DateTime.UtcNow, LastModifiedDate = DateTime.UtcNow };
        }
    }
}