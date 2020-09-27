using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScoreInterface : MonoBehaviour
{
    
    public void ElementSetForUsing()
    {
        Data.UpdateElements();
    }
    public static string ReturnFirstName()
    {
        return Data.ReturnFirstName();
    }
    public static string ReturnSecondName()
    {
        return Data.ReturnSecondName();
    }
    public static string ReturnThirdName()
    {
        return Data.ReturnThirdName();
    }
    public static int ReturnFirstScore()
    {
        return Data.ReturnFirstScore();
    }
    public static int ReturnSecondScore()
    {
        return Data.ReturnSecondScore();
    }
    public static int ReturnThirdScore()
    {
        return Data.ReturnThirdScore();
    }
}
