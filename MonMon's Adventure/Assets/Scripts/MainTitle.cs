using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainTitle : MonoBehaviour
{
    // Start is called before the first frame update

    private void Beginning()
    {
        PlayerPrefs.SetInt("FirstTime", -1);
    }
    
    public void PlayButton()
    {
        PlayerPrefs.SetInt("FirstTime", PlayerPrefs.GetInt("FirstTime")+1);
        if (PlayerPrefs.GetInt("FirstTime") == 1)
        {
            SceneManager.LoadScene(1);
            
        }
        else
        {
            SceneManager.LoadScene(2);
        }

        Debug.Log(PlayerPrefs.GetInt("FirstTime"));
    }

    public void Reset()
    {
        PlayerPrefs.DeleteKey("FirstTime");
    }


}
