using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StructExample : MonoBehaviour
{
    public struct Struct
    {
        public int a, b;
        public Struct(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public void DebugLog()
        {
            Debug.LogFormat($"a = {a} b= {b}");
        }
    }
    
    void Start()
    {
        Struct str1;
        str1.a = 10;
        str1.b = 20;
        str1.DebugLog();

        //Struct str2 = new Struct(1, 2);
        Struct str2 = new Struct();
        str2.DebugLog();

        for (int i = 0; i < 100; i++)
        {
            
        }
    }
}
