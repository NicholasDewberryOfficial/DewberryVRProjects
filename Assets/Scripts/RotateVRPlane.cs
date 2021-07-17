using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateVRPlane : MonoBehaviour
{
    
    public GameObject rotateThis;
    public bool shouldRotateLeft;

    public bool shouldRotateRight;
    public bool shouldRotateUp;
    public bool shouldRotateDown;
    public GameObject UpDownWheel;
    private Vector3 StartLocation;
    public bool resetthis;

    public bool shouldRotateForward;
    public bool shouldRotateZBackwards;

    public bool Snapby90x;
    public bool Snapby90y;

    public bool Snapby90z;
    // Start is called before the first frame update
    void Start()
    {
     //   StartLocation
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
        if(shouldRotateUp){
            rotateThis.transform.Rotate(Vector3.left * 1f * Time.deltaTime);
        }

        if(shouldRotateDown){
            rotateThis.transform.Rotate(Vector3.right * 1f * Time.deltaTime);
        }

        if(shouldRotateForward){
            rotateThis.transform.Rotate(Vector3.forward * 1f * Time.deltaTime);
        }

        if(shouldRotateZBackwards){
            rotateThis.transform.Rotate(Vector3.back * 1f * Time.deltaTime);
        }

        if (resetthis){
            reset();
        }
//right now the below statements run every frame my hand is inside (based on update, if hand is inside it goes
//i can remove these bools and everything should work, or i can modify them)

//add spinning functionality in the snap statements rather than anything else.
        // if(Snapby90x){
        //     rotateThis.transform.Rotate(90f,0f, 0f, Space.World);
        // }

        // if(Snapby90y){
        //     rotateThis.transform.Rotate(0f,90f, 0f, Space.World);
        // }
        // if(Snapby90z){
        //     rotateThis.transform.Rotate(0f,0f, 90f, Space.World);
        // }
        
    }

    public void enableShouldRotateUP(){
        shouldRotateLeft = true;
    }

    public void disableShouldRotateUP(){
        shouldRotateLeft = false;
    }

    public void reset(){
        rotateThis.transform.rotation = Quaternion.identity;
    }


}
