using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatSample : MonoBehaviour
{
    void Start()
    {
        /*
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Debug.Log($"i = {i} j = {j}");
            }
        }
        // 위와 같지 않다!
        // for (int i = 0, j = 0; i < 5 && j < 4; i++, j++)
        // {
        //     Debug.Log($"i = {i} j = {j}");
        // }
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(i.ToString());
        }
        */
        //int[] numbers = new int[] { 1, 2, 34, 5 };
        int[,] numbers = new int[,] { { 1, 2 }, { 34, 56 }, { 7, 89 } };
        //foreach (int number in numbers)
        // for (int i = 0; i < numbers.GetLength(0); i++)
        // {
        //     for (int j = 0; j < numbers.GetLength(1); j++)
        //     {
        //         Debug.Log($"{numbers[i, j]}");
        //     }
        // }
        foreach (var item in numbers)
        {
            //Debug.Log($"{item}");
        }

        int n = 6;
        while (n < 5)
        {
            Debug.Log($"while : {n}");
            n++;
        }
        n = 6;
        do
        {
            Debug.Log($"do-while : {n}");
            n++;
        } while (n < 5);
    }
}
