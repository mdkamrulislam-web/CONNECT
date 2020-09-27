using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class playercontrol : MonoBehaviour
{
    public Rigidbody rb;
    public Transform tr;
    public float MoveForce;
    public bool playermovement;
    void Start()
    {
        playermovement = true;
        rb = GetComponent<Rigidbody>();
        tr = GetComponent<Transform>();
        MoveForce = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (!playermovement)
        {
            rb.constraints = RigidbodyConstraints.None;
            if (Input.GetKey(KeyCode.W))
            {
                rb.AddForce(new Vector3(0f, 0f, 1f) * MoveForce);
                //  transform.Rotate(new Vector3(0f, 3f, 0f));
            }
            if (Input.GetKey(KeyCode.A))
            {
                rb.AddForce(new Vector3(-1f, 0f, 0f) * MoveForce);
                //  transform.Rotate(new Vector3(0f, 3f, 0f));
            }
            if (Input.GetKey(KeyCode.D))
            {
                rb.AddForce(new Vector3(1f, 0f, 0f) * MoveForce);
                //  transform.Rotate(new Vector3(0f, 3f, 0f));
            }
            if (Input.GetKey(KeyCode.S))
            {
                rb.AddForce(new Vector3(0f, 0f, -1f) * MoveForce);
                //  transform.Rotate(new Vector3(0f, 3f, 0f));
            }
        }
        else
        {
            rb.constraints = RigidbodyConstraints.FreezeAll;
            
        }

    }
}
