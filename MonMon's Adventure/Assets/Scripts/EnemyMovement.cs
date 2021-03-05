using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public Transform enemy;
    public float speed = 3;
    public bool MoveRight;

    // Update is called once per frame


    void Update()
    {
        if (MoveRight)
        {
            enemy.Translate(2 * Time.deltaTime * speed, 0, 0);
            enemy.localScale = new Vector2(2, 2);
        }
        else
        {
            enemy.Translate(-2 * Time.deltaTime * speed, 0, 0);
            enemy.localScale = new Vector2(-2, 2);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("turn"))
        {
            MoveRight = !MoveRight;
        }
    }
}
