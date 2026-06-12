using UnityEngine;
// using UnityEngine.InputSystem;
using System.Collections;

public class PlayerOneMove : MonoBehaviour
{
    // // Variables to horizontal and vertical input
    //  public InputAction controlesJogador;
    //  Vector2 direcaoMovimento;
    // // Variable to player speed
     
    //  public float velocidadeJogador = 5f;

    // // Variable to player physics component (Rigidbody2D)
    //  public Rigidbody2D fisicaJogador;

    // // private void OnEnable()
    // // {
    // //     controlesJogador.Enable();

    // // }

    // // private void OnDisable()
    // {

    //      controlesJogador.Disable();

    // }
     public float moveSpeed = 5f;

    public Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal1");
        movement.y = Input.GetAxisRaw("Vertical1");

        movement.Normalize(); // evita movimento mais rápido na diagonal
    }

    void FixedUpdate()
    {
        rb.linearVelocity = movement * moveSpeed;
    }

     void OnTriggerEnter2D(Collider2D col){

        if(col.gameObject.CompareTag("Ghost")){

            Destroy(gameObject);

        }

    }

}