using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    private void Update()
    {
        if(Input.touches.Length > 0)
        {
            StartGame();
        }
    }


    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
