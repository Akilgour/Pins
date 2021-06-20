using Pins.Domain.Model;
using System.Data.Entity;

namespace Pins.Domain.Context
{
    public class PinsContext : DbContext
    {
        public PinsContext() 
        { }

        public IDbSet<PinLog> PinLogs { get; set; }
    }
}