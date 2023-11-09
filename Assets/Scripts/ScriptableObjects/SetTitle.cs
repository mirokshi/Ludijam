using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SetTitle : MonoBehaviour
{
    private TextMeshProUGUI _textMeshProUGUI;
    public Title titleSO;

    private void OnEnable()
    {
        Slot.OnItemDropped += setText;
    }

    private void OnDisable()
    {
        Slot.OnItemDropped -= setText;
    }

    private void Start()
    {
        _textMeshProUGUI = GetComponent<TextMeshProUGUI>();

        Constructor();

    }

    private void Constructor()
    {
        string constructor = null;

        if (titleSO.parts != null)
        {
            for (int i = 0; i < titleSO.parts.Length; i++)
            {
                if (i != 0)
                {
                    constructor += " ";
                }

                constructor += titleSO.parts[i];

                if (i != titleSO.parts.Length - 1)
                {
                    constructor += " ";
                }
            }
        }
        else
        {
            constructor = titleSO.uncompletedTitle;
        }

        _textMeshProUGUI.text = constructor;
    }

    public void setText(int position, string text)
    {
        int index=0;  
        switch (position)
        {
            case 1:
               index= ReplaceText(1);
                break;
            case 2:
                index=ReplaceText(1);
                break;
            case 3:
                index=ReplaceText(3);
                break;
            case 4:
                index=ReplaceText(4);
                break;
            default:
                index = -1;
                break;
        }

        titleSO.parts[index] = text;
        
        Constructor();
    }

    private int ReplaceText(int n)
    {
        int count=0;
        for (int i = 0; i < titleSO.parts.Length; i++)
        {
            if (titleSO.parts[i]=="__")
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