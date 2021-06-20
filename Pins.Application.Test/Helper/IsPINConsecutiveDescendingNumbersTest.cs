using NUnit.Framework;
using Pins.Application.Helper;

namespace Pins.Application.Test.Helper
{
    public class IsPINConsecutiveDescendingNumbersTest
    {
        [TestCase("9876")]
        [TestCase("8765")]
        [TestCase("4321")]
        [TestCase("3210")]
        public void Resolve_ConsecutiveDescendingNumbers(string pin)
        {
            //arrange

            //act
            var value = IsPINConsecutiveDescendingNumbers.Resolve(pin);
            //assert
            Assert.IsTrue(value);
        }

        [TestCase("1234")]
        [TestCase("7890")]
        [TestCase("1369")]
        [TestCase("9753")]
        public void Resolve_NotConsecutiveDescendingNumbers(string pin)
        {
            //arrange

            //act
            var value = IsPINConsecutiveDescendingNumbers.Resolve(pin);
            //assert
            Assert.IsFalse(value);
        }
    }
}