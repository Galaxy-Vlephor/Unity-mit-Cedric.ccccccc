using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSetup : MonoBehaviour
{
    public SFPSC_PlayerMovement movement;
   
    public GameObject MainCamera;
    public GameObject WeaponCamera;

    public void IsLocalPlayer()
    {
        movement.enabled = true;

        MainCamera.SetActive(true);
        WeaponCamera.SetActive(true);
    }
}
