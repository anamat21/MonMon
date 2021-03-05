using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manger : MonoBehaviour
{
    // Start is called before the first frame update
    public void Quit()
    {
        Application.Quit();
        Time.timeScale = 1f;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;

    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1f;
    }
}
