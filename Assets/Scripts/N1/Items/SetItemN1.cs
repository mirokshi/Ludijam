using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class SetItemN1 : MonoBehaviour
{
    public ItemImage itemScriptableObject;

    [HideInInspector] public string text;
    [HideInInspector] public int position;
    [HideInInspector] public TypeItem typeItem;
    [HideInInspector] public int scoreReal;
    [HideInInspector] public int scoreCreativity;

    private void Start()
    {
        
        if (itemScriptableObject!=null)
        {
            text = itemScriptableObject.text;
            position = itemScriptableObject.position;
            typeItem = itemScriptableObject.typeItem;
            scoreReal = itemScriptableObject.scoreReal;
            scoreCreativity = itemScriptableObject.scoreCreativity;    
        }
    }
}