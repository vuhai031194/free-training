using System;
using lession10;
using TigerForge;
using UnityEngine;
using UnityEngine.UI;

namespace Lession10
{
    public class UIManager : Singleton<UIManager>
    {
        public Animator uiMainAnimator;
        
        public GameObject uiRewardGameObject;
        public GameObject uiChapter;
        
        public Button shopBtn;
        public Button chapterBtn;

        private void Awake()
        {
            shopBtn.onClick.AddListener(OnOpenShop);
            chapterBtn.onClick.AddListener(OnOpenChapter);
        }

        private void OnOpenShop()
        {
            SetPlayerState(false);
            uiRewardGameObject.SetActive(true);
        }
    
        private void OnOpenChapter()
        {
            uiMainAnimator.Play("out");
            uiChapter.SetActive(true);
            SetPlayerState(false);
        }

        public void SetPlayerState(bool isActive)
        {
            EventManager.EmitEventData(EventName.TRIGGER_PRESENTER, isActive);
        }
        
    }

}
