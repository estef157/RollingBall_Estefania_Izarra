using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{
    [SerializeField] int velocidadPlat = 0;
    [SerializeField]Vector3 direccionPlat = new Vector3(0, 0, 4);
    Vector3 rotacionPlat = new Vector3(10, 0, 0);
    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direccionPlat.normalized * velocidadPlat * Time.deltaTime);

        if (timer >= 3)
        {
            transform.Rotate(rotacionPlat * Time.deltaTime);
        }
       

       
    }
}
