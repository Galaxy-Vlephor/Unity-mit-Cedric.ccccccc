using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class HomeMenu : MonoBehaviour
{
    [Header("Variables")]
    public bool inLobby;

    [Header("UI")]
    public GameObject LobbyPanel;
    public GameObject CategorySelection;
    public GameObject LockerPanel;
    public GameObject ShopPanel;
    public GameObject CreditsPanel;

    [Space]

    [Header("Objects")]
    public GameObject Player;
    public GameObject Lobby;

    // Start is called before the first frame update
    void Start()
    {
        inLobby = true;
        Lobby.SetActive(true);
        LobbyPanel.SetActive(true);
        LockerPanel.SetActive(false);
        ShopPanel.SetActive(false);
        CreditsPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoShop()
    {

        if (!inLobby)
        {
            Player.SetActive(false);
            Lobby.SetActive(false);
            LobbyPanel.SetActive(false);
            LockerPanel.SetActive(false);
            ShopPanel.SetActive(true);
            CreditsPanel.SetActive(false);
        }
        else
        {
            LobbyPanel.SetActive(false);
            LockerPanel.SetActive(false);
            ShopPanel.SetActive(true);
            CreditsPanel.SetActive(false);
        }
        

    }

    public void GoLobby()
    {
        Player.SetActive(true);
        Lobby.SetActive(true);
        LobbyPanel.SetActive(true);
        LockerPanel.SetActive(false);
        ShopPanel.SetActive(false);
        CreditsPanel.SetActive(false);
    }

    public void GoLocker()
    {
        Player.SetActive(true);
        Lobby.SetActive(true);
        LobbyPanel.SetActive(false);
        LockerPanel.SetActive(true);
        ShopPanel.SetActive(false);
        CreditsPanel.SetActive(false);
    }

    public void GoCredits()
    {
        Player.SetActive(true);
        Lobby.SetActive(true);
        LobbyPanel.SetActive(false);
        LockerPanel.SetActive(false);
        ShopPanel.SetActive(false);
        CreditsPanel.SetActive(true);
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(1);
    }




}
