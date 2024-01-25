using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            SceneManager.LoadScene(1);
        }
    }
    public void RestartGane()
    {
        SceneManager.LoadScene(0);
    }
    public void ExitGame()
    {
        SceneManager.LoadScene(2);
    }
}
