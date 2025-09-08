using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultOperator : MonoBehaviour
{
    void Start()
    {
        Debug.Log(default(int));
        Debug.Log(default(char));
        Debug.Log(default(string));
        Debug.Log(default(float));
        Debug.Log(default(bool));
        Debug.Log(default(long));
        Debug.Log(default(double));

        Debug.Log(sizeof(int));
        Debug.Log(sizeof(char));
        //Debug.Log(sizeof(string));
        Debug.Log(sizeof(float));
        Debug.Log(sizeof(bool));
        Debug.Log(sizeof(long));
        Debug.Log(sizeof(double));
        Debug.Log(sizeof(byte));
        Debug.Log(sizeof(short));
    }
}
