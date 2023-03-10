using NUnit.Framework;

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
            string input = "227#";
            string expected = "BP";

            // Act
            string result = PhoneNumber.checkSequence(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void CheckSequence_InputWithRepeatedDigits_ReturnsExpectedResult()
        {
            // Arrange
            string input = "4443#";
            string expected = "ID";

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
            string expected = "A";

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
            string expected = "C";

            // Act
            string result = PhoneNumber.checkSequence(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void CheckSequence_InputWithInvalidCharacters_ThrowsException()
        {
            // Arrange
            string input = "12X#";

            string expected = "&A";

            // Act
            string result = PhoneNumber.checkSequence(input);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void CheckSequence_InputWithLengthLessThan2_ReturnsEmptyString()
        {
            // Arrange
            string input = "#";

            // Act
            string result = PhoneNumber.checkSequence(input);

            // Assert
            Assert.IsEmpty(result);
        }

        [Test]
        public void CheckSequence_InputWithLengthLessThan1_ReturnsEmptyString()
        {
            // Arrange
            string input = "";

            // Act
            string result = PhoneNumber.checkSequence(input);

            // Assert
            Assert.IsEmpty(result);
        }
    }
}