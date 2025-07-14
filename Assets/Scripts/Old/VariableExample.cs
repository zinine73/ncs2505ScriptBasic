using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableExample : MonoBehaviour
{
    int globalNumber = 0;
    void Start()
    {
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
