using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Unit_Test.PlayMode
{
    public class ShowingUIScoreTest
    {
        [UnityTest]
        public IEnumerator UpdateScoreUITest()
        {
            var obj = new GameObject();
            var uiscore = obj.AddComponent<ShowingUIScore>();
            uiscore.UpdateScoreUI(10);
            yield return 5;
            
            Assert.AreEqual(10.ToString(), uiscore.Score.text);
        }
    }
}
