using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//CURRENTLY NOT ADDED TO ANY OBJECT


public class BounceBall : MonoBehaviour
{
    public float mass;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
       rb.GetComponent<Rigidbody>();
    }

    void SlowDown(){
        rb.mass = 300;
        //rb.GetComponent<Rigidbody>();
        //GetComponent<Rigidbody>.mass = 300;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("M button"))
        SlowDown();
    }
}
