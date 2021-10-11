using System;
using System.Collections;
using System.Collections.Generic;
using lession10;
using UnityEngine;
using UnityEngine.UI;

public class MoneyBarView : MonoBehaviour
{
    public Text text;

    public void UpdateCoin()
    {
        text.text = DataPlayer.kartData.coin.ToString();
    }
    

    private void OnEnable()
    {
        DataPlayer.AddListener(UpdateCoin);
        UpdateCoin();
    }

    private void OnDisable()
    {
        DataPlayer.RemoveListener(UpdateCoin);
    }
}
