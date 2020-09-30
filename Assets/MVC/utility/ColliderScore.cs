using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderScore : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        UpdateScore.PassScoreToDataRedCube();
        
        Destroy(gameObject);
    }

   
}
