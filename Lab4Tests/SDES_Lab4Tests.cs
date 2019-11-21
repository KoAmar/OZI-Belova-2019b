using Lab4;
using NUnit.Framework;
using System;

namespace Lab4Tests
{
    [TestFixture]
    public class SDES_Lab4Tests
    {
        [Test]
        public void Encrypt_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            string textKey = "412";
            char message = 'f';

            // Act
            var result = SDES_Lab4.Encrypt(
                textKey,
                message);

            // Assert
            Assert.AreEqual("01100000",result);
        }

        [Test]
        public void Decrypt_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            string textKey = "412";
            string chiperText = "01100000";

            // Act
            var result = SDES_Lab4.Decrypt(
                textKey,
                chiperText);

            // Assert
            Assert.AreEqual('f',result);
        }
    }
}
