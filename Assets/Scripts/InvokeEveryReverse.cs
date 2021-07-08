using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeEveryReverse : MonoBehaviour
{
    public TimeBody timeBody;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void callRewind(){
        timeBody.StartRewind();
    }
}
