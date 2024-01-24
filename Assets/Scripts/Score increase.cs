using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoreincrease : MonoBehaviour
{
    int score = 0;
    [SerializeField] Text Scoring;
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("ScoreObject"))
        {
            score++;
            Scoring.text = "Score: " + score;
            Debug.Log(score);
        }
        Debug.Log("h");
    }
    /*
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ScoreObject"))
        {
            score++;
            Scoring.text = "Score: " + score;
            Debug.Log(score);
        }
        Debug.Log("h");
    }
    */
}
