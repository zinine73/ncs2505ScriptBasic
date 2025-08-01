using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeScript : MonoBehaviour
{
    public GameObject target;
    int sum;
    void Start()
    {
        sum = 0;
        //Invoke("SpawnObject", 2.0f);
        InvokeRepeating("SpawnObject", 2.0f, 1.0f);
    }
    void Update()
    {
        if (sum >= 10)
        {
            CancelInvoke("SpawnObject");
        }
    }
    void SpawnObject()
    {
        // int와 float는 Random에서 max값을 지정할 때,
        // 포함인지 불포함인지 잘 봐야된다
        int i = Random.Range(-5, 5);
        float y = Random.Range(-5, 5);

        float x = Random.Range(-5.0f, 5.0f);
        float z = Random.Range(-5.0f, 5.0f);
        Instantiate(
            target,
            new Vector3(x, 2, z),
            Quaternion.identity
        );
        sum++;
    }
}
