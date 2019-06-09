using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public List<Image> Images;
    public GameObject QuitButton;
    bool isPaused = false;

    public void TogglePause()
    {
        isPaused = !isPaused;
        Time.timeScale = isPaused ? 0 : 1;
        Images.ForEach(image =>
        {
            image.color = isPaused ? Color.yellow : Color.grey;
        });
        QuitButton.SetActive(isPaused);
    }

    public void QuitGame()
    {
        Application.Quit();
    }


}
