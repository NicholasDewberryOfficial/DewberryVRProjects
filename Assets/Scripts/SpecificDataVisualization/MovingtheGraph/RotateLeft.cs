using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLeft : MonoBehaviour
{
    //public bool RotateRight;

    public GameObject cube;
    //public gameObject rotateThis;

   // public GameObject RotateVRPlane;
    public RotateVRPlane RotateVRPlane;

    

    //public AirQualityObjectInteraction AirQualityObjectInteraction;
    // Start is called before the first frame update
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
      //  Debug.Log("Enabled the graph moving right");
        RotateVRPlane.shouldRotateRight = true;
        cube.GetComponent<Renderer>().material.color = Color.red;

    }

    void StopRotating(Collider other){
      //  Debug.Log("Graph is going to stop moving");
        RotateVRPlane.shouldRotateRight = false;
        cube.GetComponent<Renderer>().material.color = Color.blue;
    }
}
