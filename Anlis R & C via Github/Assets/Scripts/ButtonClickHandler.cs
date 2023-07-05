using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClickHandler : MonoBehaviour
{

    [Header("UI")]
    public GameObject LobbyPanel;
    public GameObject CategorySelection;
    public GameObject LockerPanel;
    public GameObject ShopPanel;
    public GameObject CreditsPanel;

    [Header("Objects")]
    public GameObject Player;
    public GameObject Lobby;

   


    // Start is called before the first frame update
    void Start()
    {
        CategorySelection.SetActive(false);
        LockerPanel.SetActive(false);
        CreditsPanel.SetActive(false);
        ShopPanel.SetActive(false);
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
