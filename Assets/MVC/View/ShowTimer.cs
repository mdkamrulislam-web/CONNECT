using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowTimer : MonoBehaviour
{
    public Text Timer;
    public static ShowTimer instance;
    private void Awake()
    {
        instance = this;
    }
    public void UpdateTimerUI(int time)
    {
        Timer.text = time.ToString();
    }
}
