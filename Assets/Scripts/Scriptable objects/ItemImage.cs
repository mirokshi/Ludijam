using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

[CreateAssetMenu(fileName = "New Image", menuName = "Image")]
public class ItemImage : ScriptableObject
{
    public string text;
    public int position;
    public Sprite image;
}
