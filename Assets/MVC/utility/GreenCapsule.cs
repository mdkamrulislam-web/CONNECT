using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenCapsule : MonoBehaviour
{
    public Transform tr;
    public bool ScaleChq = false;
    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
        StartCoroutine("ScaleChange");
    }

   IEnumerator ScaleChange()
    {
        while (true)
        {
            
            if (!ScaleChq)
            {
                if (tr.localScale.y > 2)
                {
                    ScaleChq = true;
                }
                tr.localScale = tr.localScale + (new Vector3(1f,1f,1f))*Time.deltaTime*1;
            }
            else
            {
                if (tr.localScale.y < 1)
                {
                    ScaleChq = false;
                }
                tr.localScale = tr.localScale + -1*(new Vector3(1f, 1f, 1f)) * Time.deltaTime * 1;
            }



            yield return null;
        }
    }
   
}
