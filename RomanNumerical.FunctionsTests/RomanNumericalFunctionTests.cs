using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumerical.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace RomanNumerical.Functions.Tests
{
    [TestClass()]
    public class RomanNumericalFunctionTests
    {
        [TestMethod()]
        public void IntToRomanTest01()
        {
            int input = 1;
            string expectedResult = "I";

            string result = RomanNumericalFunction.IntToRoman(input);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod()]
        public void IntToRomanTest02()
        {
            int input = 2;
            string expectedResult = "II";

            string result = RomanNumericalFunction.IntToRoman(input);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod()]
        public void IntToRomanTest03()
        {
            int input = 4;
            string expectedResult = "IV";

            string result = RomanNumericalFunction.IntToRoman(input);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod()]
        public void IntToRomanTest04()
        {
            int input = 5;
            string expectedResult = "V";

            string result = RomanNumericalFunction.IntToRoman(input);

            Assert.AreEqual(expectedResult, result);
        }


        [TestMethod()]
        public void IntToRomanTest05()
        {
            int input = 9;
            string expectedResult = "IX";

            string result = RomanNumericalFunction.IntToRoman(input);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod()]
        public void IntToRomanTest06()
        {
            int input = 10;
            string expectedResult = "X";

            string result = RomanNumericalFunction.IntToRoman(input);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod()]
        public void IntToRomanTest07()
        {
            int input = 40;
            string expectedResult = "XL";

            string result = RomanNumericalFunction.IntToRoman(input);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod()]
        public void IntToRomanTest08()
        {
            int input = 50;
            string expectedResult = "L";

            string result = RomanNumericalFunction.IntToRoman(input);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod()]
        public void IntToRomanTest09()
        {
            int input = 90;
            string expectedResult = "XC";

            string result = RomanNumericalFunction.IntToRoman(input);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod()]
        public void IntToRomanTest10()
        {
            int input = 100;
            string expectedResult = "C";

            string result = RomanNumericalFunction.IntToRoman(input);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod()]
        public void IntToRomanTest11()
        {
            int input = 400;
            string expectedResult = "CD";

            string result = RomanNumericalFunction.IntToRoman(input);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod()]
        public void IntToRomanTest12()
        {
            int input = 500;
            string expectedResult = "D";

            string result = RomanNumericalFunction.IntToRoman(input);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod()]
        public void IntToRomanTest13()
        {
            int input = 900;
            string expectedResult = "CM";

            string result = RomanNumericalFunction.IntToRoman(input);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod()]
        public void IntToRomanTest14()
        {
            int input = 1000;
            string expectedResult = "M";

            string result = RomanNumericalFunction.IntToRoman(input);

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void IntToRomanTest15()
        {
            RomanNumericalFunction.IntToRoman(-1);
        }

        [TestMethod()]
        public void IntToRomanTest16()
        {
            int input = 1955;
            string expectedResult = "MCMLV";

            string result = RomanNumericalFunction.IntToRoman(input);

            Assert.AreEqual(expectedResult, result);
        }
    }
}