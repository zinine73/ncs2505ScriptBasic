using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpSample : MonoBehaviour
{
    void Start()
    {
        int i = 0;
        for (i = 0; i < 10; i++)
        {
            if (i < 7)
            {
                continue;
            }
            Debug.Log(i);
            // if (i > 8)
            // {
            //     break;
            // }
        }
        Debug.Log($"i : {i}");
    }
}
