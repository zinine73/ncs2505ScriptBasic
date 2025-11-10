using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class FileInfoDemo : MonoBehaviour
{
    public string filePath = Path.GetTempFileName();
    FileInfo fileInfoi1;
    void Start()
    {
        fileInfoi1 = new FileInfo(filePath);
        using (StreamWriter sw = fileInfoi1.CreateText())
        {
            sw.WriteLine("Hello");
            sw.WriteLine("And");
            sw.WriteLine("Welcome");
        }
        using (StreamReader sr = fileInfoi1.OpenText())
        {
            var s = "";
            while ((s = sr.ReadLine()) != null)
            {
                Debug.Log(s);
            }
        }

        try
        {
            string filePath2 = Path.GetTempFileName();
            var fileInfo2 = new FileInfo(filePath2);
            fileInfo2.Delete();
            fileInfoi1.CopyTo(filePath2);
            Debug.Log($"{filePath} was copied to {filePath2}.");
            fileInfo2.Delete();
            Debug.Log($"{filePath2} was deleted.");
        }
        catch (Exception e)
        {
            Debug.Log($"Failed : {e.ToString()}");
        }
    }
}
