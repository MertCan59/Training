using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunControl : MonoBehaviour
{
    public Transform bulletPos;
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject go = Instantiate(bullet,bulletPos.position,bulletPos.rotation) as GameObject;
            go.GetComponent<Rigidbody>().velocity = bulletPos.transform.forward * 10f;
            Destroy(go);
            
        }
    }
}
