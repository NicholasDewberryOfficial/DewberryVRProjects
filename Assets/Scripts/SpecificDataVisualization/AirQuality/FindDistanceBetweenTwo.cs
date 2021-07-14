using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class FindDistanceBetweenTwo : MonoBehaviour
{

    public SteamVR_Input_Sources LeftHand;
    public SteamVR_Input_Sources RightHand;


    public SteamVR_Action_Boolean GestureAction;
    private float dist;
    
    public GameObject stretchThis;

    public GameObject Left;
    public GameObject Right;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // if(currDist > dist){

        // }
        if(GestureAction.GetLastStateDown(LeftHand) && (GestureAction.GetLastStateDown(RightHand))){
            Debug.Log("Hey");
            float currDist = Vector3.Distance(Left.transform.position, Right.transform.position);
            Vector3 v3distance = new Vector3(currDist, currDist, currDist);
            stretchThis.transform.localScale += v3distance;

    }
    }
}
