using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAttractRepel : MonoBehaviour
{
    //private bool RepelOn = true;
    public void OnCollisionEnter(Collision c){
        float force = 5500;

        if (c.gameObject.tag == "MainObject"){
            Vector3 dir = c.contacts[0].point - transform.position;
            dir = -dir.normalized;
            GetComponent<Rigidbody>().AddForce(dir*force);

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //OnCollisionEnter(cubehere);
        
    }
}
