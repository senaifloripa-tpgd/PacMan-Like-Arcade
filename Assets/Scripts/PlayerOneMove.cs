using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerOneMove : MonoBehaviour
{
    // Variables to horizontal and vertical input
     public InputAction controlesJogador;
     Vector2 direcaoMovimento;
    // Variable to player speed
     
     public float velocidadeJogador = 5f;

    // Variable to player physics component (Rigidbody2D)
     public Rigidbody2D fisicaJogador;

    private void OnEnable()
    {
        controlesJogador.Enable();

    }

    private void OnDisable()
    {

         controlesJogador.Disable();

    }

    void Start()
    {        

      

    }

    void Update()
    {

          direcaoMovimento = controlesJogador.ReadValue<Vector2>();
          fisicaJogador.linearVelocity = new Vector2(direcaoMovimento.x * velocidadeJogador, direcaoMovimento.y * velocidadeJogador);


    }
    
    void OnCollisionEnter2D(Collision2D col){

        // Check if the object that collided has the tag "ghost" 
        if(col.gameObject.CompareTag("Ghost")){

            // Destroy player object
            Destroy(gameObject);

        }

    }

}