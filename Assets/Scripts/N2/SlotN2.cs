using System;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class SlotN2 : MonoBehaviour,IDropHandler
{
    [SerializeField] private TypeItem typeItem;
    [SerializeField] private GameObject auxSlot;
    public static Action<int,string> OnItemDropped;
    public static Action<SetItemN2> OnActiveImage;
    public void OnDrop(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag;
        DragDropN2 draggableItem = dropped.GetComponent<DragDropN2>();
        SetItemN2 item = dropped.GetComponent<SetItemN2>();
        
        //Mirar en el auxiliar 
        SetItemN2[] items = auxSlot.GetComponentsInChildren<SetItemN2>();
        
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
    
    private IEnumerator mierda(SetItemN2 item)
    {
        yield return new WaitForSeconds(.1f);
        OnActiveImage?.Invoke(item);
    }
}