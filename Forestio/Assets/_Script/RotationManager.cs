using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationManager : MonoBehaviour
{
    [SerializeField]
    private float rotSpeed = 5f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse2)) {
            float rotX = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;
            float rotY = Input.GetAxis("Mouse Y") * rotSpeed * Mathf.Deg2Rad;
                
            transform.RotateAround(Vector3.up, -rotX);
            transform.RotateAround(Vector3.right, rotY);
        }
    }
}
