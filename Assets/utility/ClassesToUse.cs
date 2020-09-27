using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DataBase
{
    public List<PlayerInformationEntry> PlayerList;
    public DataBase(List<PlayerInformationEntry> PlayerList)
    {
        this.PlayerList = PlayerList;
    }
}
[System.Serializable]
public class PlayerInformationEntry
{
    public string Name;
   public int Score;
}