using NSubstitute;
using NUnit.Framework;
using Pins.Application.Helper;
using Pins.Domain.Repository.Interfaces;
using System.Threading.Tasks;

namespace Pins.Application.Test.Helper
{
    [TestFixture]
    public class IsPINUniqueHelperTest
    {
        [TestCase("1234", true)]
        [TestCase("7890", false)]
        public async Task Resolve_SameFourDigitsAsync(string PIN, bool expected)
        {
            //arrange
            var pinsRepository = Substitute.For<IPinsRepository>();
            pinsRepository.IsAnyByPIN("1234").Returns(true);
            pinsRepository.IsAnyByPIN("7890").Returns(false);
            //act
            var value = await IsPINUniqueHelper.Resolve(PIN, pinsRepository);
            //assert
            Assert.AreEqual(expected, value);
        }
    }
}