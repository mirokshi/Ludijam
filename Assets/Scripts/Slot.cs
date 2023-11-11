using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour,IDropHandler
{
    [SerializeField] private TypeItem typeItem;
    public static Action<int,string> OnItemDropped;
    public void OnDrop(PointerEventData eventData)
    {
        
        GameObject dropped = eventData.pointerDrag;
        DragDrop draggableItem = dropped.GetComponent<DragDrop>();
        SetItem item = dropped.GetComponent<SetItem>();

        if (typeItem== item.typeItem || typeItem == TypeItem.Compuesto)
        {
            draggableItem.parentAfterDrag = transform;    
        }
        
        if (typeItem==TypeItem.Compuesto)
        {
            OnItemDropped?.Invoke(item.position,item.text);

            SetItem[] items = GetComponentsInChildren<SetItem>();
            foreach (var i in items)
            {
                if (i.typeItem == item.typeItem)
                {
                    i.transform.SetParent(draggableItem.originParent);
                }
            }
        }
        
        
        

    }

    
}


