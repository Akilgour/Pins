using NSubstitute;
using NUnit.Framework;
using Pins.Application.Helper;
using Pins.Domain.Repository.Interfaces;

namespace Pins.Application.Test.Helper
{
    [TestFixture]
    public class IsPINUniqueHelperTest
    {
        [TestCase("1234", true)]
        [TestCase("7890", false)]
        public void Resolve_SameFourDigits(string PIN, bool expected)
        {
            //arrange
            var pinsRepository = Substitute.For<IPinsRepository>();
            pinsRepository.IsAnyByPIN("2340").Returns(true);
            pinsRepository.IsAnyByPIN("7890").Returns(false);

            //act
            var value = IsPINUniqueHelper.Resolve(PIN, pinsRepository);
            //assert
            Assert.AreEqual(expected, value);
        }
    }
}