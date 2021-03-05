using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool GamePause = false;

    public GameObject PauseMenuPanel;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (GamePause)
            {
                Resume();
            }

            else
            {
                Pause();
            }

        }
    }

    public void Resume()
    {
        PauseMenuPanel.SetActive(false);
        Time.timeScale = 1;
        GamePause = false;
    }

    public void Pause()
    {
        PauseMenuPanel.SetActive(true);
        Time.timeScale = 0;
        GamePause = true;
    }
}
