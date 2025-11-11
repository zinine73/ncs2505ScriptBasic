using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Something", menuName = "MyCreate/GameData", order = 1)]
public class SpawnEntity : ScriptableObject
{
    public string name;
    public Vector3[] positions;
}
