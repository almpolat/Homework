using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareket : MonoBehaviour
{
    float horizontal›nput;
    float vertical›nput;
    public float speed;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal›nput = Input.GetAxis("Horizontal");
        vertical›nput = Input.GetAxis("Vertical");
        rb.velocity = new Vector3(horizontal›nput*Time.deltaTime*speed,0,vertical›nput*Time.deltaTime*speed);
    }
}
