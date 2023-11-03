using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelpSystem : MonoBehaviour
{
    public List<GameObject> objectsToDelete;
    public Button button;

    private void Start()
    {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(DeleteObject);
    }

    private void DeleteObject()
    {
        if (objectsToDelete.Count > 0) {
            objectsToDelete.RemoveAt(0);
        }
    }
}
