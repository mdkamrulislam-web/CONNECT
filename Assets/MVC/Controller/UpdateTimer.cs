using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateTimer 
{
    public static void updateTime(int time)
    {
        Data.UpdateTimeToData(time);
        ShowTimeToUI();
    }

    public static void ShowTimeToUI()
    {
        ShowTimer.instance.UpdateTimerUI(Data.ReturnTimer());
    }
}
