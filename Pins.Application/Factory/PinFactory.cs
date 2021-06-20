using Pins.Domain.Model;
using System;

namespace Pins.Application.Factory
{
    public class PinFactory
    {
        public static PinLog Resolve(string PIN)
        {
        //    return new Pin() { PIN = PIN, CreatedDate = DateTime.UtcNow, LastModifiedDate = DateTime.UtcNow };
            return new PinLog() {  CreatedDate = DateTime.UtcNow, LastModifiedDate = DateTime.UtcNow };
        }
    }
}