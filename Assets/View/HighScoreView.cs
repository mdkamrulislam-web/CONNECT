using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreView : MonoBehaviour
{
    public Text Highscore;
    public Font font;
    public Image background;
    public Image closebutton;
    public Sprite close;
    public Text Name1;
    public Text Name2;
    public Text Name3;
    public Text Score1;
    public Text Score2;
    public Text Score3;
    // Start is called before the first frame update
    private void OnEnable()
    {
        Name1.text = HighScoreInterface.ReturnFirstName();
        Name2.text = HighScoreInterface.ReturnSecondName();
        Name3.text = HighScoreInterface.ReturnThirdName();
        Score1.text = HighScoreInterface.ReturnFirstScore().ToString();
        Score2.text = HighScoreInterface.ReturnSecondScore().ToString();
        Score3.text = HighScoreInterface.ReturnThirdScore().ToString();
    }
    void Start()
    {
        background.color= new Color32(0, 0, 0, 255);
        Highscore.font = font;
        Highscore.fontSize = 65;
        Highscore.text = "HIGHSCORE";
        closebutton.sprite = close;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
