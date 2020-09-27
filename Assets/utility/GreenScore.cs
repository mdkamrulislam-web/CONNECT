using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenScore : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        UpdateScore.PassScoreToDataGreenCapsule();
        Destroy(gameObject);

    }

    
}
