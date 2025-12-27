using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StatsUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI exp;
    [SerializeField] Image expProgressImage;

    public void updateExpUI(int currentValue,int maxValue)
    {
        expProgressImage.fillAmount = (float)currentValue / maxValue;
        exp.text = String.Concat(currentValue.ToString(),"/",maxValue.ToString());
    }
}
