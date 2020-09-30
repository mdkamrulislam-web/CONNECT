using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateScore : MonoBehaviour
{
    // Start is called before the first frame update
    public static void PassScoreToDataRedCube()
    {
        Data.IncreaseScore(1);
        PassScoreToUI();
    }
    public static void PassScoreToUI()
    {
        ShowingUIScore.instance.UpdateScoreUI(Data.ReturnScore());
        Instantiation.instance.CubeInstantiate();
    }
    public static void PassScoreToDataGreenCapsule()
    {
        Data.IncreaseScore(5);
        PassScoreToUI();
    }
    public static int GetScore()
    {
        return Data.ReturnScore();
    }
}
