using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParameterSample : MonoBehaviour
{
    void Start()
    {
        /*
        NamedParameter("Lee", 23, 30.5f);
        NamedParameter(name: "CoderZero", height: 174.5f, age: 47);
        NamedParameter(age: 10, name: "Kim", height: 10.2f);
        // 생략되도 타입이 같으면 에러나지 않지만, 통일성을 위해 생략하지 말자
        NamedParameter(name: "Yang", age: 90, 3.1f);
        */
        //OptionalParameter(1, 2.3f);
        //OptionalParameter(1, 2.3f, false);
        OP2(1, 2);
        OP2(1, 2, isInt: false);
        OP2(i: 3, j: 4, f: 2.1f);
        OP2(isInt: false, j: 3, i: 2);
    }

    void NamedParameter(string name, int age, float height)
    {
        Debug.Log($"Name:{name}, Age:{age}, Height:{height}");
    }

    void OptionalParameter(int i, float f, bool isInt = true)
    {
        if (isInt)
        {
            Debug.Log(i);
        }
        else
        {
            Debug.Log(f);
        }
    }

    void OP2(int i, int j, float f = 1.2f, bool isInt = true)
    {
        if (isInt)
        {
            Debug.Log(i + j);
        }
        else
        {
            Debug.Log(f);
        }
    }
}
