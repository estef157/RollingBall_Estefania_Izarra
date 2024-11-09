using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUoBoost : MonoBehaviour
    
{
    [SerializeField] AudioClip sonidoBoost;
    [SerializeField] AudioManager manager;
    [SerializeField]int velocidadRotBoost;
    [SerializeField]Vector3 direccionRotBoost = new Vector3(0, 0, 0);
    public int multiplicador = 1;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            manager.ReproducirSonido(sonidoBoost);
            Protagonista.fuerzaMov *= multiplicador;
            Destroy(gameObject);
        }
    }

    void Update()
    {
        transform.Rotate(direccionRotBoost * velocidadRotBoost * Time.deltaTime);

    }
}
