using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//need gridpoint script, grid of gridpoints, and the points a-h on the cube before calling methods
//defines mesh of each marching cube config (2^8 = 256)
public class OmarSantiagoMarchingCubes : MonoBehaviour
{

    //grid of points
   // public static GridPoint[,,] grd = null;

    //mesh data
    public static List<Vector3> vertices = new List<Vector3>();
    public static List<int> triangles = new List<int>();
    public static List<Vector2> uv = new List<Vector2>();

    public static void Clear(){

        vertices.Clear();
        triangles.Clear();
        uv.Clear();
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
