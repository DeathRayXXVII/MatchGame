using UnityEngine;

[CreateAssetMenu]
public class intData : ScriptableObject
{
    public int value;

    public void SetValue(int num)
    {
        value = num;
    }

    public void UpdateValue(int num)
    {
        value += num;
    }
}
