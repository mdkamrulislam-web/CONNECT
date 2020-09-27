using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public static class Data
{
    private static int currentScore;
    private static int timer;
    private static string FirstName;
    private static string SecondName;
    private static string ThirdName;
    private static int FirstScore;
    private static int SecondScore;
    private static int ThirdScore;

    public static void IncreaseScore(int amount)
    {
        currentScore+=amount;

    }
    public static void ResetScoreandResetTime()
    {
        currentScore = 0;
        timer = 0;
    }
    public static int ReturnScore()
    {
        return currentScore;
    }
    public static int ReturnTimer()
    {
        return timer;
    }
    public static void UpdateTimeToData(int time)
    {
       
       
        timer = time;
    }

    public static void AddEntry(string name)
    {
        PlayerInformationEntry Entry = new PlayerInformationEntry { Name = name, Score = currentScore };
        string jsonString = PlayerPrefs.GetString("Database");
        DataBase db = JsonUtility.FromJson<DataBase>(jsonString);
        db.PlayerList.Add(Entry);
        SortList(db.PlayerList);
        db.PlayerList.RemoveRange(3, db.PlayerList.Count - 3);
        string jsonDB = JsonUtility.ToJson(db);
        PlayerPrefs.SetString("Database",jsonDB);
    }

    public static void UpdateElements()
    {
        string jsonString = PlayerPrefs.GetString("Database");
        DataBase db = JsonUtility.FromJson<DataBase>(jsonString);
        FirstName = db.PlayerList[0].Name;
        SecondName= db.PlayerList[1].Name;
        ThirdName = db.PlayerList[2].Name;
        FirstScore = db.PlayerList[0].Score;
        SecondScore = db.PlayerList[1].Score;
        ThirdScore = db.PlayerList[2].Score;
    }

    public static string ReturnFirstName()
    {
        return FirstName;
    }
    public static string ReturnSecondName()
    {
        return SecondName;
    }
    public static string ReturnThirdName()
    {
        return ThirdName;
    }
    public static int ReturnFirstScore()
    {
        return FirstScore;
    }
    public static int ReturnSecondScore()
    {
        return SecondScore;
    }
    public static int ReturnThirdScore()
    {
        return ThirdScore;
    }

    public static void SortList(List<PlayerInformationEntry> playerList)
    {
        for(int i=0;i<(playerList.Count);i++)
        {
            for(int j=i+1;j< (playerList.Count);j++)
            {
                if(playerList[j].Score> playerList[i].Score)
                {
                    PlayerInformationEntry tmp = playerList[j];
                    playerList[j] = playerList[i];
                    playerList[i] = tmp;
                }
            }
        }
    }
    public static void DataBaseCreation()
    {
        List<PlayerInformationEntry> samplePlayer = new List<PlayerInformationEntry>()
            { new PlayerInformationEntry {Name="AAA",Score=0 },
              new PlayerInformationEntry {Name="AAA",Score=0 },
              new PlayerInformationEntry {Name="AAA",Score=0 }
            };
        DataBase db = new DataBase(samplePlayer);

        string jsonDB = JsonUtility.ToJson(db);

        PlayerPrefs.SetString("Database",jsonDB  );
    }
}
