using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StatsUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI expText;
    [SerializeField] Image expProgressImage;
    [SerializeField] TextMeshProUGUI levelText;

    public void updateExpUI(int currentValue,int maxValue,int level)
    {
        expProgressImage.fillAmount = (float)currentValue / maxValue;
        expText.text = String.Concat(currentValue.ToString(),"/",maxValue.ToString());
        levelText.text = level.ToString();
    }
}
