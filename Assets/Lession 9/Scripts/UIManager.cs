using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : Singleton<UIManager>
{
    public Animator uiMainAnimator;
    public GameObject uiRewardGameObject;
    public GameObject uiChapter;
    public GameObject player;
    
    public Button shopBtn;
    public Button chapterBtn;

    private void Awake()
    {
        shopBtn.onClick.AddListener(OnOpenShop);
        chapterBtn.onClick.AddListener(OnOpenChapter);
    }

    private void OnOpenShop()
    {
        player.gameObject.SetActive(false);
        uiRewardGameObject.SetActive(true);
    }
    
    private void OnOpenChapter()
    {
        uiMainAnimator.Play("out");
        player.gameObject.SetActive(false);
        uiChapter.SetActive(true);
    }
    
}
