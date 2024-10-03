using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Protagonista : MonoBehaviour
{
  //  Vector3 direccion = new Vector3(0, 0, 0);
      Vector3 salto = new Vector3(0, 5, 0);
    [SerializeField] int fuerza = 0;
     Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(salto * fuerza, ForceMode.Impulse);
        }
       







       // float h = Input.GetAxisRaw("Horizontal");
      //  float v = Input.GetAxisRaw("Vertical");

       // transform.Translate(new Vector3 (h, v));
            



    }
}
