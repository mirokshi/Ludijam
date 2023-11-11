using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SetTitle : MonoBehaviour
{
    private TextMeshProUGUI _textMeshProUGUI;
    public Title titleScriptableObject;
    private string[] copyTitle;
    private int[] positions = new int[4];
    private void OnEnable()
    {
        Slot.OnItemDropped += SetText;
    }

    private void OnDisable()
    {
        Slot.OnItemDropped -= SetText;
    }

    private void Start()
    {
        _textMeshProUGUI = GetComponent<TextMeshProUGUI>();

        copyTitle = new string[titleScriptableObject.parts.Length];
        titleScriptableObject.parts.CopyTo(copyTitle,0);
        
        SetPositions();
        Constructor();
    }

    private void SetPositions()
    {
        positions[0]=SearchText(1);
        positions[1]=SearchText(2);
        positions[2]=SearchText(3);
        positions[3]=SearchText(4);
    }

    private void Constructor()
    {
        string constructor = null;

        if (copyTitle != null)
        {
            for (int i = 0; i < copyTitle.Length; i++)
            {
                if (i != 0)
                {
                    constructor += " ";
                }

                constructor += copyTitle[i];

                if (i != copyTitle.Length - 1)
                {
                    constructor += " ";
                }
            }
        }
        else
        {
            constructor = titleScriptableObject.uncompletedTitle;
        }

        _textMeshProUGUI.text = constructor;
    }

    public void SetText(int position, string text)
    {
        copyTitle[positions[position - 1]] = text;
        Constructor();
    }

    private int SearchText(int n)
    {
        int count=0;
        for (int i = 0; i < copyTitle.Length; i++)
        {
            if (copyTitle[i]=="__")
            {
                count++;
                if (count==n)
                {
                    return i;
                }
            }
        }
        return -1;
    }
}