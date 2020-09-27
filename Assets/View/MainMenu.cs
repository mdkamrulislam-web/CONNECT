using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Image BackGround;
    public Text TextTitle;
    public Font Font1;
    public Font Font2;
    public Text Play;
    public Text HighScore;
    public Text Exit;
    public Image PlayButton;
    public Sprite playButton;
    public Image HighScoreButton;
    public Sprite highScoreButton;
    public Image ExitButton;
    public Sprite exitButton;
    private void Start()
    {
        BackGround.color = new Color32(0,0,0,255);
        TextTitle.fontSize = 77;
        TextTitle.text = "RedGame";
        TextTitle.font = Font1;
        TextTitle.color = Color.white;
        Play.font = Font2;
        Play.fontSize = 32;
        Play.text = "PLAY";
        Play.color = Color.white;
        HighScore.text = "HIGHSCORE";
        HighScore.font = Font2;
        HighScore.fontSize = 32;
        HighScore.color = Color.white;
        Exit.text = "EXIT";
        Exit.font = Font2;
        Exit.fontSize = 32;
        Exit.color = Color.white;
        PlayButton.sprite = playButton;
        HighScoreButton.sprite = highScoreButton;
        ExitButton.sprite = exitButton;
    }
}
