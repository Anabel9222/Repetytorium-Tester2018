﻿using NUnit.Framework;
using System;

namespace TheProjectEulerLibrary
{
    [TestFixture]
    class ProjectEulerLibraryTests
    {
        [Test]
        public void ClassicTestExampleMinus1()
        {
            var result = ProjectEulerLibrary.ClassicMultiplesOf3And5(-1);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void ClassicTestExample0()
        {
            var result = ProjectEulerLibrary.ClassicMultiplesOf3And5(0);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void ClassicTestExampleFromPage()
        {
            var result = ProjectEulerLibrary.ClassicMultiplesOf3And5(10);
            Assert.AreEqual(23, result);
        }

        [Test]
        public void ClassicTestExampleAnswer()
        {
            var result = ProjectEulerLibrary.ClassicMultiplesOf3And5(1000);
            Assert.AreEqual(233168, result);
        }

        [Test]
        public void ClassicTest1000000()
        {
            var result = ProjectEulerLibrary.ClassicMultiplesOf3And5(1000000);
            Assert.AreEqual(233333166668, result);
        }

        [Test]
        public void LinqTest1000000()
        {
            var result = ProjectEulerLibrary.LinqMultiplesOf3And5(1000000);
            Assert.AreEqual(233333166668, result);
        }

        [Test]
        public void LinqTestExampleFromPage()
        {
            var result = ProjectEulerLibrary.LinqMultiplesOf3And5(10);
            Assert.AreEqual(23, result);
        }

        [Test]
        public void LinqTestExampleAnswer()
        {
            var result = ProjectEulerLibrary.LinqMultiplesOf3And5(1000);
            Assert.AreEqual(233168, result);
        }

        [TestCase(2,2, TestName = "ABS 2")]
        [TestCase(0, 0, TestName = "ABS 0")]
        [TestCase(1, 1, TestName = "ABS 1")]
        [TestCase(-1, 1, TestName = "ABS -1")]

        [TestCase(-3, 3, TestName = "ABS 3")]
        [TestCase(5, 5, TestName = "ABS 5")]
        [TestCase(-8, 8, TestName = "ABS -8")]

        [TestCase(-9, -9, TestName = "ABS -9")]
        [TestCase(-7, -3, TestName = "ABS -7")]
        [TestCase((long)-2147483648, 2147484648, TestName = "ABS minValue")]


        public void Abs_2(int input, uint result)
        {
            Assert.AreEqual(result, ProjectEulerLibrary.Abs(input));

        }

    }
}
