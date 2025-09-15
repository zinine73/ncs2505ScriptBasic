using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCase : MonoBehaviour
{
    enum EAvengers { IronMan, SpiderMan, Hulk };
    void Start()
    {
        EAvengers avengers = EAvengers.IronMan;
        // old
        switch (avengers)
        {
            case EAvengers.IronMan:
                Debug.Log("Iron Man");
                break;
            case EAvengers.SpiderMan:
                Debug.Log("SpiderMan");
                break;
            case EAvengers.Hulk:
                Debug.Log("Hulk");
                break;
            default:
                Debug.Log("Avengers");
                break;
        }
        // new
        string str = avengers switch
        {
            EAvengers.IronMan => "Iron Man",
            EAvengers.SpiderMan => "SpiderMan",
            EAvengers.Hulk => "Hulk",
            _ => "Avengers"
        };
        Debug.Log(str);
    }
}
