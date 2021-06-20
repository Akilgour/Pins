using System;

namespace Pins.Application.Factory
{
    public static class NewPinFactory
    {
        public static string Resolve()
        {
            var random = new Random();
            return random.Next(0, 9999).ToString("D4");
        }
    }
}