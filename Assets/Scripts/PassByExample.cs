using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassByExample : MonoBehaviour
{
    void Start()
    {
        // int c = 0;
        // int rv = Add(1, 2, c);
        // Debug.Log($"c={c}, rv={rv}");
        int a = 1, b = 2;
        int c = 0; // 초기화
        bool b1 = RefMethod(a, b, ref c);

        int d = 3, e = 4;
        //int f; // 초기화 안 함
        //bool b2 = OutMethod(d, e, out f);
        bool b2 = OutMethod(d, e, out int f);
        Debug.Log($"c = {c}, f = {f}");
    }

    int Add(int a, int b, int c)
    {
        c = a + b;
        return c;
    }

    bool RefMethod(int a, int b, ref int c)
    {
        c = a + b;
        return true;
    }

    bool OutMethod(int d, int e, out int f)
    {
        f = d + e;
        return true;
    }
}
