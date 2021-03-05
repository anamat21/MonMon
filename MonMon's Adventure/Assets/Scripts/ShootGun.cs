using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootGun : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform firePoint;
    public GameObject GunFire;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e") && AcquireGun.hasGun)
        {
            Instantiate(GunFire, firePoint.position, firePoint.rotation);
        }
    }
}
