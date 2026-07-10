using UnityEngine;
// using UnityEngine.InputSystem;
using System.Collections;

public class PlayerOneMove : MonoBehaviour
{
    public float moveSpeed = 5f;
    public int Vida = 1;

    public Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        GameManager.Gameover = false;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(!GameManager.Gameover){

            movement.x = Input.GetAxisRaw("Horizontal1");
            movement.y = Input.GetAxisRaw("Vertical1");

            movement.Normalize(); // evita movimento mais rápido na diagonal
        }
        else{
            moveSpeed = 0;
        }
    }

    void FixedUpdate()
    {
        rb.linearVelocity = movement * moveSpeed;
    }

    void OnCollisionEnter2D(Collision2D col){

        if(col.gameObject.CompareTag("Ghost")){
            
            Vida -= 1;
            
                if(Vida <= 0){

                    gameObject.SetActive(false);
                    
                }
        }
    }
}