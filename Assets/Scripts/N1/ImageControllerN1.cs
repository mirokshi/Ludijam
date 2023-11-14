using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ImageControllerN1 : MonoBehaviour
{
    public List<GameObject> images;
    [SerializeField] private GameObject auxSlot;
    public static Action<int> OnAchievement;
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

        if (personaje != null)
        {
            if (personaje.itemScriptableObject.text.ToUpper() == "LLADRE")
            {
                if (objeto != null && objeto.itemScriptableObject.text.ToUpper() == "ALIEN")
                {
                    images[3].SetActive(true);
                }
                else if (objeto != null && objeto.itemScriptableObject.text.ToUpper() == "MANIQUI")
                {
                    images[1].SetActive(true);
                }
                else if (objeto != null && objeto.itemScriptableObject.text.ToUpper() == "POLICIA")
                {
                    images[2].SetActive(true);
                }
                else
                {
                    images[0].SetActive(true);
                }
            }
            else if (personaje.itemScriptableObject.text.ToUpper() == "GOS")
            {
                if (objeto != null && objeto.itemScriptableObject.text.ToUpper() == "ALIEN")
                {
                    images[5].SetActive(true);
                }
                else if (objeto != null && objeto.itemScriptableObject.text.ToUpper() == "MANIQUI")
                {
                    images[6].SetActive(true);
                }
                else if (objeto != null && objeto.itemScriptableObject.text.ToUpper() == "POLICIA")
                {
                    images[7].SetActive(true);
                }
                else
                {
                    images[4].SetActive(true);
                }
            }
            else if (personaje.itemScriptableObject.text.ToUpper() == "NEN")
            {
                if (objeto != null && objeto.itemScriptableObject.text.ToUpper() == "ALIEN")
                {
                    images[9].SetActive(true);
                }
                else if (objeto != null && objeto.itemScriptableObject.text.ToUpper() == "MANIQUI")
                {
                    images[10].SetActive(true);
                }
                else if (objeto != null && objeto.itemScriptableObject.text.ToUpper() == "POLICIA")
                {
                    images[11].SetActive(true);
                }
                else
                {
                    images[8].SetActive(true);
                }
            }
        }

        else if (objeto != null)
        {
            if (objeto.itemScriptableObject.text.ToUpper() == "ALIEN")
            {
                images[21].SetActive(true);
            }
            else if (objeto.itemScriptableObject.text.ToUpper() == "MANIQUI")
            {
                images[22].SetActive(true);
            }
            else if (objeto.itemScriptableObject.text.ToUpper() == "POLICIA")
            {
                images[23].SetActive(true);
            }
        }


        if (lugar != null)
        {
            if (lugar.itemScriptableObject.text.ToUpper() == "BOTIGUES")
            {
                if (accion != null && accion.itemScriptableObject.text.ToUpper() == "ROBAR")
                {
                    images[13].SetActive(true);
                }
                else if (accion != null && accion.itemScriptableObject.text.ToUpper() == "PINTAR")
                {
                    images[14].SetActive(true);
                }
                else
                {
                    images[12].SetActive(true);
                }
            }
            else if (lugar.itemScriptableObject.text.ToUpper() == "FARMACIES")
            {
                if (accion != null && accion.itemScriptableObject.text.ToUpper() == "ROBAR")
                {
                    images[16].SetActive(true);
                }
                else if (accion != null && accion.itemScriptableObject.text.ToUpper() == "PINTAR")
                {
                    images[17].SetActive(true);
                }
                else
                {
                    images[15].SetActive(true);
                }
            }
            else if (lugar.itemScriptableObject.text.ToUpper() == "PISOS")
            {
                if (accion != null && accion.itemScriptableObject.text.ToUpper() == "ROBAR")
                {
                    images[19].SetActive(true);
                }
                else if (accion != null && accion.itemScriptableObject.text.ToUpper() == "PINTAR")
                {
                    images[20].SetActive(true);
                }
                else
                {
                    images[18].SetActive(true);
                }
            }
        }
        else if (accion != null)
        {
            if (accion.itemScriptableObject.text.ToUpper() == "ROBAR")
            {
                images[25].SetActive(true);
            }

            if (accion.itemScriptableObject.text.ToUpper() == "PINTAR")
            {
                images[24].SetActive(true);
            }
        }

        if (personaje != null && objeto!=null && accion!=null && lugar!=null)
        {
            if (personaje.itemScriptableObject.text.ToUpper() == "LLADRE" 
                && objeto.itemScriptableObject.text.ToUpper() == "MANIQUI"
                && accion.itemScriptableObject.text.ToUpper() == "ROBAR" 
                && lugar.itemScriptableObject.text.ToUpper() == "BOTIGUES") {
                OnAchievement?.Invoke(1);
                
            }
            else if (personaje.itemScriptableObject.text.ToUpper() == "GOS" 
                         && objeto.itemScriptableObject.text.ToUpper() == "POLICIA"
                         && accion.itemScriptableObject.text.ToUpper() == "ROBAR" 
                         && lugar.itemScriptableObject.text.ToUpper() == "FARMACIES")
            {
                OnAchievement?.Invoke(2);
            }
            else if (personaje.itemScriptableObject.text.ToUpper() == "NEN"
                      && objeto.itemScriptableObject.text.ToUpper() == "ALIEN"
                      && accion.itemScriptableObject.text.ToUpper() == "PINTAR"
                      && lugar.itemScriptableObject.text.ToUpper() == "BOTIGUES")
            {
                OnAchievement?.Invoke(3);
            }
        }
        
    }
}