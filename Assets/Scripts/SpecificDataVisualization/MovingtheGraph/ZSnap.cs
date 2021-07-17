using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZSnap : MonoBehaviour
{
    public GameObject cube;

    //public RotateVRPlane RotateVRPlane;

    public GameObject rotateThis;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }

//commented code is for the inconsistent version. I put the controller in, it starts spinning but it doesnt stop when controller goes out
    void OnTriggerEnter(Collider other){
        rotateThis.transform.Rotate(0f,0f, 90f, Space.World);
    }

    void OnTriggerExit(Collider other){
       // StopRotating(other);

    }
}
