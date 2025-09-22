using UnityEngine;

namespace Namespace1
{
    public class NamespaceExample
    {
        public static void DebugLog(string message)
        {
            Debug.Log($"msg={message}");
        }
    }
}
