using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 15f;
    // Update is called once per frame
    void Update()
    {
        float xDirection = Input.GetAxis("Horizontal");
        float yDirection = Input.GetAxis("Vertical");
        Vector3 move = transform.right * xDirection + transform.forward * yDirection;
        controller.Move(move*speed*Time.deltaTime);
    }
}
