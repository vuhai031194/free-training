using System;
using System.Collections;
using System.Collections.Generic;
using TigerForge;
using UnityEngine;
using UnityEngine.UI;

namespace Lession10
{
    public class UIChapter : MonoBehaviour
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
            UIManager.Instance.uiMainAnimator.Play("in");
        }

        public void HideShopEvent()
        {
            EventManager.EmitEventData(EventName.TRIGGER_PRESENTER, true);
            gameObject.SetActive(false);
        }
    }
}
