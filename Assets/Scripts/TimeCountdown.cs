using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;



public class TimeCountdown : MonoBehaviour
{
    
    [SerializeField] int minutos;
    [SerializeField] int segundos;
    [SerializeField] TextMeshProUGUI tiempo;

    float restante;
    bool play;


    private void Awake()
    {
        restante = (minutos * 60) + segundos;
        play = true;   

    }
  

    // Update is called once per frame
    void Update()
    {
        if (play)
        { 
            restante -= Time.deltaTime; 
            if (restante < 1)
            {
                play = true;
                Protagonista.Time0ut = true;
            }
            int tempMinutos = Mathf.FloorToInt(restante / 60);  
            int tempSegundos = Mathf.FloorToInt(restante % 60);
            tiempo.text = string.Format("{00:00}:{01:00}", tempMinutos, tempSegundos);

        }
       
    }
}
