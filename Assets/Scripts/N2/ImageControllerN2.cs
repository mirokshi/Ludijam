using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ImageControllerN2 : MonoBehaviour
{
    public List<GameObject> images;
    [SerializeField] private GameObject auxSlot;
    public static Action<int> OnAchievement;
    private bool boolPista = true;
    private void OnEnable()
    {
        SlotN2.OnActiveImage += ActiveImage;
    }

    private void OnDisable()
    {
        SlotN2.OnActiveImage -= ActiveImage;
    }

    public void ActiveImage(SetItemN2 item)
    {
        SetItemN2[] itemsInSlot = auxSlot.GetComponentsInChildren<SetItemN2>();
        SetItemN2 personaje = null, objeto = null, accion = null, lugar = null;
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

        if (personaje != null)
        {
            if (personaje.itemScriptableObject.text.ToUpper() == "AVI")
            {
                if (accion != null && accion.itemScriptableObject.text.ToUpper() == "CRIDAVA MOLT")
                {
                    images[14].SetActive(true);
                }
                else if (accion != null && accion.itemScriptableObject.text.ToUpper() == "DONAVA PATADES")
                {
                    images[12].SetActive(true);
                }
                else if (accion != null && accion.itemScriptableObject.text.ToUpper() == "ES TIRAVA PETS")
                {
                    images[13].SetActive(true);
                }
                else
                {
                    images[11].SetActive(true);
                }
            }
            else if (personaje.itemScriptableObject.text.ToUpper() == "GOS")
            {
                if (accion != null && accion.itemScriptableObject.text.ToUpper() == "CRIDAVA MOLT")
                {
                    images[6].SetActive(true);
                }
                else if (accion != null && accion.itemScriptableObject.text.ToUpper() == "DONAVA PATADES")
                {
                    images[5].SetActive(true);
                }
                else if (accion != null && accion.itemScriptableObject.text.ToUpper() == "ES TIRAVA PETS")
                {
                    images[4].SetActive(true);
                }
                else
                {
                    images[3].SetActive(true);
                }
            }
            else if (personaje.itemScriptableObject.text.ToUpper() == "NEN")
            {
                if (accion != null && accion.itemScriptableObject.text.ToUpper() == "CRIDAVA MOLT")
                {
                    images[8].SetActive(true);
                }
                else if (accion != null && accion.itemScriptableObject.text.ToUpper() == "DONAVA PATADES")
                {
                    images[9].SetActive(true);
                }
                else if (accion != null && accion.itemScriptableObject.text.ToUpper() == "ES TIRAVA PETS")
                {
                    images[10].SetActive(true);
                }
                else
                {
                    images[7].SetActive(true);
                }
            }
        }

        else if (accion != null)
        {
            if (accion.itemScriptableObject.text.ToUpper() == "CRIDAVA MOLT")
            {
                images[18].SetActive(true);
            }
            else if (accion.itemScriptableObject.text.ToUpper() == "DONAVA PATADES")
            {
                images[19].SetActive(true);
            }
            else if (accion.itemScriptableObject.text.ToUpper() == "ES TIRAVA PETS")
            {
                images[20].SetActive(true);
            }
        }

        if (lugar != null)
        {
            if (lugar.itemScriptableObject.text.ToUpper() == "VOLAR EN 1ERA")
            {
                images[0].SetActive(true);
            }
            else if (lugar.itemScriptableObject.text.ToUpper() == "VOLAR EN TURISTA")
            {
                images[1].SetActive(true);
            }
            else if (lugar.itemScriptableObject.text.ToUpper() == "VOLAR EN ÚLTIMA FILA")
            {
                images[2].SetActive(true);
            }
        }
        
        if (objeto != null)
        {
            if (objeto.itemScriptableObject.text.ToUpper() == "BOLIGRAFS")
            {
                images[15].SetActive(true);
            }
            else if (objeto.itemScriptableObject.text.ToUpper() == "EUROS")
            {
                images[16].SetActive(true);
            }
            else if (objeto.itemScriptableObject.text.ToUpper() == "TICKETS")
            {
                images[17].SetActive(true);
            }
        }
        

        if (personaje != null && objeto!=null && accion!=null && lugar!=null)
        {
            if (personaje.itemScriptableObject.text.ToUpper() == "GOS" 
                && objeto.itemScriptableObject.text.ToUpper() == "EUROS"
                && accion.itemScriptableObject.text.ToUpper() == "ES TIRAVA PETS" 
                && lugar.itemScriptableObject.text.ToUpper() == "VOLAR EN 1ERA") 
            {
                if (boolPista)
                {
                    OnAchievement?.Invoke(1);    
                }
                else
                {
                    OnAchievement?.Invoke(4);
                }
            }
            else if (personaje.itemScriptableObject.text.ToUpper() == "AVI" 
                                 && objeto.itemScriptableObject.text.ToUpper() == "BOLIGRAFS"
                                 && accion.itemScriptableObject.text.ToUpper() == "DONAVA PATADES" 
                                 && lugar.itemScriptableObject.text.ToUpper() == "VOLAR EN 1ERA") 
            {
                OnAchievement?.Invoke(2);
            } 
            else if (personaje.itemScriptableObject.text.ToUpper() == "NEN" 
                     && objeto.itemScriptableObject.text.ToUpper() == "EUROS"
                     && accion.itemScriptableObject.text.ToUpper() == "ES TIRAVA PETS" 
                     && lugar.itemScriptableObject.text.ToUpper() == "VOLAR EN ÚLTIMA FILA") 
            {
                OnAchievement?.Invoke(3);
            }   
        }
        
    }
    
    public void pista()
    {
        boolPista = false;
    }
}