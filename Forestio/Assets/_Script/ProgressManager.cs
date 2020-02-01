using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class ProgressManager : MonoBehaviour
{
    List<Hex> HexaList;

    ProgressBar progressBar;
    private float oldPercentage;
    void Start()
    {
        HexaList = FindObjectsOfType<Hex>().ToList<Hex>();
        progressBar = FindObjectOfType<ProgressBar>();
    }

    private void Update()
    {
        var naturalHexa = HexaList.Sum(x => x.HexState.CompareTo(HexState.Natural));
        var poluttedHexa = HexaList.Sum(x => x.HexState.CompareTo(HexState.Polluted));

        if (naturalHexa == 0) {
            Debug.Log("POLLUTION WON! :(");
            return;
        } else if (poluttedHexa == 0) {
            Debug.Log("NATURE WON! :)");
            return;
        }
        naturalHexa = 100;
        poluttedHexa = 10;
        float percentage = (float) naturalHexa / (poluttedHexa + naturalHexa);
        if (Mathf.Round(percentage * 100) == Mathf.Round(oldPercentage * 100))
            return;
        oldPercentage = percentage;
        Debug.Log(percentage);
        progressBar.targetPercentage = percentage;
    }
}
