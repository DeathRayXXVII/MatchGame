using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class CoritineBehaviour : MonoBehaviour
{
    public UnityEvent startEvent, startCountEvent, repeatCountEvent, endCountEvent, repeatUntilFalseEvent;

    public bool canRun;
    public intData counterNum;
    public float seconds = 3.0f;
    private WaitForSeconds wfsObj;
    private WaitForFixedUpdate wffuObj;

    private void Start()
    {
        startEvent.Invoke();
    }

    public void StartCounting()
    {
        wfsObj = new WaitForSeconds(seconds);
        wffuObj = new WaitForFixedUpdate();
        StartCoroutine(Counting());
    }
    // Start is called before the first frame update
    private IEnumerator Counting()
    {
        
        startCountEvent.Invoke();
        yield return wfsObj;
        
        while(counterNum.value > 0)
        { 
            
            repeatCountEvent.Invoke();
            counterNum.value--;
            yield return wfsObj;
        }
        endCountEvent.Invoke();
    }

    public void StartRepeatUntilFalse()
    {
        canRun = true;
        StartCoroutine(RepeatUnitlFalse());
    }
    private IEnumerator RepeatUnitlFalse()
    {
        while(canRun)
        {
            yield return wffuObj;
            repeatUntilFalseEvent.Invoke();
        }
    }
}
