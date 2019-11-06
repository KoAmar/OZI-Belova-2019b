using NUnit.Framework;
using CipherLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace CipherLib.Tests
{
    [TestFixture()]
    public class CipherTests
    {
        [Test()]
        public void DecryptTest()
        {
            var key = new CipherLib.Key("size");
            Assert.AreEqual("schwarzenegger", CipherLib.Cipher.Decrypt("llhbtazjgnglxa", key));
        }

        [Test()]
        public void Test()
        {
            Assert.AreEqual(26, Alphabet.GetAlphabetIndex('z'));
        }
        [Test()]
        public void Test2()
        {
            Assert.AreEqual('z', Alphabet.GetChar(26));
        }
    }
}