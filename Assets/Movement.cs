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
        if(Input.GetKey("up"))
        {
            rb.velocity = new Vector3(-5, 0, 0);
        }
        if (Input.GetKey("down"))
        {
            rb.velocity = new Vector3(5, 0, 0);
        }
        if (Input.GetKey("left"))
        {
            rb.velocity = new Vector3(0, 0, -5);
        }
        if (Input.GetKey("right"))
        {
            rb.velocity = new Vector3(0, 0, 5);
        }
    }
}
