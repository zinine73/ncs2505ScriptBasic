using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableType : MonoBehaviour
{
    // filed
    static public bool staticVariable = true;
    int globalVariable = 1;
    public int publicValue = 1;
    public int pv2 = 4;
    public bool isPublic = false;
    void Start()
    {
        int localVariable = 1;
        int localVariable2;
        //Debug.Log(localVariable2);
        LocalVariable(1);
        Debug.Log(pv2);
    }
    void LocalVariable(int parameter)
    {
        float localVariable = parameter;
    }
}
