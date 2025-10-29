using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class FileDemo : MonoBehaviour
{
    public string filePath = @"E:\NCS\MyTest.txt";
    void Start()
    {
        if (!File.Exists(filePath))
        {
            using (StreamWriter sw = File.CreateText(filePath))
            {
                sw.WriteLine("Hello");
                sw.WriteLine("And");
                sw.WriteLine("Welcome");
            }
        }
        using (StreamReader sr = File.OpenText(filePath))
        {
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                Debug.Log(s);
            }
        }        
    }
}
