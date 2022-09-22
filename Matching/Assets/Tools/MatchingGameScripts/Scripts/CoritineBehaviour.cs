using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Tools.MatchingGameScripts.Scripts
{
    public class CoritineBehaviour : MonoBehaviour
    {
        public UnityEvent startEvent, startCountEvent, repeatCountEvent, endCountEvent, repeatUntilFalseEvent;

        public bool canRun;
        public intData counterNum;
        public float seconds = 3.0f;
        private WaitForSeconds _wfsObj;
        private WaitForFixedUpdate _wffuObj;
        

        private void Start()
        {
            _wfsObj = new WaitForSeconds(seconds);
            _wffuObj = new WaitForFixedUpdate();
            startEvent.Invoke();
        }

        public void StartCounting()
        {
        
            StartCoroutine(Counting());
        }
        private IEnumerator Counting()
        {
            startCountEvent.Invoke();
            yield return _wfsObj;
            while(counterNum.value > 0)
            { 
            
                repeatCountEvent.Invoke();
                counterNum.value--;
                yield return _wfsObj;
            }
            endCountEvent.Invoke();
        }

        public void StartRepeatUntilFalse()
        {
            canRun = true;
            StartCoroutine(RepeatUntilFalse());
        }
        private IEnumerator RepeatUntilFalse()
        {
            
            while(canRun)
            {
                yield return _wfsObj;
                repeatUntilFalseEvent.Invoke();
            }
        }
    }
}
