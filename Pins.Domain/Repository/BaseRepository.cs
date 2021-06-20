using Pins.Domain.Context;

namespace Pins.Domain.Repository
{
    public abstract class BaseRepository
    {
        protected readonly PinsContext context;

        protected BaseRepository(PinsContext context)
        {
            this.context = context;
        }
    }
}