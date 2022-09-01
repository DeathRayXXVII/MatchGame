using UnityEngine;

[CreateAssetMenu]
public class boolData : ScriptableObject
{
    public bool value;

    public void SetValue(bool changeValue)
    {
        value = changeValue;
    }
}
