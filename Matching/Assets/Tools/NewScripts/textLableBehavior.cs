using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[RequireComponent(typeof(TextMeshProUGUI))]
public class textLableBehavior : MonoBehaviour
{
    public TextMeshProUGUI Label;
    public floatData dataObj;
    public intData dataObject;

    private void Start()
    {
        Label = GetComponent<TextMeshProUGUI>();
        UpdateLabel();
    }

    public void UpdateLabel()
    {
        Label.text = dataObj.value.ToString(CultureInfo.CurrentCulture);
        //Label.text = dataObject.value.ToString(CultureInfo.CurrentCulture);
    }
}
