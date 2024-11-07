using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUoBoost : MonoBehaviour
{
    public int multiplicador = 1;
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            Protagonista.fuerzaMov *= multiplicador;
            Destroy(gameObject);
        }
    }


}
