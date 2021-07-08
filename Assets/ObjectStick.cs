using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectStick : MonoBehaviour
{
    //part of complicated solution 
    private Rigidbody rb;
    private HingeJoint hj;
    //What i can also do:
    //have a control button (like m or the grip on the vive) that changes the tag of an object
    //every object that touches the object with a new tag becomes sticky, and can have objects stuck to it
    void OnCollisionEnter(Collision collision){
        if (collision.gameObject.tag == "StickyPhysicsObject"){ 
            //if (collision.gameObject.tag == "SpherePhysicsObject"){ 
           collision.gameObject.transform.parent = gameObject.transform;
            //complicated solution
            rb = GetComponent<Rigidbody>();
            // collision.gameObject.AddComponent<HingeJoint>();
            // hj = GetComponent<HingeJoint>();
            // hj.connectedBody = rb;  
        //     GetComponent<Rigidbody>().mass = 0.00001f;
        //     GetComponent<Collider>().material.bounciness = 0;
        //     GetComponent<Rigidbody>().freezeRotation = true;
        //    rb.velocity = Vector3.zero;
        //    rb.useGravity = false;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Unstick(){
    Destroy (GetComponent<HingeJoint>());
    GetComponent<Rigidbody>().mass = 1;
        }

}
