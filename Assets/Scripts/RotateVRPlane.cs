using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateVRPlane : MonoBehaviour
{
    
    public GameObject rotateThis;
    public bool shouldRotate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(shouldRotate){
            rotateThis.transform.Rotate(Vector3.up * 1f * Time.deltaTime);
        }
        
    }
}
