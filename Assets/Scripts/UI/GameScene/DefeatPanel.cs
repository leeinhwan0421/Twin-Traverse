using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DefeatPanel : Panel
{
    [Header("preset")]
    [SerializeField] private TextMeshProUGUI earnedCoin;

    public void SetEarnedCoinText(int earnedCoin)
    {
        this.earnedCoin.text = $"{earnedCoin}";
    }
}