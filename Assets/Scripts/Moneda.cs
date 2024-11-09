using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Moneda : MonoBehaviour
{

    [SerializeField] int velocidadRot;
    private int puntuacion;
    [SerializeField] TMP_Text textoPuntuacion;
    [SerializeField] Vector3 direccionRot;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate( direccionRot * velocidadRot * Time.deltaTime);
        
    }
    private void OnTriggerEnter(Collider other)
    {
        puntuacion += 1;
        textoPuntuacion.SetText("x" + puntuacion);
    }
}
