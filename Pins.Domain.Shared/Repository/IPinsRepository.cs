namespace Pins.Domain.Shared.Repository
{
    public interface IPinsRepository
    {
        bool IsAnyByPIN(string pin);
    }
}