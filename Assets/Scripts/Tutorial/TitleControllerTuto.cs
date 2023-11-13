using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TitleControllerTuto : MonoBehaviour
{
    
    private TextMeshProUGUI title;

    private void Start()
    {
        title = GetComponent<TextMeshProUGUI>();
    }

    private void OnEnable()
    {
        SlotTuto.OnItemDropped += SetTitle;
    }

    private void OnDisable()
    {
        SlotTuto.OnItemDropped -= SetTitle;
    }

    public void SetTitle(int position, string text)
    {
        title.text = text;
    }
}
