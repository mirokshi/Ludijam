using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TitleControllerN1 : MonoBehaviour
{
    
    private TextMeshProUGUI title;

    private void Start()
    {
        title = GetComponent<TextMeshProUGUI>();
    }

    private void OnEnable()
    {
        SlotN1.OnItemDropped += SetTitle;
    }

    private void OnDisable()
    {
        SlotN1.OnItemDropped -= SetTitle;
    }

    public void SetTitle(int position, string text)
    {
        title.text = text;
    }
}
