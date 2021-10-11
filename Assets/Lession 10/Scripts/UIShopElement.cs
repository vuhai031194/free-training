using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace lession10
{
    public class UIShopElement : MonoBehaviour
    {
        public int id;
        public int cost;
        public Text costTxt;

        public Button purchaseBtn;

        private void Awake()
        {
            purchaseBtn.onClick.AddListener(OnPurchase);
        }
        
        public void SetData()
        {
            // Check xem xe trong shop đã được mua hay chưa
            var canPurchase = !DataPlayer.kartData.kartList.Contains(id);
            purchaseBtn.enabled = canPurchase;
            
            if (canPurchase)
            {
                costTxt.text = cost.ToString();
            }
            else
            {
                costTxt.text = "Owned";
            }
        }
        
        private void OnPurchase()
        {
            DataPlayer.AddKart(id);

            SetData();
        }
    }
}
