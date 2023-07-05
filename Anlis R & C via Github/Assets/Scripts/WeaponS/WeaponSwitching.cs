using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitching : MonoBehaviour
{
    public GameObject Pistol;
    public GameObject AK;
    public GameObject Arms;

    // Start is called before the first frame update
    void Start()
    {
        Arms.SetActive(true);
        AK.SetActive(false);
        Pistol.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Arms.SetActive(false);
            AK.SetActive(true);
            Pistol.SetActive(false);
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Arms.SetActive(false);
            AK.SetActive(false);
            Pistol.SetActive(true);
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.V))
        {
            Arms.SetActive(true);
            AK.SetActive(false);
            Pistol.SetActive(false);
        }
        
    }
}
