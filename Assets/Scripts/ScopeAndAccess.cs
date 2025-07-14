using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAndAccess : MonoBehaviour
{
    public int alphaBetaGamma = 5;
    public int beta = 0;
    int gamma = 5;
    AnotherClass myOtherClass;
    void Start()
    {
        alphaBetaGamma = 29;
        myOtherClass = new AnotherClass();
        myOtherClass.FruitMachine(alphaBetaGamma, myOtherClass.apples);
    }

    void Example(int pens, int crayons)
    {
        int answer;
        answer = pens * crayons * alphaBetaGamma;
        Debug.Log(answer);
    }
    void Update()
    {
        Debug.Log("Alpha : " + alphaBetaGamma);
    }
}
