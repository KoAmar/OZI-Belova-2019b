using NUnit.Framework;
using Lab7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.Tests
{
    [TestFixture()]
    public class MainTests
    {
        [Test()]
        public void ByteArrToIntTest()
        {

            Assert.AreEqual(65537, Main.ByteArrToInt(new byte[] {1,0,1}));
        }
    }
}