using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuroCubitos : MonoBehaviour
{
    private float timer = 0f;
    private bool iniciarCuenta = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(iniciarCuenta)
        {
            timer += 1 * Time.unscaledDeltaTime;
            if(timer>=2)
            {
                Time.timeScale = 1f;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0.2f;
            iniciarCuenta=true;
        }
    }
}
