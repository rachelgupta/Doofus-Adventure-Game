using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject platformPrefab1;
    public GameObject platformPrefab2;
    public float initialSpawnDelay = 2.5f;  
    public float platformLifetime = 2.5f;
    public float spawnInterval = 2.5f;

    private void Start()
    {
        InvokeRepeating("SpawnPlatform", initialSpawnDelay, spawnInterval);
    }
    void SpawnPlatform()
    {
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
    
}
