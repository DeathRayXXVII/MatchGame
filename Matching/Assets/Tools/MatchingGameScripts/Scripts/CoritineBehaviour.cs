using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoritineBehaviour : MonoBehaviour
{
    public bool canRun = true;
    public float seconds = 3.0f;
    private WaitForSeconds wfsObj;

    private WaitForFixedUpdate wffuObj;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        wfsObj = new WaitForSeconds(seconds);
        wffuObj = new WaitForFixedUpdate();
        Debug.Log("Start");
        yield return wfsObj;
        Debug.Log("late Start");

        while (canRun)
        {
            yield return wfsObj;
            Debug.Log("Run on Start");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
