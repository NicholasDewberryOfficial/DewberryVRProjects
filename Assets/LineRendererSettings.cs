using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LineRendererSettings : MonoBehaviour
{
    public GameObject panel;
    public Image img;
    public Button btn;
    //public GameObject 
    [SerializeField] LineRenderer rend;
//setup a v3 array, gets initialized here
    Vector3[] points;

    // Start is called before the first frame update
    void Start()
    {
        img = panel.GetComponent<Image>();

        //calling the linerenderer(controller) from the capsule component
      rend = gameObject.GetComponent<LineRenderer>();//(0, new Vector3(0, 0 ,0)); 
//initializing the linerenderer
      points = new Vector3[2];
//start point = gameobject position (where the beam starts)
      points[0] = Vector3.zero;
//end point = 20 units away (how far can the beam go?)
      points[1] = transform.position + new Vector3(0, 0, 20);

      //set the positions array on the line renderer to the new values (I have the values set, now I need to assign them to the lineRenderer game object)
      rend.SetPositions(points);
      rend.enabled = true; 
    }

    public LayerMask layerMask; 

    public bool AlignLineRenderer(LineRenderer rend)
{
    bool hitBtn = false;
    //creates new ray called ray
    Ray ray; 
    //makes ray from the transform position along the transform's z-axis
    //First one is the v3origin
    //Second one is the v3direction
    ray = new Ray(transform.position, transform.forward);
    RaycastHit hit;

    if (Physics.Raycast(ray, out hit, layerMask)){
        
        points[1] = transform.forward + new Vector3(0, 0, hit.distance);
        rend.startColor = Color.red;
        rend.endColor = Color.red;
        btn = hit.collider.gameObject.GetComponent<Button>();
        hitBtn = true;

    }
    else{
        points[1] = transform.forward + new Vector3(0, 0, 20);
        rend.startColor = Color.green;
        rend.endColor = Color.green;
        hitBtn = false;
    }
    rend.SetPositions(points);
    return hitBtn;
}

    // Update is called once per frame
    void Update()
    {
        //shoots out a beam of light that alins the VISIBLE renderer with the INVISIBLE raycast from the controller
        AlignLineRenderer(rend);
        rend.material.color = rend.startColor;
        if (AlignLineRenderer(rend) && Input.GetAxis("Submit") > 0){
        btn.onClick.Invoke();
    }
        
    }
    public void ColorChangeOnClick(){
        if (btn != null){
            if (btn.name == "Red_BTN"){
                img.color = Color.red;
                //Debug.log("Red is selected");
            }
            else if (btn.name == "Blue_BTN"){
                img.color = Color.blue;
                //Debug.log("Blue is selected");
            }
        
        else if (btn.name == "Green_BTN"){
            img.color = Color.green;
            //Debug.log("Green is selected");

        }
    }
    
}
}