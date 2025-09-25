using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class1
{
    public static int staticInt;
    public int intVariable;
    string strVariable;

    public Class1() { } // 기본생성자
    public Class1(int i) // 일반생성자
    {
        intVariable = i;
    }

    public void DebugLog(string message)
    {
        strVariable = message;
        Debug.Log(message);
    }

    public void Start()
    {
        Debug.Log($"Start Class1, iv = {intVariable}");
    }

    public static void StaticMethod()
    {
        staticInt++;
        //intVariable++; // error!!!
    }
}

public class ClassSample : MonoBehaviour
{
    int aa = Class1.staticInt;
    //Class1 class1 = new Class1();
    Class1 class1 = new Class1(100);

    int property = 0;
    public int Property
    {
        get
        {
            Debug.Log("Get property");
            return property;
        }
        set
        {
            if (value > 100) value = 100;
            property = value;
        }
    }
    public int Pty2 { get; set; }
    
    void Awake()
    {
        //property = 1;
        Property = 444;
    }
    public void Start()
    {
        Class1.staticInt++;
        class1.DebugLog("Example");
        class1.Start();
        //property = 100;
        Debug.Log(property);
    }

    // public void SetProperty(int val)
    // {
    //     if (val > 100) val = 100;
    //     property = val;
    // }
}
