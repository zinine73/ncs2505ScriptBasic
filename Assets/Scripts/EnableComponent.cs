using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnableComponent : MonoBehaviour
{
    Light myLight;
    void Start()
    {
        // 연결하기 전이라 에러난다
        //myLight.enabled = true;
        myLight = GetComponent<Light>();
        myLight.enabled = true;
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            myLight.enabled = !myLight.enabled;
        }
    }
}
