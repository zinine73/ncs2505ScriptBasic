using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    Renderer myRenderer;
    Color myColor;
    void Start()
    {
        myRenderer = GetComponent<Renderer>();
        myColor = GetComponent<Renderer>().material.color;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            //myRenderer.material.color = Color.red;
            myColor = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            //myRenderer.material.color = Color.green;
            myColor = Color.green;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            //myRenderer.material.color = Color.blue;
            myColor = Color.blue;
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            //myRenderer.material.color = Color.cyan;
            myColor = Color.cyan;
        }
        myRenderer.material.color = myColor;
    }
}
