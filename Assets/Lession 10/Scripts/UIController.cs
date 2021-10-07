using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public static UIController instance;
    public Button uiShopBtn;
    
    public GameObject uiShopGameObject;
    public GameObject player;
    private void Awake()
    {
        instance = this;
        uiShopBtn.onClick.AddListener(OnOpenShop);
    }

    private void OnOpenShop()
    {
        player.SetActive(false);
        uiShopGameObject.SetActive(true);
    }
}
