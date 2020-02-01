using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var parent = transform.parent;
        transform.position = parent.position + parent.transform.forward * 4;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
