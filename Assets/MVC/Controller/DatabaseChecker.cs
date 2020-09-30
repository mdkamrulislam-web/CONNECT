using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class DatabaseChecker : MonoBehaviour
{
    public string k;
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("Database"))
        {
            Data.DataBaseCreation();
        }
        
       
        Debug.LogError(PlayerPrefs.GetString("Database"));
    }

    
}
