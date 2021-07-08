using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YValuesIsoSurface : MonoBehaviour
{
    MeshFilter meshFilter;
    Vector3[] newVertices;
    int[] newTriangles;
    Vector2[] newUV;
    void Start()
    {
        GameObject[] gameObjectsToConsider = GameObject.FindGameObjectsWithTag("cube");
         //First, we create an array of vector3's. Each vector3 will 
        //represent one vertex in our mesh. Our shape will be a half 
        //cube (probably the simplest 3D shape we can make.

        //NEW TRIANGLE CODE
        //i make a list called triangles
        //i make a variable called newtriangle that 

        newVertices = new Vector3[gameObjectsToConsider.Length];
        newUV = new Vector2[gameObjectsToConsider.Length];
        for(int i = 0; i < gameObjectsToConsider.Length; i++){
            newVertices[i] = (gameObjectsToConsider[i].transform.position);
            newTriangles[i] = (int)(gameObjectsToConsider[i].transform.position.y);


           // newUV[i] = (Vector2)(gameObjectsToConsider[i].transform.position.x, gameObjectsToConsider[i].transform.position.z);
           
            //ISSUES
            //triangle arrays can only hold 3 numbers 
            //i have to make them equal to all three points
            // if (i > 2){ 
            //     newTriangles[i] = i;
            //     newTriangles[i-1] = i-1;
            //     newTriangles[i-2] = i-2;
                // //Triangles can only go from 0-2
                
            }
            //newTriangles[i] = (((int)side1), ((int)side2), ((int)side3));
            
           //newTriangles[i] = (int)(gameObjectsToConsider[i].transform.position.x);
            



        // //Next, we create an array of integers which will represent 
        // //triangles. Triangles are built by taking integers in groups of 
        // //three, with each integer representing a vertex from our array of 
        // //vertices. Note that the integers are in a certain order. The order 
        // //of integers determines the normal of the triangle. In this case, 
        // //connecting 021 faces the triangle out, while 012 faces the 
        // //triangle in.

        // newTriangles[0] = 0;
        // newTriangles[1] = 2;
        // newTriangles[2] = 1;

        // newTriangles[3] = 0;
        // newTriangles[4] = 1;
        // newTriangles[5] = 3;

        // newTriangles[6] = 0;
        // newTriangles[7] = 3; 
        // newTriangles[8] = 2;

        // newTriangles[9] = 1;
        // newTriangles[10] = 2;
        // newTriangles[11] = 3;


        //We instantiate our mesh object and attach it to our mesh filter
        Mesh mesh = new Mesh();
        meshFilter = gameObject.GetComponent<MeshFilter>();
        meshFilter.mesh = mesh;
        //mesh.uv = newUV;


        //We assign our vertices and triangles to the mesh.
        mesh.vertices = newVertices;
        mesh.triangles = newTriangles;
    }
}