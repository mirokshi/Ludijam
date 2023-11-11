using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class SetItemN2 : MonoBehaviour
{
   public ItemImage itemImage;
   
   public string text;
   public int position;
   public Sprite sprite;
   public TypeItem typeItem;
   public int scoreReal;
   public int scoreCreativity;

   private void Start()
   {
      text = itemImage.text;
      position = itemImage.position;
      sprite = itemImage.sprite;
      typeItem = itemImage.typeItem;
      scoreReal = itemImage.scoreReal;
      scoreCreativity = itemImage.scoreCreativity;

   }
}
