using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowingUIScore : MonoBehaviour
{
    
    public Text Score;
    public static ShowingUIScore instance;
    private void Awake()
    {
        instance = this;
    }
    
    public void UpdateScoreUI(int score)
    {
        Score.text = score.ToString();
    }
}
