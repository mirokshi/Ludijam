using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AchievementsControllerN1 : MonoBehaviour
{
    private TextMeshProUGUI _text;
    private void Start()
    {
        _text = GetComponent<TextMeshProUGUI>();
    }

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
        if (tipo==0)
        {
            _text.text = "NOTICIA REAL";    
        }else if (tipo==1)
        {
            _text.text = "";
        }
        
    }
}
