using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlwaysStayAWay : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject KeepthisOneStatic;
    public GameObject MoveThisOneAway;

    public float StartDist; 

    public Vector3 StartKeepApartDistance;

    [SerializeField]
    private float changingDist;
    void Awake()
    {
        
        StartDist = Vector3.Distance(KeepthisOneStatic.transform.position, MoveThisOneAway.transform.position);
        Vector3 StartKeepApartDistance = new Vector3(StartDist, StartDist, StartDist);
    }

    // Update is called once per frame
    void Update()
    {
        ///int i = 0;

        for(int i = 0; i >1; i++);{
            StartDist = changingDist;
            //StartCoroutine(WaitAbit());
        }
        
        changingDist = Vector3.Distance(KeepthisOneStatic.transform.position, MoveThisOneAway.transform.position);
        if(!(changingDist == StartDist)){
        //    NowMoveTheObjects();
        }
        
    }

    void NowMoveTheObjects(){
        MoveThisOneAway.transform.position = (MoveThisOneAway.transform.position - KeepthisOneStatic.transform.position).normalized * StartDist + KeepthisOneStatic.transform.position;
    }


    static IEnumerator WaitAbit(){
        yield return new WaitForSeconds(12.0f);
    }
}
