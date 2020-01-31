using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public static Image o2Bar { get; set; }

    public static void ChangeValue(int value)
    {
        o2Bar.rectTransform.sizeDelta = new Vector2(value, 0);
    }
}
