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

    public Vector3 CurrentKeepApartDistance;

    [SerializeField]
    private float changingDist;
    public bool doThis;
    public float tpDist;
    void Awake()
    {
        tpDist = 50f;
        StartDist = Vector3.Distance(KeepthisOneStatic.transform.position, MoveThisOneAway.transform.position);
        Vector3 StartKeepApartDistance = new Vector3(StartDist, StartDist, StartDist);
        doThis = true;
    }

    // Update is called once per frame
    void Update()
    {
        ///int i = 0;

    if(doThis == true);{

        for(int i = 0; i >1; i++);{
            StartDist = changingDist;
            doThis = false;
            //StartCoroutine(WaitAbit());

        }
        changingDist = Vector3.Distance(KeepthisOneStatic.transform.position, MoveThisOneAway.transform.position);
        if(!(changingDist == StartDist)){
            NowMoveTheObjects();
            recalculateStartDist();
        }
        
    }
    }

    void NowMoveTheObjects(){
        //movethis one away = always the xyz of the coords
        //keepthisonestatic is always 0 
        //startdist is always changing

        //MoveThisOneAway.transform.position = (MoveThisOneAway.transform.position + KeepthisOneStatic.transform.position).normalized * StartDist + KeepthisOneStatic.transform.position;
        CurrentKeepApartDistance = new Vector3(changingDist, changingDist, changingDist);
        MoveThisOneAway.transform.position = (MoveThisOneAway.transform.position + CurrentKeepApartDistance);

     //   MoveThisOneAway.transform.position = (MoveThisOneAway.transform.position + CurrentKeepApartDistance);

    }

    void recalculateStartDist(){
        StartDist = Vector3.Distance(KeepthisOneStatic.transform.position, MoveThisOneAway.transform.position);
        changingDist = Vector3.Distance(KeepthisOneStatic.transform.position, MoveThisOneAway.transform.position);
    }

    static IEnumerator WaitAbit(){
        yield return new WaitForSeconds(12.0f);
    }
}
