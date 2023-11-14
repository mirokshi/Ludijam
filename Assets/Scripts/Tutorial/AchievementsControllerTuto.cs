using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AchievementsControllerTuto : MonoBehaviour
{
    [SerializeField] private GameObject buttonLink;
    [SerializeField] private GameObject[] logros;
    [SerializeField] private GameObject garabatos;

    private void OnEnable()
    {
        ImageControllerTuto.OnAchievement += SetAchievement;
    }

    private void OnDisable()
    {
        ImageControllerTuto.OnAchievement += SetAchievement;
    }

    public void SetAchievement(int tipo)
    {
        if (tipo == 1)
        {
            logros[0].SetActive(true);
            buttonLink.SetActive(true);
            EliminarTachon();
        }
    }

    private void EliminarTachon()
    {
        garabatos.SetActive(false);
    }
}