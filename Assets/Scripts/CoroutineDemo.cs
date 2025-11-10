using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineDemo : MonoBehaviour
{
    public static readonly WaitForSeconds wfs2s
        = new WaitForSeconds(2.0f);
    IEnumerator m_Coroutine;
    bool isBreak;
    bool isCoroutineing;

    void Start()
    {
        m_Coroutine = CoroutineMethod();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            StartCoroutine(m_Coroutine);
        }
        if (isCoroutineing)
        {
            Debug.Log("코루틴이 실행 전이거나 종료되었다");
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            //StopCoroutine(m_Coroutine);
            isBreak = true;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            //StopAllCoroutines();
            isBreak = false;
            m_Coroutine = CoroutineMethod();
            StartCoroutine(m_Coroutine);
        }
    }

    IEnumerator CoroutineMethod()
    {
        int count = 0;
        while (true)
        {
            if (isBreak) break;
            Debug.Log(count);
            //yield return new WaitForSeconds(1f);
            yield return wfs2s;
            count++;
        }
        /*
        isCoroutineing = true;
        Debug.Log("start");
        yield return new WaitForSeconds(1f);
        Debug.Log("End");
        isCoroutineing = false;
        */
    }
}
