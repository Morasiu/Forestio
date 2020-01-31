using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarManager : MonoBehaviour
{
    Hexa HexaList;
    void Start()
    {
        HexaList = FindObjectOfType<Hexa>();
    }
}
