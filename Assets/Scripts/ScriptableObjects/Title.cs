using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Title", menuName = "Title")]
public class Title : ScriptableObject
{
    public string completedTitle;
    public string uncompletedTitle;
    public string[] parts;
}
