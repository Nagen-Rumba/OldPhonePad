using NUnit.Framework;
<<<<<<< HEAD
=======
using System;
>>>>>>> 0a63710de8bef26935e07d14e1ec6ba0bcead9b9

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
<<<<<<< HEAD
        public void TestInput_ManyAsterisk()
        {
            string expectedOutput = "";
            string actualOutput = PhoneNumber.checkSequence("**#");
            Assert.AreEqual(expectedOutput, actualOutput);
        }
        [Test]
        public void CheckSequence_InputWithOneDigit_ReturnsExpectedResult()
        {
            // Arrange
            string input = "3#";
=======
        public void CheckSequence_InputWithOneDigit_ReturnsExpectedResult()
        {
            // Arrange
            string input = "3";
>>>>>>> 0a63710de8bef26935e07d14e1ec6ba0bcead9b9
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
<<<<<<< HEAD
            string input = "227#";
            string expected = "BP";
=======
            string input = "227";
            string expected = "B";
>>>>>>> 0a63710de8bef26935e07d14e1ec6ba0bcead9b9

            // Act
            string result = PhoneNumber.checkSequence(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void CheckSequence_InputWithRepeatedDigits_ReturnsExpectedResult()
        {
            // Arrange
<<<<<<< HEAD
            string input = "4443#";
            string expected = "ID";
=======
            string input = "4443";
            string expected = "I";
>>>>>>> 0a63710de8bef26935e07d14e1ec6ba0bcead9b9

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
<<<<<<< HEAD
            string expected = "A";
=======
            string expected = "B";
>>>>>>> 0a63710de8bef26935e07d14e1ec6ba0bcead9b9

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
<<<<<<< HEAD
            string expected = "C";
=======
            string expected = "'A C";
>>>>>>> 0a63710de8bef26935e07d14e1ec6ba0bcead9b9

            // Act
            string result = PhoneNumber.checkSequence(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void CheckSequence_InputWithInvalidCharacters_ThrowsException()
        {
            // Arrange
<<<<<<< HEAD
            string input = "12X#";

            string expected = "&A";

            // Act
            string result = PhoneNumber.checkSequence(input);

            // Assert
            Assert.AreEqual(expected, result);
=======
            string input = "12X";

            // Act & Assert
            Assert.Throws<ArgumentException>(() => PhoneNumber.checkSequence(input));
>>>>>>> 0a63710de8bef26935e07d14e1ec6ba0bcead9b9
        }

        [Test]
        public void CheckSequence_InputWithLengthLessThan2_ReturnsEmptyString()
        {
            // Arrange
<<<<<<< HEAD
            string input = "#";
=======
            string input = "1";
>>>>>>> 0a63710de8bef26935e07d14e1ec6ba0bcead9b9

            // Act
            string result = PhoneNumber.checkSequence(input);

            // Assert
            Assert.IsEmpty(result);
        }

        [Test]
<<<<<<< HEAD
        public void CheckSequence_InputWithLengthLessThan1_ReturnsEmptyString()
        {
            // Arrange
            string input = "";

            // Act
            string result = PhoneNumber.checkSequence(input);

            // Assert
            Assert.IsEmpty(result);
=======
        public void CheckSequence_InputWithLengthMoreThan20_ThrowsException()
        {
            // Arrange
            string input = "12345678901234567890";

            // Act & Assert
            Assert.Throws<ArgumentException>(() => PhoneNumber.checkSequence(input));
>>>>>>> 0a63710de8bef26935e07d14e1ec6ba0bcead9b9
        }
    }
}