
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseControl : MonoBehaviour
{
    float sens= 300f;
    float xDirection = 0f;
    public Transform body;
    public Transform gun;
    // Update is called once per frame
    void Update()
    {
        float directX = Input.GetAxisRaw("Mouse X")*sens*Time.deltaTime;
        float directY = Input.GetAxisRaw("Mouse Y")*sens*Time.deltaTime;
        xDirection -= directY;

        transform.localRotation= Quaternion.Euler(xDirection, 0f, 0f);
        xDirection = Mathf.Clamp(xDirection, -90f, 90f);
        body.Rotate(Vector3.up * directX);
    }
}
