using Pins.Domain.Context;
using Pins.Domain.Model;
using Pins.Domain.Repository.Interfaces;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Pins.Domain.Repository
{
    public class PinLogRepository : BaseRepository, IPinLogRepository
    {
        public PinLogRepository(PinsContext context)
            : base(context)
        {
        }

        public async Task Create(PinLog pinLog)
        {
            context.PinLogs.Add(pinLog);
            await context.SaveChangesAsync();
        }

        public async Task<bool> IsAnyByPIN(string PIN)
        {
            return await context.PinLogs.AnyAsync(x => x.PIN == PIN);
        }
    }
}