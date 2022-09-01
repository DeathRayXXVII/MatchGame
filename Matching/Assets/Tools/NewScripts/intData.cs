using UnityEngine;

[CreateAssetMenu]
public class intData : ScriptableObject
{
    public int value;

    public void UpdateValue(int num)
    {
        value += num;
    }
}
