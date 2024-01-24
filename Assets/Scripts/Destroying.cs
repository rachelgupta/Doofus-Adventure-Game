using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroying : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject AnObject;
    public float Lifetime = 7.5f;
    void Start()
    {
        Destroy(AnObject, Lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
