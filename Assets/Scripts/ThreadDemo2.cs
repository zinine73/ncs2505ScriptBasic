using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class ThreadDemo2 : MonoBehaviour
{
    void Start()
    {
        // EventWaitHandle ewh = new EventWaitHandle(false,
        //     EventResetMode.ManualReset);
        Thread thread = new Thread(Run);
        thread.Start();
        //thread.Start(ewh);

        for (int i = 0; i < 3; i++)
        {
            Debug.Log($"Main thread : {i}");
            Thread.Sleep(100);
        }
        //thread.Join();
        //ewh.WaitOne();
        thread.Abort();
        Debug.Log("Main thread end.");
    }
    
    static void Run(object obj)
    {
        //EventWaitHandle ewh = obj as EventWaitHandle;

        for (int i = 0; i < 5; i++)
        {
            Debug.Log($"Sub thread : {i}");
            Thread.Sleep(100);
        }
        Debug.Log("Sub thread end.");
        //ewh.Set();
    }
}
