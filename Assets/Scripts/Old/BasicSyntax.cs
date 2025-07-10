using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicSyntax : MonoBehaviour
{
    void Start()
    {
        // 한줄주석....
        /*
        여러줄 주석..
        */
        Debug.Log(transform.position.x);

        if (transform.position.y >= 5f)
        {
            Debug.Log("I'm....");
        }

        if (transform.rotation.x < 4f)
        {

        }
    }
}
