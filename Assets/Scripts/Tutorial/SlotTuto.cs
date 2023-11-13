using System;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class SlotTuto : MonoBehaviour,IDropHandler
{
    [SerializeField] private TypeItem typeItem;
    [SerializeField] private GameObject auxSlot;
    public static Action<int,string> OnItemDropped;
    public static Action<SetItemTuto> OnActiveImage;
    public void OnDrop(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag;
        DragDropTuto draggableItem = dropped.GetComponent<DragDropTuto>();
        SetItemTuto item = dropped.GetComponent<SetItemTuto>();
        
        //Mirar en el auxiliar 
        SetItemTuto[] items = auxSlot.GetComponentsInChildren<SetItemTuto>();
        
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

            StartCoroutine(mierda(item));
            
        }
       
        
    }
    
    private IEnumerator mierda(SetItemTuto item)
    {
        yield return new WaitForSeconds(.1f);
        OnActiveImage?.Invoke(item);
    }
}


