using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

[RequireComponent(typeof(TextMeshProUGUI))]
public class textLableBehavior : MonoBehaviour
{
    private TextMeshProUGUI Label;
    public UnityEvent startEvent;

    private void Start()
    {
        Label = GetComponent<TextMeshProUGUI>();
        startEvent.Invoke();
    }

    public void UpdateLabel(FloatData obj)
    {
        Label.text = obj.value.ToString(CultureInfo.InvariantCulture);
    }

    public void UpdateLabel(IntData obj)
    {
        Label.text = obj.value.ToString(CultureInfo.InvariantCulture);
    }

}
