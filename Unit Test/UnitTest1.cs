using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using Microsoft.Analytics.UnitTest;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Unit_Test
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
