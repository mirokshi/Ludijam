using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SetScriptableObjecs : MonoBehaviour
{
    public ItemImage item;
    public Image Image;
    private void Start()
    {
         this.Image.sprite = item.image;
    }
}
