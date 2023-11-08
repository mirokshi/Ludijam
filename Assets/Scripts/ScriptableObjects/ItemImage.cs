using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UIElements;

[CreateAssetMenu(fileName = "New Image", menuName = "Image")]
public class ItemImage : ScriptableObject
{
    public string text;
    public int position;
    public Sprite image;
    public TypeItem typeItem;
    public int scoreReal;
    public int scoreCreativity;
}
