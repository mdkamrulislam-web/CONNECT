using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Unit_Test.EditMode
{
    public class UpdateTimerTest
    {
        [Test]
        public void UpdateTimerTestSimplePasses()
        {
            int time = Data.ReturnTimer();
            Data.UpdateTimeToData(5);
            
            Assert.AreEqual(Data.ReturnTimer(),time+5);
        }
    }
}
