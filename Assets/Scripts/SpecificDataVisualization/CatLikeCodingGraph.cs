using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatLikeCodingGraph : MonoBehaviour
{
    [SerializeField]
    Transform pointPrefab;
    [SerializeField, Range(10, 100)]
    int resolution = 10;

    Transform[] points;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float time = Time.time;
        for (int i = 0; points.Length > i; i++){
            Transform point = points[i];
            Vector3 position = point.localPosition;
            position.y = Mathf.Sin(Mathf.PI * (position.x + time));
            //position.y = (position.x + time);
            point.localPosition = position;
        }
    }

    void Awake() {
        float step = 2f / resolution;
        //creates and sets position to 0,0,0
        var position = Vector3.zero;
        // so 1/5, 1/5, 1/5 is the scale (also a vector3 value)
        var scale = Vector3.one / 5f;
       // int i = 0;
        //while (!(i++>10)) {
            points = new Transform[resolution];
            for (int i = 0; i < points.Length; i++){
            Transform point = points[i] = Instantiate(pointPrefab);
            //point.localPosition = Vector3.right * ((i + .5f) / 5f - 1f);
            position.x = (i + .05f) * step- 1f;
            point.localPosition = position;
            point.localScale = scale;
            point.SetParent(transform, false);


        // List<Dictionary<string,object>> data = CSVReader.Read ("Water_Quality__LA_");
 
        // for(var x=0; x < data.Count; x++) {
        //     print ("Policy Area " + data[i]["Policy Area"] + " " +
        //            "Dataset " + data[i]["Dataset"] + " " +
        //            "Variable " + data[i]["Variable"] + " " +
        //            "Year " + data[i]["Year"] +
        //            "Count " + data[i]["Count"] + " " +
        //            "Tract " + data[i]["Tract"] + " " +
        //            "Tract Number " + data[i]["Tract Number"] + " " +
        //            "Neighborhood " + data[i]["Neighborhood"] +
        //            "GEOID " + data[i]["GEOID"] + " " +
        //            "Location " + data[i]["Location"] + " " +
        //            "Row ID" + data[i]["Row ID"] + " " +
        //            "Date " + data[i]["Date"]);
                   

        }
    }
}

