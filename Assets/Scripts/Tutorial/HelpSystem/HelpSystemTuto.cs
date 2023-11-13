using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class HelpSystemTuto : MonoBehaviour
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
        if (objectsToDelete.Count > 0)
        {
            var firstElement = objectsToDelete.ElementAt(0);
            Destroy(firstElement);
            objectsToDelete.RemoveAt(0);
        }
    }
}
