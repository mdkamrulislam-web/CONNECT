using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class cubeMovement : MonoBehaviour
{
    private Transform tr;
    public float timer;
    public Boolean UpDownChq = false;
    void Start()
    {
        tr = GetComponent<Transform>();
        StartCoroutine("UpDown");
        tr.position = new Vector3(tr.position.x,Random.Range(1f, 5f), tr.position.z);
    }


    IEnumerator UpDown()
    {
        while (true)
        {
            timer = timer + Time.deltaTime;
            if (!UpDownChq)
            {
                if (tr.position.y > 5)
                {
                    UpDownChq = true;
                }
                transform.Translate(Vector3.up * Time.deltaTime * 2);
            }
            else
            {
                if (tr.position.y < 1.0)
                {
                    UpDownChq = false;
                }
                transform.Translate(-1*Vector3.up * Time.deltaTime * 2);
            }
           
           

            yield return null;
        }
    }
    

}
