using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WalnutCountManager : MonoBehaviour
{

    public TextMeshProUGUI walnutText;
    public int walnutValue;

    private void Start()
    {
        walnutValue = StatsManager.Instance.globalWalnutCount;
        UpdateWalnutDisplay();
    }

    void Update()
    {
        if (true)
        {
            walnutValue = StatsManager.Instance.globalWalnutCount;
            UpdateWalnutDisplay();
        }
    }

    private void UpdateWalnutDisplay()
    {
        string scoreString = string.Format("{0} / 9", walnutValue);
        walnutText.text = scoreString;
    }
}

