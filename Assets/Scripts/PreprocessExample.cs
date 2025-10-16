//#define Symbol1
#define Symbol2

using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

public class PreprocessExample : MonoBehaviour
{
#region source-code
    void Start()
    {
        int i = 0;
        if (i > 0)
        {

        }
        else if (i < 0)
        {

        }
#region if_else
        else
        {

        }
#endregion if_else
#if UNITY_EDITOR

#elif UNITY_STANDALONE_WIN
    #if (Symbol1 && !Symbol2)
                Debug.Log("Define1");
    #elif (!Symbol1 && Symbol2)
                Debug.Log("Define2");
    #elif (Symbol1 && Symbol2)
                Debug.Log("Define1, 2");
    #else
                Debug.Log("Nothing");
    #endif
#elif UNITY_ANDROID || UNITY_IOS
        Debug.Log("Android");
#elif UNITY_WEBGL

#endif
    }
#endregion source-code
}
