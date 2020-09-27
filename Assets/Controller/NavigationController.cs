using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NavigationController : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject GameScene;
    public GameObject GameOver;
    public GameObject HighScore;
    public playercontrol playcontrol;
    public GameObject TimerHandler;
    public void StartGameScene()
    {
        MainMenu.SetActive(false);
        GameScene.SetActive(true);
        TimerHandler.SetActive(true);
        playcontrol.playermovement = false;
    }

    public void StartGameOver()
    {
        GameScene.SetActive(false);
        GameOver.SetActive(true);
        
        TimerHandler.SetActive(false);
        playcontrol.playermovement = true;
    }

    public void StartMainMenuScene()
    {
        GameOver.SetActive(false);
        MainMenu.SetActive(true);
        Data.ResetScoreandResetTime();
        SceneManager.LoadScene(0);
    }
    public void StartHighScoreScene()
    {
        
        MainMenu.SetActive(false);
        HighScore.SetActive(true);
    }
    public void CloseHighScoreScene()
    {
        MainMenu.SetActive(true);
        HighScore.SetActive(false);
    }
}
