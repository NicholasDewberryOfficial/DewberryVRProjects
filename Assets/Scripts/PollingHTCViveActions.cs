using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class PollingHTCViveActions : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }
    public SteamVR_Input_Sources handType;
    public SteamVR_Action_Boolean teleportAction;
    public SteamVR_Action_Boolean grabAction;
    public bool GetTeleportDown(){
        return teleportAction.GetStateDown(handType);
    }
    public bool GetGrab(){
        return grabAction.GetState(handType);
    }
    // Update is called once per frame
    void Update()
    {
        if (GetTeleportDown()){
            print("Teleport" + handType);
        }
        if (GetGrab()){
            print("Grab" + handType);
        }
        
    }
}
