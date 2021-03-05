using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinningLevel : MonoBehaviour
{

    public GameObject player;
    public GameObject portal;
    public Animator animator;
    public GameObject panel;

    // Update is called once per frame
    void Update()
    {
        
        if((int)player.transform.position.x == (int)portal.transform.position.x 
            && (int)player.transform.position.y == (int)portal.transform.position.y)
        {
            player.SetActive(false);
            animator.SetBool("Completed", true);
            panel.SetActive(true);
        }

    }
}
