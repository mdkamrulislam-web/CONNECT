using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiation : MonoBehaviour
{
    
    public Quaternion a;
    public GameObject cube;
    public GameObject capsule;
    private int counter;
    public static Instantiation instance;
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        
        CubeInstantiate();
    }

    public void CubeInstantiate()
    {
        counter++;
        a.eulerAngles = new Vector3(0, Random.Range(0, 90), 0);
        Instantiate(cube, new Vector3(Random.Range(-40,43),0,Random.Range(10,83)), a);
        if(counter==5)
        {
            Instantiate(capsule, new Vector3(Random.Range(-40, 43), 2.92f, Random.Range(10, 83)), a);
            counter = 0;
        }
    }
    // Update is called once per frame
   
}
