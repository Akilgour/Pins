using NSubstitute;
using NUnit.Framework;
using Pins.Application.Helper;
using Pins.Domain.Repository.Interfaces;
using System.Threading.Tasks;

namespace Pins.Application.Test.Helper
{
    public class IsNewPINValidHelperTest
    {
        [TestCase("0123")]
        [TestCase("1234")]
        [TestCase("2345")]
        [TestCase("5678")]
        [TestCase("9876")]
        [TestCase("8765")]
        [TestCase("4321")]
        [TestCase("3210")]
        [TestCase("0000")]
        [TestCase("1111")]
        [TestCase("5555")]
        [TestCase("9999")]
        [TestCase("2340")]
        public async Task Resolve_NotAValidPin(string PIN)
        {
            //arrange
            var pinsRepository = Substitute.For<IPinLogRepository>();
            pinsRepository.IsAnyByPIN("2340").Returns(true);

            //act
            var value = await IsNewPINValidHelper.Resolve(PIN, pinsRepository);
            //assert
            Assert.False(value);
        }

        [TestCase("1110")]
        [TestCase("1010")]
        [TestCase("1230")]
        [TestCase("7890")]
        [TestCase("5554")]
        public async Task Resolve_ValidPin(string PIN)
        {
            //arrange
            var pinsRepository = Substitute.For<IPinLogRepository>();
            pinsRepository.IsAnyByPIN("2340").Returns(true);
            //act
            var value = await IsNewPINValidHelper.Resolve(PIN, pinsRepository);
            //assert
            Assert.IsTrue(value);
        }
    }
}