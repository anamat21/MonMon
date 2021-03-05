using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryControl : MonoBehaviour
{

    public GameObject inventoryMenu;
    public Animator animator;
    public void OpenInventory()
    {
        inventoryMenu.SetActive(true);

    }

    public void TurnOnGun()
    {
        animator.SetBool("HasGun", true);
        AcquireGun.hasGun = true;
    }

    public void CloseInventory()
    {
        inventoryMenu.SetActive(false);
    }
}
