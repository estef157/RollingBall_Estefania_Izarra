using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{
    [SerializeField] int velocidad;
    [SerializeField] Vector3 direccionPlat;
    Vector3 rotacionPlat = new Vector3(10, 0, 0);
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direccionPlat.normalized * velocidad * Time.deltaTime);
        timer += Time.deltaTime;
        if (timer >= 3)
        {
            direccionPlat *= -1;
            timer = 0;
        }
       

       
    }
}
