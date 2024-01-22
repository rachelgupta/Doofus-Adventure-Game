using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject platformPrefab1;
    public GameObject platformPrefab2;
    private void Update()
    {
        //Vector3 randomSpawn = new Vector3(Random.Range(-10, 11), 5, Random.Range(-10, 11));
        //Instantiate(platformPrefab, randomSpawn, Quaternion.identity);
        if(Input.GetKeyDown("space"))
        {
            Vector3 pos1 = platformPrefab1.transform.position;
            Vector3 posi = new Vector3(pos1.x + 8, 0, pos1.z + 6);
            Instantiate(platformPrefab2, posi, Quaternion.identity);
        }
        
    }

}
