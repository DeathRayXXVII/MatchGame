using UnityEngine;

public class CoiorIDBehavour : IDContanerBehavour
{
    public ColorIDDataList colorIDDataListObj;

    private void Awake()
    {
        idObj = colorIDDataListObj.currentColor;
    }
}
