using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GravityChangerScript : MonoBehaviour
{

    public GameObject player;
    public GameObject gravityChange;

    public int count = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    void Update()
    {
        
        if (Math.Abs(player.transform.position.x - gravityChange.transform.position.x) < 0.5
            && Math.Abs(player.transform.position.y - gravityChange.transform.position.y) < 0.5 && count <1)
        {

            player.GetComponent<Rigidbody2D>().gravityScale = -(player.GetComponent<Rigidbody2D>().gravityScale);

            player.transform.localScale = new Vector2(player.transform.localScale.x, player.transform.localScale.y * -1);

            count++;
        }

    }

    void Change_Gravity()
    {
        
    }

}
