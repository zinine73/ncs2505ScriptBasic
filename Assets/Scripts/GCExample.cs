using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GCExample : MonoBehaviour
{
    public TMP_Text scoreBoard;
    public int score;
    public int oldScore;
    void ConcatExample(int[] intArray)
    {
        string line = intArray[0].ToString();
        for (int i = 1; i < intArray.Length; i++)
        {
            line += "," + intArray[i].ToString();
        }
    }
    void Update()
    {
        if (score != oldScore)
        {
            string scoreText = "Score: " + score.ToString();
            scoreBoard.text = scoreText;
            oldScore = score;
        }
    }
    float[] RandomList(int numEl)
    {
        var result = new float[numEl];
        for (int i = 0; i < numEl; i++)
        {
            result[i] = Random.value;
        }
        return result;
    }
    void RandomList(float[] arrayToFill)
    {
        for (int i = 0; i < arrayToFill.Length; i++)
        {
            arrayToFill[i] = Random.value;
        }
    }
}
