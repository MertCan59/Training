using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 15f;
    private int hp = 5;
    private Rigidbody rb;
    public TextMeshProUGUI text;

     void Start()
    {
        rb=GetComponent<Rigidbody>();   
    }
    // Update is called once per frame
    void Update()
    {
        float xDirection = Input.GetAxis("Horizontal");
        float yDirection = Input.GetAxis("Vertical");
        Vector3 move = transform.right * xDirection + transform.forward * yDirection;
        controller.Move(move*speed*Time.deltaTime);
    }
    private void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.CompareTag("Enemy"))
        {
            hp--;
            text.text = "HP: " + hp.ToString();
            if (hp <= 0)
            {
                hp = 0;
                text.text = "HP: " + hp;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }

        }
    }
}
