using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateVRPlane : MonoBehaviour
{
    
    public GameObject rotateThis;
    public bool shouldRotateLeft;

    public bool shouldRotateRight;
    public GameObject UpDownWheel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(shouldRotateLeft){
            rotateThis.transform.Rotate(Vector3.up * 1f * Time.deltaTime);
            UpDownWheel.transform.Rotate(Vector3.up * 1f * Time.deltaTime);
        }
        if(shouldRotateRight){
            rotateThis.transform.Rotate(Vector3.down * 1f * Time.deltaTime);
            UpDownWheel.transform.Rotate(Vector3.down * 1f * Time.deltaTime);

        }
        
    }

    public void enableShouldRotateUP(){
        shouldRotateLeft = true;
    }

    public void disableShouldRotateUP(){
        shouldRotateLeft = false;
    }


}
