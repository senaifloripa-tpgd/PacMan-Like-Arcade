using UnityEngine;

public class PlayerTwo : MonoBehaviour
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
        if(!GameManager.Gameover){

            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");

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
}