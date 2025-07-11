using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoop : MonoBehaviour
{
    int numEnemies = 3;

    void Start()
    {
        for (int i = 0; i < numEnemies; i++)
        {
            //Debug.Log("Enemy : " + i);
        }

        var iarray = new int[10];
        for (int i = 0; i < iarray.Length; i++)
        {
            iarray[i] = i + 1;
        }
        for (int i = 9; i >= 0; i -= 2)
        {
            Debug.Log(iarray[i]);
        }

        for (int i = 0, j = 0; i < 10; i++, j++)
        {

        }
    }
}
