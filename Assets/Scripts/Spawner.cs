using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prfbEntity;
    public SpawnEntity spawnEntity;
    void Start()
    {
        SpawnEntities();
    }

    void SpawnEntities()
    {
        for (int i = 0; i < spawnEntity.positions.Length; i++)
        {
            GameObject currentEntity =
                Instantiate(prfbEntity,
                spawnEntity.positions[i],
                Quaternion.identity);
            currentEntity.name = spawnEntity.name + i;
        }
    }
}
