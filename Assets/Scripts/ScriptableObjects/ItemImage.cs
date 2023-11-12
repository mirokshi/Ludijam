using UnityEngine;

[CreateAssetMenu(fileName = "New Image", menuName = "Image")]
public class ItemImage : ScriptableObject
{
    public Sprite sprite;
    public string text;
    public int position;
    public TypeItem typeItem;
    public int scoreReal;
    public int scoreCreativity;
}
