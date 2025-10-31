using UnityEngine;
using System;
using System.IO;

// Json data class
[Serializable]
public class JsonData
{
    public string name;
    public int age;
    public float height;
    public bool man;
    public string description;
    public string[] tools;
}
public class JsonExample : MonoBehaviour
{
    const string filePath = @"E:\NCS\JsonExample.json";
    void Start()
    {
        // jsondata class 생성
        // JsonData[] jsonData = new JsonData[2];
        // jsonData[0] = new JsonData();
        // jsonData[1] = new JsonData();
        int len = 2;
        JsonData[] jsonData = new JsonData[len];
        for (int i = 0; i < len; i++)
        {
            jsonData[i] = new JsonData();
        }

        jsonData[0].name = "coderzero";
        jsonData[0].age = 48;
        jsonData[0].height = 172.5f;
        jsonData[0].man = true;
        jsonData[0].description = null;
        jsonData[0].tools = new string[3];
        jsonData[0].tools[0] = "Unity";
        jsonData[0].tools[1] = "Visual Studio";
        jsonData[0].tools[2] = "Photoshop";

        jsonData[1].name = "coderzero";
        jsonData[1].age = 48;
        jsonData[1].height = 172.5f;
        jsonData[1].man = true;
        jsonData[1].description = null;
        jsonData[1].tools = new string[2];
        jsonData[1].tools[0] = "3D Max";
        jsonData[1].tools[1] = "Photoshop";

        // serialize
        string toJson0 = JsonUtility.ToJson(jsonData[0]);
        Debug.Log(toJson0);

        string toJson1 = JsonUtility.ToJson(jsonData[1]);
        Debug.Log(toJson1);

        // de-serialize
        JsonData fromJson
            = JsonUtility.FromJson<JsonData>(toJson0);
        Debug.Log(fromJson.name);

        // save file
        File.WriteAllText(filePath, toJson1);

        // load file
        string readJson = File.ReadAllText(filePath);
        Debug.Log(readJson);
    }
}
