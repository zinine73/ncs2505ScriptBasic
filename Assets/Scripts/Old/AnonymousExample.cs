using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnonymousExample : MonoBehaviour
{
    delegate int MyDelegate(int a, int b);
    void Start()
    {
        //var t = new { name = "CodeZero", age = 47 };
        //Debug.Log($"{t.name} {t.age}");
        MyDelegate sum;
        sum = delegate (int a, int b)
        {
            return a + b;
        };
        //Debug.Log(sum(1, 2));

        // lambda
        MyDelegate calculate = (a, b) => a + b;
        Debug.Log($"{1} + {2} = {calculate(1, 2)}");
    }

    // int GetSum(int x, int y)
    // {
    //     return x + y;
    // }
}
