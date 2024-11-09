using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUoBoost : MonoBehaviour
    
{
    [SerializeField] AudioClip sonidoBoost;
    [SerializeField] AudioManager manager;
    [SerializeField] Vector3 vectorMov;
    [SerializeField] float velocidadmov;
    public int multiplicador = 1;
    float timer = 0;
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
        timer += Time.deltaTime;
        transform.Translate(vectorMov * velocidadmov * Time.deltaTime, Space.World);
        if (timer >= 1f)
        {
            vectorMov = vectorMov * -1;
            timer = 0;

        }

    }
}
