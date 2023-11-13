using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AchievementsControllerTuto : MonoBehaviour
{
    private TextMeshProUGUI _text;
    [SerializeField] private GameObject buttonLink;
    private void Start()
    {
        _text = GetComponent<TextMeshProUGUI>();
    }

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
