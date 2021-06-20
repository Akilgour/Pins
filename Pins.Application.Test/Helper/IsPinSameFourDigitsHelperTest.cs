using NUnit.Framework;
using Pins.Application.Helper;

namespace Pins.Application.Test.Helper
{
    public class IsPINSameFourDigitsHelperTest
    {
        [TestCase("0000")]
        [TestCase("1111")]
        [TestCase("5555")]
        [TestCase("9999")]
        public void Resolve_SameFourDigits(string PIN)
        {
            //arrange

            //act
            var value = IsPINSameFourDigitsHelper.Resolve(PIN);
            //assert
            Assert.True(value);
        }

        [TestCase("0001")]
        [TestCase("1000")]
        [TestCase("1234")]
        [TestCase("1110")]
        [TestCase("1010")]
        [TestCase("1357")]
        public void Resolve_NotSameFourDigits(string PIN)
        {
            //arrange

            //act
            var value = IsPINSameFourDigitsHelper.Resolve(PIN);
            //assert
            Assert.IsFalse(value);
        }
    }
}