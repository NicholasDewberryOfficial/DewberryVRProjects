using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetButton : MonoBehaviour
{
    public GameObject cube;

    public RotateVRPlane RotateVRPlane;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }

//commented code is for the inconsistent version. I put the controller in, it starts spinning but it doesnt stop when controller goes out
    void OnTriggerEnter(Collider other){
        StartRotating(other);
    }

    void OnTriggerExit(Collider other){
        StopRotating(other);

    }


       void StartRotating(Collider other){
        //Debug.Log("Enabled the graph moving Up");
        RotateVRPlane.resetthis = true;
        cube.GetComponent<Renderer>().material.color = Color.red;

    }

    void StopRotating(Collider other){
       // Debug.Log("Graph is going to stop moving Up");
        RotateVRPlane.resetthis = false;
        cube.GetComponent<Renderer>().material.color = Color.red;
        //Debug.Log("Current Graph coordinates are: " + RotateVRPlane.transform.position);
    }
}
