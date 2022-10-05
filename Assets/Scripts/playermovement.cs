using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;


public class playermovement : MonoBehaviour
{

    //VIDEO
    public PlayableDirector director;
    private Rigidbody2D rb;
    private void Awake() {
        rb = GetComponent<Rigidbody2D>();       

    }

    private void FixedUpdate() {
        rb.velocity = new Vector2 (horizontal, 0f) * speed ;
    }

    //Movimiento del personaje
    public float speed = 5.5f; 

    //Almacenamiento de imputs, movimiento horizontal
    private float horizontal;

    //Variable para acceder al transform
    private Transform playerTransform;

    //Se ejecuta en el primer frame
    void Start()
    {
        playerTransform = GetComponent<Transform>();
    }

    //Se ejecuta una vez por frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");        

        //Acceder a la posicion del transform (se puede escribir de varias maneras)
        //playerTransform.position += new Vector3 (horizontal * speed * Time.deltaTime, 0, 0);
        //playerTransform.position += new Vector3 (1, 0, 0) * horizontal * speed * Time.deltaTime;
        //playerTransform.Translate(Vector3.right * horizontal * speed * Time.deltaTime, Space.World);
       
    }

    //Activar la cinematica
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Cinematica")  
        {
            director.Play();
        }
    }   
}
