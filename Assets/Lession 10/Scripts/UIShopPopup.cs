using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIShopPopup : MonoBehaviour
{
    public Animator animator;
    public Button hideBtn;

    private void Awake()
    {
        hideBtn.onClick.AddListener(OnHideShop);
    }

    public void OnHideShop()
    {
        animator.Play("out");
    }


    public void HideShopEvent()
    {
        UIController.instance.player.SetActive(true);
        gameObject.SetActive(false);
    }
}
