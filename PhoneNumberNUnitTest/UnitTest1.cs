using NUnit.Framework;
using System;

namespace PhoneNumberNUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void TestInput_Asterisk()
        {
            string expectedOutput = "";
            string actualOutput = PhoneNumber.checkSequence("*");
            Assert.AreEqual(expectedOutput, actualOutput);
        }
        [Test]
        public void CheckSequence_InputWithOneDigit_ReturnsExpectedResult()
        {
            // Arrange
            string input = "3";
            string expected = "D";

            // Act
            string result = PhoneNumber.checkSequence(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void CheckSequence_InputWithMultipleDigits_ReturnsExpectedResult()
        {
            // Arrange
            string input = "227";
            string expected = "B";

            // Act
            string result = PhoneNumber.checkSequence(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void CheckSequence_InputWithRepeatedDigits_ReturnsExpectedResult()
        {
            // Arrange
            string input = "4443";
            string expected = "I";

            // Act
            string result = PhoneNumber.checkSequence(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void CheckSequence_InputWithSpecialCharacters_ReturnsExpectedResult()
        {
            // Arrange
            string input = "22*2#";
            string expected = "B";

            // Act
            string result = PhoneNumber.checkSequence(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void CheckSequence_InputWithDigitsAndSpecialCharacters_ReturnsExpectedResult()
        {
            // Arrange
            string input = "11* 222#";
            string expected = "'A C";

            // Act
            string result = PhoneNumber.checkSequence(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void CheckSequence_InputWithInvalidCharacters_ThrowsException()
        {
            // Arrange
            string input = "12X";

            // Act & Assert
            Assert.Throws<ArgumentException>(() => PhoneNumber.checkSequence(input));
        }

        [Test]
        public void CheckSequence_InputWithLengthLessThan2_ReturnsEmptyString()
        {
            // Arrange
            string input = "1";

            // Act
            string result = PhoneNumber.checkSequence(input);

            // Assert
            Assert.IsEmpty(result);
        }

        [Test]
        public void CheckSequence_InputWithLengthMoreThan20_ThrowsException()
        {
            // Arrange
            string input = "12345678901234567890";

            // Act & Assert
            Assert.Throws<ArgumentException>(() => PhoneNumber.checkSequence(input));
        }
    }
}