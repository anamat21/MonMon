using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10f;

    public Transform player;

    public Transform firePoint;

    public float jumpHeight = 1f;

    public Animator animator;

    public Rigidbody2D playerRB;

    public Collider2D floor;

    public static bool isDead = false;

    public bool facingRight = true;

    public bool ground = true;

    private void Start()
    {
        isDead = false;
        AcquireGun.hasGun = false;
    }
    void Update()
    {
        if (!isDead) {
            //horizontal moving
            float move = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            animator.SetFloat("Speed", Mathf.Abs(move));

            if (move > 0 && !facingRight)
            {
                Flip();
            }

            else if (move < 0 && facingRight)
            {
                Flip();
            }
            

            player.Translate(move, 0, 0);

            //jumping
            if (Input.GetKeyDown("space") && ground)
            {
                if (playerRB.gravityScale == 1)
                {
                    playerRB.AddForce(player.up * jumpHeight, ForceMode2D.Impulse);
                }

                else
                {
                    playerRB.AddForce(-player.up * jumpHeight, ForceMode2D.Impulse);
                }

                ground = false;

            }

            if (ground)
            {
                animator.SetBool("Jump", false);
            }

            if (!ground)
            {
                animator.SetBool("Jump", true);
            }
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("ground") || playerRB.IsTouching(floor))
        {
            ground = true;
        }
    }

    void Flip()
    {
        player.localScale = new Vector2(player.localScale.x * -1, player.localScale.y);

        firePoint.Rotate(0f, 180f, 0f);

        facingRight = !facingRight;
    }
}
