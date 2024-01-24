using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject platformPrefab1;
    public GameObject ScoreObject;
    [SerializeField] TMP_Text Timer;
    public float initialSpawnDelay = 5f;  
    public float platformLifetime = 4f;
    public float spawnInterval = 2.5f;
    public float ScoreLifetime = 1f;

    private void Start()
    {
        InvokeRepeating("SpawnPlatform", initialSpawnDelay, spawnInterval);
    }
    void SpawnPlatform()
    {
        Vector3 pos1 = platformPrefab1.transform.position;
        Vector3 randompos = RandomDirection();
        Vector3 posi = new Vector3(pos1.x + randompos.x, 0, pos1.z + randompos.z); //Position for the platform and invisible score card(above platform)
        Vector3 posiT = new Vector3(pos1.x + randompos.x - 1.01f, 0.2f, pos1.z + randompos.z); //Position for the TimeCard
        GameObject newPlatform = Instantiate(platformPrefab1, posi, Quaternion.identity);
        GameObject scoreCard = Instantiate(ScoreObject, posi, Quaternion.identity);
        TMP_Text newTimer = Instantiate(Timer, posiT, Quaternion.Euler(90f, 0f, 90f));
        Destroy(newPlatform, platformLifetime);
        Destroy(scoreCard, ScoreLifetime);
        Destroy(newTimer, platformLifetime);
        platformPrefab1.transform.position = posi;
    }
    Vector3 RandomDirection()
    {
        int randomIndex = Random.Range(0, 4);
        Vector3 pos2;
        switch (randomIndex)
        {
            case 0:
                pos2 = new Vector3(6, 0, 0);
                break;
            case 1:
                pos2 = new Vector3(0, 0, 6);
                break;
            case 2:
                pos2 = new Vector3(-6, 0, 0);
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
