using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiaCamaras : MonoBehaviour
{
    [SerializeField] private GameObject cam1;
    [SerializeField] private GameObject cam2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            cam1.SetActive(false);
            cam2.SetActive(true);
        }
        else
        {
           cam1.SetActive (true);
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
