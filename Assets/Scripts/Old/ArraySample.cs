using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraySample : MonoBehaviour
{
    void Start()
    {
        // string[] Avengers = new string[3];
        // Avengers[0] = "Iron Man";
        // Avengers[1] = "Captain America";
        // Avengers[2] = "Spider Man";
        string[] Avengers = new string[] {
            "Iron Man", "Captain America", "Spider Man"};
        Debug.Log(Avengers[1]);
        var numbers = new int[] { 1, 2, 3, 4 };

        int[,] number2Ds = new int[2, 3];
        number2Ds[0, 0] = 0;
        // 중간 생략
        number2Ds[1, 2] = 12;
        Debug.Log(number2Ds[0, 0]);
        string[,] string2Ds = new string[,]{
            {"one","two"},{"three","four"},{"five","six"}
        };
        bool[,,] isBool3s = new bool[2, 2, 3];
        isBool3s[0, 0, 0] = true;

        int[][] jaggedArray = new int[3][];
        // jaggedArray[0] = new int[2];
        // jaggedArray[1] = new int[4];
        // jaggedArray[2] = new int[3];
        jaggedArray[0] = new int[] { 1, 2 };
        jaggedArray[1] = new int[] { 3, 4, 5, 6 };
        jaggedArray[2] = new int[] { 7, 8, 9 };
        Debug.Log(jaggedArray[1][0]);

        int[][] jaggedArray2 = //new int[][]
        {
            new int[]{ 0, 5, 6 },
            new int[]{ 2, 6 },
            new int[]{ 7, 1, 6, 3 }
        };

        float[] floats = new float[5];
        Array.Clear(floats, 0, 3);
        Array.Resize(ref floats, floats.Length + 1);
    }
}
