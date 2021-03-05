using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{
    public Transform player;
    public GameObject GameOverPanel;
    public float initialPosition;
    public float finalPosition;

    // Update is called once per frame

    private void Start()
    {
        initialPosition = player.position.y-10;
        finalPosition = player.position.y + 30;
    }

    void Update()
    {
        if(player.position.y < initialPosition || player.position.y > finalPosition)
        {
            DieMethod();
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("enemy"))
        {
            DieMethod();
        }
    }
    void DieMethod()
    {
        //play animation
        //put gameover tab
        //Time.timeScale = 0f;
        Movement.isDead = true;
        GameOverPanel.SetActive(true);
        
    }
}
