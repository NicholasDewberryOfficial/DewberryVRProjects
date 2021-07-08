using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fluent;
public class FluentDialogue : FluentScript
{
    public IrisDataHolder irisDataHolder;


    public override FluentNode Create()
    {
        return Yell(irisDataHolder.petalLength);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  
}
