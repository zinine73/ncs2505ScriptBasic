using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringSample : MonoBehaviour
{
    void Start()
    {
        float a = 1.0f;
        float b = 2f;
        //Debug.Log($"c={a} d={b} c+d={a + b}");
        //Debug.LogFormat("c={0} d={1} c+d={2}", a, b, a + b);

        string talkFormat = string.Empty;
        string talk2 = "";
        string name = "Iron Man";
        int age = 55;
        talkFormat = "I am {0}. I am {1} years old.";
        talk2 = $"I am {name}. I am {age} years old.";
        //Debug.LogFormat("I am {0}. I am {1} years old.", name, age);
        //Debug.Log($"I am {name}. I am {age} years old.");
        SelfIntro(talkFormat, talk2, name, age);

        name = "Super Man";
        age = 100;
        talk2 = $"I am {name}. I am {age} years old.";
        //Debug.LogFormat("I am {0}. I am {1} years old.", name, age);
        //Debug.Log($"I am {name}. I am {age} years old.");
        SelfIntro(talkFormat, talk2, name, age);

        name = "Thor";
        age = 4000;
        talkFormat = "I am {0}. I am {0}";
        talk2 = $"I am {name}. I am {name}";
        //Debug.LogFormat("I am {0}. I am {0}", name, age);
        //Debug.Log($"I am {name}. I am {name}");
        SelfIntro(talkFormat, talk2, name, age);
    }

    void SelfIntro(string talkFormat, string talk2, string name, int age)
    {
        Debug.LogFormat(talkFormat, name, age);
        Debug.Log(talk2);
    }
}
