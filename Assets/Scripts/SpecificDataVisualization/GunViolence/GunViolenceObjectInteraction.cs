using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using System.Reflection;


public class GunViolenceObjectInteraction : MonoBehaviour
{

    //public IrisDataHolder IrisDataHolder;

    public SteamVR_Input_Sources handType;
    public SteamVR_Behaviour_Pose controllerPose;
    public SteamVR_Action_Boolean grabAction;

    private GameObject collidingObject;
    private GameObject objectInHand;
    public AirQualityHolder ObjectDeets; // = collidingObject.GetComponent<IrisDataHolder>();


public void OnTriggerEnter(Collider other)
    {
        // ObjectDeets = collidingObject.GetComponent<AirQualityHolder>();
        collidingObject = null;
        SetCollidingObject(other);
        // ClearLog();
        // Debug.Log("The details of your selection are:");
        // Debug.Log("Ozone is " + ObjectDeets.Ozone);
        // Debug.Log("Solar.R " + ObjectDeets.SolarR);
        // Debug.Log("Wind is " + ObjectDeets.Wind);
        // Debug.Log("Temp is " + ObjectDeets.Temp);
        // Debug.Log("Month is " + ObjectDeets.Month);
        // Debug.Log("Day is " + ObjectDeets.Day);
        // Debug.Log("rand1 is " + ObjectDeets.rand1);
        // Debug.Log("rand2 is " + ObjectDeets.rand2);
        // Debug.Log("rand3 is " + ObjectDeets.rand3);
        // Debug.Log("rand4 is " + ObjectDeets.rand4);
        // Debug.Log("rand5 is " + ObjectDeets.rand5);
    }

    public void OnTriggerStay(Collider other)
    {
        SetCollidingObject(other);
    }

    private void SetCollidingObject(Collider col)
    {
        if (collidingObject || !col.GetComponent<BoxCollider>())
        {
            return;
        }
        collidingObject = col.gameObject;
        
    }

    void Update()
    {
        if (grabAction.GetLastStateDown(handType))
        {

        //collidingObject = null;
       // SetCollidingObject(other);
        ObjectDeets = collidingObject.GetComponent<AirQualityHolder>();
        ClearLog();
        Debug.Log("The details of your selection are:");
        Debug.Log("Ozone is " + ObjectDeets.Ozone);
        Debug.Log("Solar.R " + ObjectDeets.SolarR);
        Debug.Log("Wind is " + ObjectDeets.Wind);
        Debug.Log("Temp is " + ObjectDeets.Temp);
        Debug.Log("Month is " + ObjectDeets.Month);
        Debug.Log("Day is " + ObjectDeets.Day);
        Debug.Log("rand1 is " + ObjectDeets.rand1);
        Debug.Log("rand2 is " + ObjectDeets.rand2);
        Debug.Log("rand3 is " + ObjectDeets.rand3);
        Debug.Log("rand4 is " + ObjectDeets.rand4);
        Debug.Log("rand5 is " + ObjectDeets.rand5);
            // if (collidingObject)
            // {
            //     GrabObject();
            // }
        }

        if (grabAction.GetLastStateUp(handType))
        {
            // if (objectInHand)
            // {
            //     ReleaseObject();
            // }
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void ClearLog()
{
    var assembly = Assembly.GetAssembly(typeof(UnityEditor.Editor));
    var type = assembly.GetType("UnityEditor.LogEntries");
    var method = type.GetMethod("Clear");
    method.Invoke(new object(), null);
}
    // Update is called once per frame
    // void Update()
    // {
        
    // }
}
