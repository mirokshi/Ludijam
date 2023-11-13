using UnityEngine;

[CreateAssetMenu(fileName = "New Image", menuName = "Image")]
public class ItemImage : ScriptableObject
{
    public string text;
    public int position;
    public TypeItem typeItem;
    public int scoreReal;
    public int scoreCreativity;
}
