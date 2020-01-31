using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hex : MonoBehaviour
{
    public HexState HexState { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        HexState = HexState.Neutral;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
