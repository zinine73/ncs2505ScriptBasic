using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TryCatch : MonoBehaviour
{
    GameObject go;
    void Start()
    {
        //go = new GameObject();
        try
        {
            Debug.Log(go.name);
        }
        catch (NullReferenceException ex)
        {
            Debug.Log(ex);
            //throw new Exception("error!");
        }
        finally
        {
            Debug.Log("여기는 실행됩니다.");
        }
        Debug.Log("여기도 실행됨");

        // throw sample
        //throw new Exception("error!");
    }
}
