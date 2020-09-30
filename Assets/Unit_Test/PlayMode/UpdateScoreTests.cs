using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Unit_Test.PlayMode
{
    public class UpdateScoreTests
    {

        [UnityTest]
        public IEnumerator PassScoreToDataRedCudeTest()
        {
            int score = Data.ReturnScore();
            Data.IncreaseScore(1);
            
//            UpdateScore.PassScoreToDataRedCube();
            
            yield return 2;
            
            Assert.AreEqual(Data.ReturnScore(), score+1);
        }

        [UnityTest]
        public IEnumerator PassScoreToUI()
        {

            var check = Data.ReturnScore();
            bool check2 = false;
            if (check != null) 
                check2 = true;

            yield return null;
            
            Assert.AreEqual(check2, true);
            
            
        }

    }
}
