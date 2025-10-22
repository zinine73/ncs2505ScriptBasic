using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System.Threading.Tasks;

public class ParallelForExample : MonoBehaviour
{
    void Start()
    {
        /* 
        Parallel.For(0, 1000, (i) =>
        {
            Debug.Log($"{Thread.CurrentThread.ManagedThreadId} : {i}");
        });

        List<string> alphabets = new List<string>();
        alphabets.Add("A");
        alphabets.Add("B");
        alphabets.Add("C");
        alphabets.Add("D");
        alphabets.Add("E");
        alphabets.Add("F");
        alphabets.Add("G");

        Parallel.ForEach(alphabets, new ParallelOptions
        { MaxDegreeOfParallelism = 4 }, fruit =>
        {
            Debug.Log($"Alphabet: {fruit}, Thread Id= {Thread.CurrentThread.ManagedThreadId}");
        }
        );
        */

        Parallel.Invoke(() =>
        {
            Debug.Log("1");
        },
        () =>
        {
            Debug.Log("2");
        },
        () =>
        {
            Debug.Log("3");
        });
    }
}
