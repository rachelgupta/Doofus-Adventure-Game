using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroying : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject newPulpit;
    void Start()
    {
        Destroy(newPulpit, 7.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
