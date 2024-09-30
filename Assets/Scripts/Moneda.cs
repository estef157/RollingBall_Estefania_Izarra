using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{
    
    [SerializeField] int velocidadRot = 1;
    Vector3 direccionRot = new Vector3(0, 0, 3);
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate( direccionRot * velocidadRot * Time.deltaTime);
        
    }
}
