using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using System.Reflection;


public class IrisInteractWIthObjects : MonoBehaviour
{

    //public IrisDataHolder IrisDataHolder;

    public SteamVR_Input_Sources handType;
    public SteamVR_Behaviour_Pose controllerPose;
    public SteamVR_Action_Boolean grabAction;

    private GameObject collidingObject;
    private GameObject objectInHand;
    public IrisDataHolder ObjectDeets; // = collidingObject.GetComponent<IrisDataHolder>();


public void OnTriggerEnter(Collider other)
    {
        collidingObject = null;
        SetCollidingObject(other);
        // ClearLog();
        // ObjectDeets = collidingObject.GetComponent<IrisDataHolder>();
        // Debug.Log("The details of your selection are:");
        // Debug.Log("Petal Length is " + ObjectDeets.petalLength);
        // Debug.Log("Petal Width is " + ObjectDeets.petalWidth);
        // Debug.Log("Sepal Length is " + ObjectDeets.sepalLength);
        // Debug.Log("Petal Width is " + ObjectDeets.sepalWidth);
        // Debug.Log("ID is " + ObjectDeets.ID);
        // Debug.Log("Species is " + ObjectDeets.species);
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

          //  collidingObject = null;
        //SetCollidingObject(other);
        ObjectDeets = collidingObject.GetComponent<IrisDataHolder>();
        ClearLog();
        Debug.Log("The details of your selection are:");
        Debug.Log("Petal Length is " + ObjectDeets.petalLength);
        Debug.Log("Petal Width is " + ObjectDeets.petalWidth);
        Debug.Log("Sepal Length is " + ObjectDeets.sepalLength);
        Debug.Log("Petal Width is " + ObjectDeets.sepalWidth);
        Debug.Log("ID is " + ObjectDeets.ID);
        Debug.Log("Species is " + ObjectDeets.species);
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
