using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundY : MonoBehaviour
{
    // Start is called before the first frame update
     // public GameObject cube;
    //public gameObject rotateThis;

   // public GameObject RotateVRPlane;
    public RotateVRPlane RotateVRPlane;
    public GameObject RotateThis;

  //  public AirQualityObjectInteraction AirQualityObjectInteraction;
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
    RotateThis.transform.Rotate(Vector3.right * 1f * Time.deltaTime);

    }
    }

