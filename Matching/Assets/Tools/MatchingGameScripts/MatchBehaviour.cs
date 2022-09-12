using UnityEngine;
using UnityEngine.Events;

public class MatchBehaviour : MonoBehaviour
{
    public ID idObj;
    private ID otherID;
    public UnityEvent matchEvent, noMatchEventt;
    private void OnTriggerEnter(Collider other)
    {
        //fecting the otherID from a diffrent script
        var tempObj = other.GetComponent<IDContanerBehavour>();
        //if this is not null get the ID
        if (tempObj == null)
            return;
        
        var otherID = tempObj.idObj;
        //checking if the ID's are the same
        if (otherID == idObj)
        {
            matchEvent.Invoke();
        }
        else
        {
            noMatchEventt.Invoke();
        }
    }
}
