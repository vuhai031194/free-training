using System;
using System.Collections;
using System.Collections.Generic;
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
            UIManager.Instance.player.gameObject.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
