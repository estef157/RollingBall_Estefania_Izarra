using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Protagonista : MonoBehaviour
{
    
    public static bool Time0ut = false;
    [SerializeField] AudioClip sonidoMoneda;
    [SerializeField] Vector3 spawn;
    [SerializeField] AudioManager manager;
    static public int fuerzaMov = 2;
    [SerializeField] int fuerzaSalto;
    [SerializeField] float distanciaDeteccionSuelo;
    [SerializeField] LayerMask queEsSuelo;
    private int puntuacion;
    [SerializeField] TMP_Text textoPuntos;
    Rigidbody rb;
    private float v, h;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

   
    void Update()
    {

        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");
        Vector3 direccion  = new Vector3 (h,0,v).normalized;
        Saltar();

        if( Time0ut )
        {
            Time0ut = false;
            SceneManager.LoadScene(2);
        }
    }

    private void FixedUpdate()
    {
        rb.AddForce(new Vector3 (h, 0, v).normalized * fuerzaMov, ForceMode.Force);
        //rb.AddForce(new Vector3(h, 0, v).normalized * fuerzaMov, ForceMode.Impulse);
        //rb.velocity += new Vector3(0, -10f, 0);
    }
    private void Saltar()
    {
        Vector3 salto = new Vector3(0, v, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
           if (DetectarSuelo() == true)
           {
                Debug.Log("dsfdsfdsfds");
               rb.AddForce(Vector3.up.normalized * fuerzaSalto, ForceMode.Impulse);
           }

        }
        
    }
       
            

    
    bool DetectarSuelo()
    {
       bool resultado = Physics.Raycast(transform.position, new Vector3(0, -1, 0), distanciaDeteccionSuelo, queEsSuelo);
        return resultado;
    }

    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.CompareTag("Coleccionable"))
        {
            puntuacion += 1;
            textoPuntos.SetText("x" + puntuacion);
            manager.ReproducirSonido(sonidoMoneda);
            Destroy(other.gameObject);
        }


        if(other.gameObject.CompareTag("Respawn"))
        {
            fuerzaMov = 2;
            //SceneManager.LoadScene(1);
            //rb.constraints = RigidbodyConstraints.FreezeAll;
            //Destroy(gameObject);
            rb =gameObject.GetComponent<Rigidbody>();
            if(rb != null )
            {
            //Detener por el momento la bola
            rb.velocity = Vector3.zero;
            //Posicion inicial
            rb.MovePosition(spawn);
            rb.useGravity = true; //reactivar
            }

        }
    }
}
