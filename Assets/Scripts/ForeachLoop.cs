using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachLoop : MonoBehaviour
{
    void Start()
    {
        var strings = new string[3];
        strings[0] = "First string";
        strings[1] = "Second string";
        strings[2] = "Third string";

        foreach (var item in strings)
        {
            print(item);
        }
        for (int i = 0; i < strings.Length; i++)
        {
            if (i != 0)
            {
                print(strings[i]);
            }
        }

        var myList = new List<int>();
        foreach (var item in myList)
        {
            print(item);
        }
    }
}
