using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeMovement : MonoBehaviour
{
    Mesh mesh;
    //Use this for initialization
    void Start()
    {
        mesh = GetComponent<MeshFilter>().mesh;
        Vector3[] vertices = mesh.vertices;
        Vector3[] normals = mesh.normals;

        /*if(mesh.CompareTag("FrontWheel"))
        {
            
        }*/
    }

    //Update is called once per frame
    void Update()
    {
       



    }
}