using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformScript : MonoBehaviour
{
    public Transform thePlatform;
    public float speed = 3;
    public bool movingDown = true;

    private void Update()
    {
        if (movingDown)
        {
            moveDown();
        }
        else
        {
            moveUp();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("turnVertical"))
        {
            movingDown = !movingDown;
        }
    }

    void moveUp()
    {
        thePlatform.Translate(Vector3.up* Time.deltaTime * speed);
    }

    void moveDown()
    {
        thePlatform.Translate(Vector3.down * Time.deltaTime * speed);
    }

}
