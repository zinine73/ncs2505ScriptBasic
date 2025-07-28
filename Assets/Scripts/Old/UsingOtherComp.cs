using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingOtherComp : MonoBehaviour
{
    public GameObject otherGameObject;
    AnotherScript anotherScript;
    YetAnotherScript yetAnotherScript;
    BoxCollider boxCol;
    void Awake()
    {
        anotherScript = GetComponent<AnotherScript>();
        yetAnotherScript = otherGameObject.GetComponent<YetAnotherScript>();
        boxCol = otherGameObject.GetComponent<BoxCollider>();
    }
    void Start()
    {
        boxCol.size = new Vector3(3, 3, 3);
        Debug.Log("Player score : " + anotherScript.playerScore);
        Debug.Log("Player died " + yetAnotherScript.numberOfPlayerDeaths + "times");
    }
}
