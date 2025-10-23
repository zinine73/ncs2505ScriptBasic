using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackQueueExample : MonoBehaviour
{
    void Start()
    {
        var stack = new Stack<string>();
        stack.Push("first");
        stack.Push("second");
        stack.Push("third");

        foreach (var item in stack)
        {
            //Debug.Log(item);
        }
        //Debug.Log(stack.Peek());
        stack.Pop();
        foreach (var item in stack)
        {
            //Debug.Log(item);
        }

        var queue = new Queue<string>();
        queue.Enqueue("first");
        queue.Enqueue("second");
        queue.Enqueue("third");

        foreach (var item in queue)
        {
            Debug.Log(item);
        }
        Debug.Log($"Peek:{queue.Peek()}");
        queue.Dequeue();
        foreach (var item in queue)
        {
            Debug.Log(item);
        }
    }
}
