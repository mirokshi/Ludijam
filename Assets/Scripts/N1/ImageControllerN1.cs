using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageControllerN1 : MonoBehaviour
{
    public List<GameObject> images;
    [SerializeField] private GameObject auxSlot;

    private void OnEnable()
    {
        SlotN1.OnActiveImage += ActiveImage;
    }

    private void OnDisable()
    {
        SlotN1.OnActiveImage -= ActiveImage;
    }

    public void ActiveImage(SetItemN1 item)
    {
        SetItemN1[] itemsInSlot = auxSlot.GetComponentsInChildren<SetItemN1>();
        SetItemN1 personaje = null, objeto = null, accion = null, lugar = null;
        foreach (var itemInSlot in itemsInSlot)
        {
            switch (itemInSlot.typeItem)
            {
                case TypeItem.Personaje:
                    personaje = itemInSlot;
                    break;
                case TypeItem.Objeto:
                    objeto = itemInSlot;
                    break;
                case TypeItem.Accion:
                    accion = itemInSlot;
                    break;
                case TypeItem.Lugar:
                    lugar = itemInSlot;
                    break;
            }
        }

        foreach (var image in images)
        {
            image.SetActive(false);
        }

        if (personaje.itemScriptableObject.text.ToUpper()=="LLADRE")
        {
            images[0].SetActive(true);
        }else if (personaje.itemScriptableObject.text.ToUpper()=="GOS")
        {
            images[4].SetActive(true);
        }else if (personaje.itemScriptableObject.text.ToUpper() == "NEN")
        {
            images[8].SetActive(true);  
        }
    }

}