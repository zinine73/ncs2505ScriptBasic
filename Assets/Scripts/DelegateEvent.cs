using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class DelegateEventClass
{
    public delegate void DelegateMethod(string message);
    public event DelegateMethod EventMethod;

    public void MultipleOf5(int number)
    {
        if (number % 5 == 0 && number != 0)
        {
            EventMethod($"{number}는 5의 배수");
        }
    }
}

public class DelegateEvent : MonoBehaviour
{
    void Start()
    {
        DelegateEventClass dec = new DelegateEventClass();
        dec.EventMethod += DebugLog;

        for (int i = 0; i < 30; i++)
        {
            dec.MultipleOf5(i);
        }
    }

    void DebugLog(string message)
    {
        Debug.Log(message);
    }
}
