using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("up") || Input.GetKey("w"))
        {
            rb.velocity = new Vector3(-5, 0, 0);
        }
        if (Input.GetKey("down") || Input.GetKey("s"))
        {
            rb.velocity = new Vector3(5, 0, 0);
        }
        if (Input.GetKey("left") || Input.GetKey("a"))
        {
            rb.velocity = new Vector3(0, 0, -5);
        }
        if (Input.GetKey("right") || Input.GetKey("d"))
        {
            rb.velocity = new Vector3(0, 0, 5);
        }
    }
}
