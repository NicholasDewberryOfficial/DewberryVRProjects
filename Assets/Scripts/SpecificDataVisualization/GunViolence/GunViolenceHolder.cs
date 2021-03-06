//https://stackoverflow.com/questions/41194515/unity-create-ui-control-from-script
// maybe check this out https://bitbucket.org/UnityUIExtensions/unity-ui-extensions/wiki/UPMInstallation
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Fluent;
using System.Reflection;
using System.Linq;
public class GunViolenceHolder : MonoBehaviour
{
    public bool isOpen = false;

    public float ID;
    public string date;
    public string state;
    public string Caddress;
    public float nKilled;
    public float nInjured;
    public string incident_url;
    public string source_url;
    public string congressional_district;
    public string gunStolen;
    public string gunType;
    public string characteristics;
    public int latitude;
    public string location_description;
    public int longitude;
    public string nGunsInvolved;
    public string notes;
    public string participantAge;
    public string participantGender;
    public string participantRelationship;
    public string participantStatus;
    public string participantType;
    public string sources;
    public int houseDistrict;
    public int senateDistrict;







    public GameObject nearest;
    //*private Vector3 direction;
    //*is for when I tried to use Linecast to create a line between objects
    //as it currently stands, i get a thin red line rather than a full blanket 

    void awake(){

    }
    // Start is called before the first frame update
    void Start() {        
        GameObject[] gameObjectsToConsider = GameObject.FindGameObjectsWithTag("cube");
       //var nearest = gameObjectsToConsider.OrderBy(t=>(t.position - referencePos).sqrMagnitude).Take(3)   //or use .FirstOrDefault();  if you need just one.ToArray();

         //nearest = gameObjectsToConsider.OrderBy(t=> Vector3.Distance(transform.position, t.transform.position).FirstOrDefault());

         //element atone takes the closest object (because element at 0 takes itself)
      nearest = gameObjectsToConsider.OrderBy(t=> Vector3.Distance(transform.position, t.transform.position)).ElementAt(1);//Take(2);

      //RAY STRAT: OUTDATED
        //  var direction
        // direction = (transform.position - nearest.transform.position ).normalized;
        //  Ray ray = new Ray(transform.position, direction);
        //  ray.startWidth = 2f;
        //  ray.endWidth = 2f;



    // SET LINERENDERER FOR LINEREDNERER STRAT
        // LineRenderer lr = GetComponent<LineRenderer>();
        // lr.SetPosition(0, transform.position);
        // lr.SetPosition(1, nearest.transform.position);

    //     //for loop to create the line renderer runs into an issue because it setposition can only take two points, a start and an end.
    //     // for (int i=0; i < gameObjectsToConsider.Length; i++){
    //     //     lr.SetPosition(i, gameObjectsToConsider[i].transform.position);
    //     // }
    //   //  lr.material.SetColor("Lcolor", new Color(transform.position.x, transform.position.y, transform.position.z, 1.0f));
    //    //lr.material.color = new Color(transform.position.x, transform.position.y, transform.position.z, .8f);//1.0f);
    //     //lr.material.color = new Color.HSVToRGB(transform.position.x, transform.position.y, 1);
    //     lr.material.color = new Color (1, rand2, 1, 1.0f );
        // Color c1 = new Color(transform.position.x, transform.position.y, transform.position.z, 1.0f);
        // Color c2 = new Color(nearest.transform.position.x, nearest.transform.position.y, nearest.transform.position.z, 1.0f);
        // //lr.SetColors(c1, c2);
        // lr.startColor = c1;
        // lr.endColor = c2;
   }
    

    // Update is called once per frame
    void Update()
    {
        //*Debug.DrawRay(ray);

        //if 
    }

    void OnMouseDown(){ 
        ClearLog();
        Debug.Log("The details of your selection are:");
        //column x
        Debug.Log("Incident ID is" + ID);
        Debug.Log("Incident Date is" + date);
        Debug.Log("Incident State is" + state);
        Debug.Log("Number of fatalities are" + nKilled);
        Debug.Log("Number of injuries are " + nInjured);
        Debug.Log("The number of guns involved are " + nGunsInvolved);
        Debug.Log("Was the gun stolen?" + gunStolen);
        Debug.Log("What type of gun was used?" + gunType);

        // Debug.Log("Ozone is " + Ozone);
        // Debug.Log("Solar.R " + SolarR);
        // Debug.Log("Wind is " + Wind);
        // Debug.Log("Temp is " + Temp);
        // Debug.Log("Month is " + Month);
        // Debug.Log("Day is " + Day);
        // Debug.Log("rand1 is " + rand1);
        // Debug.Log("rand2 is " + rand2);
        // Debug.Log("rand3 is " + rand3);
        // Debug.Log("rand4 is " + rand4);
        // Debug.Log("rand5 is " + rand5);
    }

    public void ClearLog()
{
    var assembly = Assembly.GetAssembly(typeof(UnityEditor.Editor));
    var type = assembly.GetType("UnityEditor.LogEntries");
    var method = type.GetMethod("Clear");
    method.Invoke(new object(), null);
}

    

    }



