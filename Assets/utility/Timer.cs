using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public int timer;
    public GameObject GameOver;
    public NavigationController nav;
    
    private void OnEnable()
    {
        timer = 120;
        Invoke("UpdateTime", 1f);
    }
    void UpdateTime()
    {
        timer--;
        
        UpdateTimer.updateTime(timer);
        if (timer == 0)
        {
            nav.StartGameOver();
            
        }
        else
        {
            Invoke("UpdateTime", 1f);
        }
    }
    

}
