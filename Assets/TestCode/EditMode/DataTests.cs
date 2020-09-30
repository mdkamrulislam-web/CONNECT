using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace TestCode.EditMode
{
    public class DataTests
    {
        [Test]
        public void IncreaseScoreTest()
        {
            int score = Data.ReturnScore();
            Data.IncreaseScore(5);
            
            Assert.AreEqual(score+5, Data.ReturnScore());
        }

        [Test]
        public void ResetScoreandResetTimeTest()
        {
            Data.ResetScoreandResetTime();
            Assert.AreEqual(0, Data.ReturnScore());
            Assert.AreEqual(0, Data.ReturnTimer());
        }

        [Test]
        public void UpdateTimeToDataTest()
        {
            Data.UpdateTimeToData(3);
            Assert.AreEqual(3, Data.ReturnTimer());
        }

        [Test]
        public void AddEntryTest()
        {
            Data.AddEntry("Shuvo");
            string jsonString = PlayerPrefs.GetString("Database");
            DataBase db = JsonUtility.FromJson<DataBase>(jsonString);
            Assert.AreEqual("Shuvo", db.PlayerList[0].Name);
        }

        [Test]
        public void UpdateElementsTest()
        {
            Data.UpdateElements();
            string jsonString = PlayerPrefs.GetString("Database");
            DataBase db = JsonUtility.FromJson<DataBase>(jsonString);
            
            Assert.AreEqual("Shuvo", db.PlayerList[0].Name);
            Assert.AreEqual(21, db.PlayerList[2].Score);
        }

        [Test]
        public void SortTest()
        {
            Data.SortList(new List<PlayerInformationEntry>());
            string jsonString = PlayerPrefs.GetString("Database");
            DataBase db = JsonUtility.FromJson<DataBase>(jsonString);
            int first = db.PlayerList[0].Score;
            int second = db.PlayerList[1].Score;
            bool check = false;
            if (first > second) check = true;
            
            Assert.AreEqual(true, check);
        }
        
        
        
    }
}
