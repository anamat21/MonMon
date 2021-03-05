using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcquireGun : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Bubble;
    public Animator animator;
    public GameObject Panel;
    public static bool hasGun = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        hasGun = true;
        Bubble.SetActive(false);
        animator.SetBool("HasGun", true);
        Panel.SetActive(true);
        Invoke("DeActivatePanel", 4);
    }

    void DeActivatePanel()
    {
        Panel.SetActive(false);
    }
}
