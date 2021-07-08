//c# semicolons are needed
using System;
using UnityEngine;
//UnityEngine.monobehaviour = allow us to add custom behavior to gameobjectss
public class Clock: UnityEngine.MonoBehaviour {
    const float hoursToDegrees = -30f, minutesToDegrees = -6f, secondsToDegrees = -6f;
    //i want this hoursPivot to be accessed by other fields and scripts, I have to serialize it
    //don't want to make it public because "bad form"/
    //want to reduce dependency on other scripts using this one
    [SerializeField]
    //first word lowercase, all others caps
    //type has to go in front
    //in transform field 
    //I can make a list of field declerations, if they share the same attribute
    Transform hoursPivot, minutesPivot, secondsPivot;
//calls awake method, returns no value
//awake is automatically public
//monobehaviour has a few functions which operate on special rules
    void Update(){
        TimeSpan time = DateTime.Now.TimeOfDay;
        hoursPivot.localRotation = Quaternion.Euler(0f,0f,hoursToDegrees * (float)time.TotalHours);
        minutesPivot.localRotation = Quaternion.Euler(0f,0f,minutesToDegrees * (float)time.TotalMinutes);
        secondsPivot.localRotation = Quaternion.Euler(0f,0f,secondsToDegrees * (float)time.TotalSeconds);
    }
}