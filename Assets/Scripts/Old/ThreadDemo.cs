using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
public class ThreadDemo : MonoBehaviour
{
    void Start()
    {
        /*
        //Thread thread = new Thread(Run);
        //Thread thread = new Thread(new ThreadStart(Run));
        //Thread thread = new Thread(() => Run());
        Thread thread = new Thread(delegate ()
        {
            Run();
        });
        thread.Start();
        */
        //new Thread(() => Run()).Start();
        //Thread thread = new Thread(Run2);
        //thread.Start(1);
        /*
        Thread thread = new Thread(() => Sum(1, 2, 3));
        thread.Start();
        Thread t2 = new Thread(() => Run(1));
        t2.IsBackground = true;
        t2.Start();
        */
        ThreadPool.QueueUserWorkItem(Run);
        ThreadPool.QueueUserWorkItem(Run, 1);
        ThreadPool.QueueUserWorkItem(Run, 2);
    }

    void Run()
    {
        Debug.Log($"Thread#{Thread.CurrentThread.ManagedThreadId} :  start");
        Thread.Sleep(1000);
        Debug.Log($"Thread#{Thread.CurrentThread.ManagedThreadId} :  end");
    }

    void Run(object obj)
    {
        Debug.Log(obj);
    }

    static void Sum(int d1, int d2, int d3)
    {
        int sum = d1 + d2 + d3;
        Debug.Log(sum);
    }
}
