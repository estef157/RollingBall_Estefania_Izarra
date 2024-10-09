using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rodillo : MonoBehaviour
{
    [SerializeField] Vector3 direccionR;    
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddTorque(direccionR * 50000, ForceMode.VelocityChange); //pide un vector 3
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
