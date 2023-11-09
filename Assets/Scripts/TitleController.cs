using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TitleController : MonoBehaviour
{
    
    private TextMeshProUGUI title;

    private void Start()
    {
        title = GetComponent<TextMeshProUGUI>();
    }

    private void OnEnable()
    {
        Slot.OnItemDropped += SetTitle;
    }

    private void OnDisable()
    {
        Slot.OnItemDropped -= SetTitle;
    }

    public void SetTitle(int position, string text)
    {
        title.text = text;
    }
}
