using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Image BackGround;
    public Text GameOverTitle;
    public Text Score;
    public Font Font1;
    public Font Font2;
    public Text Confirm;
    public Image ConfirmButton;
    public Sprite confirmButton;
    public Image InputField;
    public Sprite input;

    private void Start()
    {
        BackGround.color = new Color32(255, 255, 255, 136);
        Score.text = UpdateScore.GetScore().ToString();
        GameOverTitle.fontSize = 75;
        GameOverTitle.text = "GAME OVER";
        GameOverTitle.font = Font1;
        GameOverTitle.color = Color.black;
        InputField.sprite = input;
        ConfirmButton.sprite = confirmButton;
        Confirm.font = Font2;
        
    }
}
