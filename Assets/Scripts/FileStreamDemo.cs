using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using System.Text;
using System;

public class FileStreamDemo : MonoBehaviour
{
    public string path = @"E:\NCS\Current";
    public string fileName = "FileStream.txt";
    void Start()
    {
        DirectoryInfo di = new DirectoryInfo(path);
        if (!di.Exists)
        {
            di.Create();
        }

        using (FileStream fs = File.Create(Path.Combine(path, fileName)))
        {
            AddText(fs, "This is some sample.");
            AddText(fs, "This is some message.");
            AddText(fs, "and this is on a new line");
            AddText(fs, "\r\n\r\nThe ... characters:\r\n");

            for (int i = 1; i < 120; i++)
            {
                AddText(fs, Convert.ToChar(i).ToString());
            }
        }

        using (FileStream fs = File.OpenRead(Path.Combine(path, fileName)))
        {
            byte[] b = new byte[1024];
            UTF8Encoding temp = new UTF8Encoding(true);
            while (fs.Read(b, 0, b.Length) > 0)
            {
                Debug.Log(temp.GetString(b));
            }
        }
    }

    void AddText(FileStream fs, string value)
    {
        byte[] info = new UTF8Encoding(true).GetBytes(value);
        fs.Write(info, 0, info.Length);
    }
}
