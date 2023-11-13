using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AchievementsControllerN2 : MonoBehaviour
{
    private TextMeshProUGUI _text;
    [SerializeField] private GameObject buttonLink;
    private void Start()
    {
        _text = GetComponent<TextMeshProUGUI>();
    }

    private void OnEnable()
    {
        ImageControllerN2.OnAchievement += SetAchievement;
    }

    private void OnDisable()
    {
        ImageControllerN2.OnAchievement += SetAchievement;
    }

    public void SetAchievement(int tipo)
    {
        if (tipo==0)
        {
            _text.text = "NOTICIA REAL";
            buttonLink.SetActive(true);
        }else if (tipo==1)
        {
            _text.text = "";
        }
        
    }
}