using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class MuroCubitos : MonoBehaviour
{
    private float timer = 0f;
    [SerializeField] Rigidbody[] rigidbodies;
    [SerializeField] private float tiempito;
    private bool iniciarCuenta = false;

    

    // Update is called once per frame
    void Update()
    {
        if(iniciarCuenta)
        {
            timer += 1 * Time.unscaledDeltaTime;
            if(timer>=2)
            {
                Time.timeScale = 1f;
                for (int i = 0; i < rigidbodies.Length; i++)
                {
                    rigidbodies[i].useGravity = true;
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Time.timeScale = tiempito;
            iniciarCuenta=true;
        }
    }

}
