using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataTypeScript : MonoBehaviour
{
    public GameObject[] players;
    void Start()
    {
        // value
        Vector3 pos = transform.position;
        pos = new Vector3(0, 2, 0);
        // reference
        Transform tran = transform;
        tran.position = new Vector3(0, 2, 0);

        //players = GameObject.FindGameObjectsWithTag("Player");
        for (int i = 0; i < players.Length; i++)
        {
            Debug.Log("Player Number" + i + "is named" + players[i].name);
        }
    }
}
