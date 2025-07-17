using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableExample : MonoBehaviour
{
    int globalNumber = 0;
    void Start()
    {
        // 16진수
        var hexLiteral = 0xaf;
        // 2진수
        var binaryLiteral = 0b_0000_0001;

        // 최대값, 최소값
        int i = int.MaxValue;
        float f = float.MinValue;

        bool b = default(bool); // b = false

        string s1 = null;
        string s2 = "";
        string s3 = string.Empty;

        if (s1 == s2)
        {
            Debug.Log("same");
        }
        else
        {
            Debug.Log("diff...");
        }

        // 참조에러 방지를 위한 코드
        if (s1 != null)
        {

        }

        // nullable
        int? ii = null;
        if (ii == null)
        {
            ii = 30;
        }

        int localNumber = 0;
        Console.WriteLine(globalNumber);
        Console.WriteLine(localNumber);

        int number1;
        number1 = 1;
        int number2 = 2;
        float newNumber = 3.4f, number4 = 4f;
        bool isBool = true;
        bool isNotTrue = true;
        bool isOver = false;

        if (isNotTrue)
        {
            // 참일때
        }
        else
        {
            // 거짓일때
        }

        Debug.Log(number1);
        Debug.Log(number1.ToString());
        Debug.Log(newNumber);
        Debug.Log("newNumber");
        Debug.Log(newNumber.ToString());
        Debug.Log(isNotTrue);
        Debug.Log(isNotTrue.ToString());
    }
}
