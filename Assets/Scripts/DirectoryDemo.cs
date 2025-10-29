using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DirectoryDemo : MonoBehaviour
{
    public string sourceDir = @"E:\NCS\Current";
    public string archiveDir = @"E:\NCS\Archive";
    void Start()
    {
        try
        {
            var txtFiles = Directory.EnumerateFiles(sourceDir);
            foreach (var currentFile in txtFiles)
            {
                string fileName = currentFile.Substring(sourceDir.Length + 1);
                Directory.Move(currentFile, Path.Combine(archiveDir, fileName));
            }
        }
        catch (Exception e)
        {
            Debug.Log(e.Message);
            
        }
    }
}
