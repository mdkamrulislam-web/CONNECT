using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiniMap : MonoBehaviour
{
    public Texture cam1;
    public RawImage rawimg;
    void Start()
    {
        rawimg.texture = cam1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
