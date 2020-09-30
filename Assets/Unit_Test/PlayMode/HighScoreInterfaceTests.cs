using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Unit_Test.PlayMode
{
    public class HighScoreInterfaceTests
    {
        [UnityTest]
        public IEnumerator ElementSetForUsingTest()
        {
            var gameObject = new GameObject();
            var highScore = gameObject.AddComponent<HighScoreInterface>();
            
            string jsonString = PlayerPrefs.GetString("Database");
            DataBase db = JsonUtility.FromJson<DataBase>(jsonString);
            string name = db.PlayerList[0].Name;
            int score = db.PlayerList[0].Score;
            highScore.ElementSetForUsing();
            
            yield return 2;
            Assert.AreEqual(name, Data.ReturnFirstName());
            Assert.AreEqual(score, Data.ReturnFirstScore());
            
        }

        [UnityTest]
        public IEnumerator ReturnFirstNameTest()
        {
            string name = HighScoreInterface.ReturnFirstName();
            string jsonString = PlayerPrefs.GetString("Database");
            DataBase db = JsonUtility.FromJson<DataBase>(jsonString);
            string n = db.PlayerList[0].Name;
            
            yield return 1;

            Assert.AreEqual(name, n);
        }
        
        [UnityTest]
        public IEnumerator ReturnFirstScoreTest()
        {
            int score = HighScoreInterface.ReturnFirstScore();
            string jsonString = PlayerPrefs.GetString("Database");
            DataBase db = JsonUtility.FromJson<DataBase>(jsonString);
            int n = db.PlayerList[0].Score;
            
            yield return 1;

            Assert.AreEqual(score, n);
        }

    }
    

}
