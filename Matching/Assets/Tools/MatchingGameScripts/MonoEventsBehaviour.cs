using System;
using UnityEngine;
using UnityEngine.Events;

public class MonoEventsBehaviour : MonoBehaviour
{
    public UnityEvent startEvent, awakeEvent, disableEvent;

    //Awake happens before start
    private void Awake()
    {
        awakeEvent.Invoke();
    }
    //Activates when the game starts
    private void Start()
    {
        startEvent.Invoke();
    }
    //Activates when a function becomes disabled
    private void OnDisable()
    {
        disableEvent.Invoke();
    }
}
