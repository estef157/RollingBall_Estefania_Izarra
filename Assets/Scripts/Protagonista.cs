using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Protagonista : MonoBehaviour
{
  
      
    [SerializeField] int fuerzaMov = 0;
    [SerializeField] int fuerzaSalto = 0;
     Rigidbody rb;
    private float v, h;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");
        Vector3 direccion  = new Vector3 (h,v,0).normalized;
    }

    private void FixedUpdate()
    {
        rb.AddForce(new Vector3 (h, 0, v).normalized * fuerzaMov, ForceMode.Force);
        rb.velocity += new Vector3(0, -9.81f, 0);
    }
    private void Saltar()
    {
        Vector3 salto = new Vector3(0, v, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(salto * fuerzaSalto, ForceMode.Impulse);
        }
    }

}
