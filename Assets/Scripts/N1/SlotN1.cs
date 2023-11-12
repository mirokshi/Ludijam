using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SlotN1 : MonoBehaviour,IDropHandler
{
    [SerializeField] private TypeItem typeItem;
    [SerializeField] private GameObject auxSlot;
    public static Action<int,string> OnItemDropped;
    public void OnDrop(PointerEventData eventData)
    {
        
        GameObject dropped = eventData.pointerDrag;
        DragDropN1 draggableItem = dropped.GetComponent<DragDropN1>();
        SetItemN1 item = dropped.GetComponent<SetItemN1>();
        
        //Mirar en el auxiliar 
        SetItemN1[] items = auxSlot.GetComponentsInChildren<SetItemN1>();
        
        if (typeItem== item.typeItem || typeItem == TypeItem.Compuesto)
        {
            draggableItem.parentAfterDrag = auxSlot.transform;    
        }
        
        if (typeItem==TypeItem.Compuesto)
        {
            OnItemDropped?.Invoke(item.position,item.text);

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


