using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatGiratoria : MonoBehaviour
{
    [SerializeField] Vector3 orientacion;
    [SerializeField] int boost = 1;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddTorque(orientacion * boost, ForceMode.VelocityChange);

    }
}
