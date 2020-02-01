using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Image o2Bar;

    public float targetPercentage;
    float changeValue;
    float actualWidth;

    private void Update()
    {
        SetTargetValue();
        AnimateProgressBar();
        actualWidth = o2Bar.rectTransform.sizeDelta.x;
    }

    public void SetTargetValue()
    {
        float targetWidth = targetPercentage * o2Bar.rectTransform.sizeDelta.x;
        if (actualWidth < targetWidth)
        {
            changeValue = 1f;
        }
        else if(actualWidth > targetPercentage)
        {
            changeValue = -1f;
        }
        else if(Math.Abs(actualWidth - targetPercentage) < o2Bar.rectTransform.sizeDelta.x/100)  
        {

            changeValue = 0;
            actualWidth = targetPercentage;
        }
    }

    public void AnimateProgressBar()
    {
        var temporaryValue = actualWidth * o2Bar.rectTransform.sizeDelta.x + changeValue;
        o2Bar.rectTransform.sizeDelta = new Vector2(temporaryValue, o2Bar.rectTransform.sizeDelta.y);
    }

}
