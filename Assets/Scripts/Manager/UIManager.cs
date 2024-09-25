using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private static UIManager instance;
    public static UIManager Instance
    {
        get
        {
            if (instance == null)
                return null;

            return instance;
        }
    }

    [Header("UI Element")]
    [SerializeField] private TextMeshProUGUI timer;
    [SerializeField] private DefeatPanel defeatPanel;
    [SerializeField] private VictoryPanel victoryPanel;

    // Properties
    public DefeatPanel DefeatPanel { get { return defeatPanel; } }
    public VictoryPanel VictoryPanel { get { return victoryPanel; } }

    private void Awake()
    {
        instance = this;
    }

    public void SetTimer(float playTime)
    {
        int min = (int)(playTime / 60.0f);
        int sec = (int)(playTime % 60.0f);

        timer.text = $"{min:00} : {sec:00}";
    }
}
