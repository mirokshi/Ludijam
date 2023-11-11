using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class SlotN2 : MonoBehaviour,IDropHandler
{
    [SerializeField] private TypeItem typeItem;
    public static Action<int,string> OnItemDropped;
    public void OnDrop(PointerEventData eventData)
    {
        
        GameObject dropped = eventData.pointerDrag;
        DragDropN2 draggableItem = dropped.GetComponent<DragDropN2>();
        SetItemN2 item = dropped.GetComponent<SetItemN2>();

        if (typeItem== item.typeItem || typeItem == TypeItem.Compuesto)
        {
            draggableItem.parentAfterDrag = transform;    
        }
        
        if (typeItem==TypeItem.Compuesto)
        {
            OnItemDropped?.Invoke(item.position,item.text);

            SetItemN2[] items = GetComponentsInChildren<SetItemN2>();
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


