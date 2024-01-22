using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject platformPrefab1;
    public GameObject platformPrefab2;
    public float initialSpawnDelay = 3f;  
    public float platformLifetime = 5f;
    public float spawnInterval = 2f;

    private void Start()
    {
        platformPrefab2 = platformPrefab1;
        //Destroy(platformPrefab1, platformLifetime);
        InvokeRepeating("SpawnPlatform", initialSpawnDelay, spawnInterval);
    }
    void SpawnPlatform()
    {
        /*platformPrefab2 = platformPrefab1;
        Destroy(platformPrefab1, platformLifetime);
        Vector3 pos1 = platformPrefab1.transform.position;
        Vector3 randompos = RandomDirection();
        Vector3 posi = new Vector3(pos1.x + randompos.x, 0, pos1.z + randompos.z);
        Instantiate(platformPrefab1, posi, Quaternion.identity);
        //Destroy(platformPrefab1, platformLifetime);
        platformPrefab1.transform.position = posi;*/


        Vector3 pos1 = platformPrefab2.transform.position;
        Vector3 randompos = RandomDirection();
        Vector3 posi = new Vector3(pos1.x + randompos.x, 0, pos1.z + randompos.z);
        GameObject newPlatform = Instantiate(platformPrefab2, posi, Quaternion.identity);
        Destroy(newPlatform, platformLifetime);
        platformPrefab2.transform.position = posi;
    }
    Vector3 RandomDirection()
    {
        int randomIndex = Random.Range(0, 4);
        Vector3 pos2;
        switch (randomIndex)
        {
            case 0:
                pos2 = new Vector3(8, 0, 0);
                break;
            case 1:
                pos2 = new Vector3(0, 0, 6);
                break;
            case 2:
                pos2 = new Vector3(-8, 0, 0);
                break;
            case 3:
                pos2 = new Vector3(0, 0, -6);
                break;
            default:
                pos2 = new Vector3(0, 0, 0);
                break;
        }
        return pos2;
    }
    /*
    private void Update()
    {
        //Vector3 randomSpawn = new Vector3(Random.Range(-10, 11), 5, Random.Range(-10, 11));
        //Instantiate(platformPrefab, randomSpawn, Quaternion.identity);
        if(Input.GetKeyDown("space"))
        {
            Vector3 pos1 = platformPrefab1.transform.position;
            Vector3 posi = new Vector3(pos1.x + 6, 0, pos1.z);
            Instantiate(platformPrefab2, posi, Quaternion.identity);
            platformPrefab2.transform.position = posi;
        }
        
        //InvokeRepeating("SpawnPlatform", initialSpawnDelay, spawnInterval);
    }
    */
}
