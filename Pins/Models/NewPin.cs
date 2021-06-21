namespace Pins.Model
{
    public class NewPin
    {
        public NewPin(string PIN)
        {
            this.PIN = PIN;
        }

        public string PIN { get; private set; }
    }
}