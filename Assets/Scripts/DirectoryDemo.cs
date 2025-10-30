using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using System.Linq;

public class DirectoryDemo : MonoBehaviour
{
    public string sourceDir = @"E:\NCS\Current";
    public string archiveDir = @"E:\NCS\Archive";
    void Start()
    {
        /*
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
        */

        var files = from retrievedFile in Directory.EnumerateFiles(archiveDir, "*.txt",
        SearchOption.AllDirectories)
                    from line in File.ReadLines(retrievedFile)
                    where line.Contains("Example")
                    select new
                    {
                        File = retrievedFile,
                        Line = line
                    };
        foreach (var f in files)
        {
            Debug.Log($"{f.File} contains {f.Line}");
        }
        Debug.Log($"{files.Count()} lines found.");
    }
}
