using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour,IDropHandler
{
    [SerializeField] private TypeItem typeItem;
    public void OnDrop(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag;
        DragDrop draggableItem = dropped.GetComponent<DragDrop>();
        draggableItem.parentAfterDrag = transform;
        if (draggableItem.typeItem == TypeItem.Compuesto)
        {
            
        }

    }
    
}


