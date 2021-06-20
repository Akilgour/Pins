﻿using NUnit.Framework;
using Pins.Application.Helper;

namespace Pins.Application.Test.Helper
{
    public class IsPINConsecutiveNumbersTest
    {
        [TestCase("0123")]
        [TestCase("1234")]
        [TestCase("2345")]
        [TestCase("5678")]
        public void Resolve_ConsecutiveNumbers(string pin)
        {
            //arrange

            //act
            var value = IsPINConsecutiveNumbers.Resolve(pin);
            //assert
            Assert.IsTrue(value);
        }

        [TestCase("1235")]
        [TestCase("5123")]
        [TestCase("7890")]
        [TestCase("1357")]
        [TestCase("2852")]
        [TestCase("4321")]
        public void Resolve_NOtConsecutiveNumbers(string pin)
        {
            //arrange

            //act
            var value = IsPINConsecutiveNumbers.Resolve(pin);
            //assert
            Assert.IsFalse(value);
        }
    }
}