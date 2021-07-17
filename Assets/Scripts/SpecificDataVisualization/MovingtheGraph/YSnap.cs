using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YSnap : MonoBehaviour
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
        rotateThis.transform.Rotate(0f,90f, 0f, Space.World);
    }

    void OnTriggerExit(Collider other){
       // StopRotating(other);

    }


    //    void StartRotating(Collider other){
    //     //Debug.Log("Enabled the graph moving Up");
    //     RotateVRPlane.Snapby90y = true;
    //     cube.GetComponent<Renderer>().material.color = Color.red;

    // }

    // void StopRotating(Collider other){
    //    // Debug.Log("Graph is going to stop moving Up");
    //     RotateVRPlane.Snapby90y = false;
    //     cube.GetComponent<Renderer>().material.color = Color.red;
    //     //Debug.Log("Current Graph coordinates are: " + RotateVRPlane.transform.position);
    // }
}
