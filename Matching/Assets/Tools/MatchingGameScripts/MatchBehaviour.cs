using UnityEngine;

public class MatchBehaviour : MonoBehaviour
{
    public ID idObj;
    private void OnTriggerEnter(Collider other)
    {
        //fecting the otherID from a diffrent script
        var otherID = other.GetComponent<IDContanerBehavour>().idObj;
        //checking if the ID's are the same
        if (otherID == idObj)
        {
            Debug.Log("Matched");
        }
    }
}
