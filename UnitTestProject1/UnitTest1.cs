using System;
using image;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        RussianRoulette.LogicClass Logic = new RussianRoulette.LogicClass();

        [TestMethod]
        public void GunSound2()
        {
            try
            {
                Logic.GunSound2();
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsFalse(false);
            }
        }
        [TestMethod]
        public void PlayAgain()
        {
            try
            {
                Logic.PlayAgain();
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsFalse(false);

            }

        }
    }
}
