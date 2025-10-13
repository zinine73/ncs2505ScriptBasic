using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseClass
{
    public string stringVariable;
    public int intVariable { get; set; }
}

// 추상 클래스/메서드
abstract public class ABSBaseClass
{
    abstract public void Method();
}
// Override
public class DerivedClass3 : ABSBaseClass
{
    override public void Method()
    {
        Debug.Log("Abstract Method");
    }
}

public class DerivedClass1 : BaseClass
{
    public void Method()
    {
        Debug.Log(stringVariable);
    }
}

public class DerivedClass2 : BaseClass
{
    public void Method()
    {
        Debug.Log(intVariable);
    }
}

public class ClassSample2 : MonoBehaviour
{
    //DerivedClass1 baseClass1 = new DerivedClass1();
    BaseClass baseClass1 = new DerivedClass1();

    DerivedClass2 baseClass2 = new DerivedClass2();
    //ABSBaseClass bc1 = new ABSBaseClass();
    DerivedClass3 dc1 = new DerivedClass3();
    void Start()
    {
        baseClass1.stringVariable = "DerivedClass1";
        ((DerivedClass1)baseClass1).Method();
        baseClass2.intVariable = 3;
        baseClass2.Method();
        dc1.Method();
    }
}
