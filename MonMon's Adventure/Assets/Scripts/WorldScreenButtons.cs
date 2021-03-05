using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WorldScreenButtons : MonoBehaviour
{
    // Start is called before the first frame update
    public void BackButton()
    {
        if(SceneManager.GetActiveScene().buildIndex == 2)
        {
            SceneManager.LoadScene(0);
        }

        else if(SceneManager.GetActiveScene().buildIndex == 3 
            || SceneManager.GetActiveScene().buildIndex == 4
            || SceneManager.GetActiveScene().buildIndex == 5
            || SceneManager.GetActiveScene().buildIndex == 6)
        {
            SceneManager.LoadScene(2);
        }

        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
            
    }

    public void ToLair()
    {
        SceneManager.LoadScene(6);
    }

    public void ToWorldOne()
    {
        SceneManager.LoadScene(3);
    }

    public void ToWorldTwo()
    {
        SceneManager.LoadScene(4);
    }

    public void ToWorldThree()
    {
        SceneManager.LoadScene(5);
    }
}
