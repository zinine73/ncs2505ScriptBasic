using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoop : MonoBehaviour
{
    int cupsInTheSink = 4;
    void Start()
    {
        while (cupsInTheSink > 0)
        {
            Debug.Log("washed cup");
            cupsInTheSink--;
        }

        bool shouldContinue = false;
        do
        {
            print("Hello world");
        } while (shouldContinue == true);
    }
}
