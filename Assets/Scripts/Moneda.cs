using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class Moneda : MonoBehaviour
{
    [SerializeField] Vector3 vectorMov;
    [SerializeField] float velocidadmov;
    float timer = 0;
    [SerializeField] int velocidadRot;
    //private int puntuacion;
    //[SerializeField] TMP_Text textoPuntos;
    [SerializeField] Vector3 direccionRot;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        transform.Rotate( direccionRot * velocidadRot * Time.deltaTime);
        transform.Translate(vectorMov * velocidadmov * Time.deltaTime, Space.World);
        if (timer >= 1f)
        {
            vectorMov = vectorMov * -1;
            timer = 0;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        //puntuacion += 1;
      //  textoPuntos.SetText("x" + puntuacion);
    }
}
