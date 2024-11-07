using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUoBoost : MonoBehaviour
    
{
    int velocidadRotBoost = 5;
    Vector3 direccionRotBoost = new Vector3(3, 0, 0);
    public int multiplicador = 1;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Protagonista.fuerzaMov *= multiplicador;
            Destroy(gameObject);
        }
    }

    void Update()
    {
        transform.Rotate(direccionRotBoost * velocidadRotBoost * Time.deltaTime);

    }
}
