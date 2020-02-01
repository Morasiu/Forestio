using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.LookAt(2 * transform.position - Vector3.zero);
        transform.LookAt(Vector3.zero);
        //transform.localRotation = Quaternion.Euler(new Vector3(
        //    transform.localRotation.x + 90f,
        //    transform.localRotation.y,
        //    transform.localRotation.z));
    }

    
}
