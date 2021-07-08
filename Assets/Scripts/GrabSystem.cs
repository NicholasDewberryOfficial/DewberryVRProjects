using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabSystem : MonoBehaviour
{ 
    [SerializeField]
    private Camera characterCamera;
    // Start is called before the first frame update
    [SerializeField]
    private Transform slot;

    private PickableItem pickedItem;

    void Start()
    {
        
    }

    public void FirebuttonDown(){
        //if (Input.GetButtonDown("Fire")){
            

            if (pickedItem){
                DropItem(pickedItem);
            } else {
                //var ray = characterCamera.ViewportPointToRay(Vector3.one * 0.5f );
                var ray = characterCamera.ViewportPointToRay(Vector3.one * 0.5f );
                RaycastHit hit;
                if (Physics.Raycast (ray, out hit, 1.5f)){
                    var pickable = hit.transform.GetComponent<PickableItem>();

                    if (pickable){
                        PickItem(pickable);
                    }
                }
            }
        //} 

    }

    // Update is called once per frame
    void Update()
    {
 //       FirebuttonDown();
        
        
    }


    private void PickItem(PickableItem item){
        pickedItem = item;

        item.Rb.isKinematic = true;
        item.Rb.velocity = Vector3.zero;
        item.Rb.angularVelocity = Vector3.zero;
        item.transform.SetParent(slot);

        item.transform.localPosition = Vector3.zero;
        item.transform.localEulerAngles = Vector3.zero;

    }

    private void DropItem(PickableItem item){
        pickedItem = null;
        item.transform.SetParent(null);
        item.Rb.isKinematic = false;

        item.Rb.AddForce(item.transform.forward *2, ForceMode.VelocityChange);
    }
}
