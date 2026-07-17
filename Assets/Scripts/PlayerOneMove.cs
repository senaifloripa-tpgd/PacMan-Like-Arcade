using UnityEngine;
using System.Collections;

public class PlayerOneMove : MonoBehaviour
{
    public float moveSpeed = 5f;



    public Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        GameManager.Gameover = false;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

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