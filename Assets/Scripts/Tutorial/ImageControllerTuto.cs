using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ImageControllerTuto : MonoBehaviour
{
    public List<GameObject> images;
    [SerializeField] private GameObject auxSlot;
    public static Action<int> OnAchievement;
    private void OnEnable()
    {
        SlotTuto.OnActiveImage += ActiveImage;
    }

    private void OnDisable()
    {
        SlotTuto.OnActiveImage -= ActiveImage;
    }

    public void ActiveImage(SetItemTuto item)
    {
        SetItemTuto[] itemsInSlot = auxSlot.GetComponentsInChildren<SetItemTuto>();
        SetItemTuto personaje = null, objeto = null, accion = null, lugar = null;
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
            }
        }

        foreach (var image in images)
        {
            image.SetActive(false);
        }

        if (personaje!=null)
        {
            if (personaje.itemScriptableObject.text.ToUpper()=="HAS")
            {
                images[2].SetActive(true);
            }else if (personaje.itemScriptableObject.text.ToUpper() == "NO HAS")
            {
                images[1].SetActive(true);
            }
        }

        if (objeto!=null)
        {
            images[0].SetActive(true);
        }

        if (personaje!=null && objeto!=null)
        {
            if (personaje.itemScriptableObject.text.ToUpper()=="HAS")
            {
                OnAchievement?.Invoke(1);
            }
        }
    }
}