using Pins.Domain.Model;
using System.Data.Entity;

namespace Pins.Domain.Context
{
    public class PinsContext : DbContext
    {
        public PinsContext() 
        { }

        public IDbSet<Pin> Pins { get; set; }
    }
}