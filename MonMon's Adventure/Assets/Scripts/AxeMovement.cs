using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject axe;
    public bool MoveRight;
    public float speed = 10;
    public float distance = 7;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotationPoint = new Vector3(axe.transform.position.x, axe.transform.position.y + distance, axe.transform.position.z);

        if (MoveRight)
        {
            transform.RotateAround(rotationPoint, Vector3.forward, speed * Time.deltaTime);
        }
        else
        {
            transform.RotateAround(rotationPoint, Vector3.back, speed * Time.deltaTime);
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
