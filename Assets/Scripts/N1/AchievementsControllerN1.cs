using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AchievementsControllerN1 : MonoBehaviour
{
    [SerializeField] private GameObject buttonLink;
    [SerializeField] private GameObject[] logros;
    [SerializeField] private GameObject garabatos;

    private void OnEnable()
    {
        ImageControllerN1.OnAchievement += SetAchievement;
    }

    private void OnDisable()
    {
        ImageControllerN1.OnAchievement += SetAchievement;
    }

    public void SetAchievement(int tipo)
    {
        if (tipo == 1)
        {
            logros[0].SetActive(true);
            buttonLink.SetActive(true);
            EliminarTachon();
        }
        else if (tipo == 2)
        {
            logros[1].SetActive(true);
        }
        else if (tipo == 3)
        {
            logros[2].SetActive(true);
        }
        else
        { 
            logros[3].SetActive(true);
            buttonLink.SetActive(true);
            EliminarTachon();
        }
    }
    
    private void EliminarTachon()
    {
        garabatos.SetActive(false);
    }
}