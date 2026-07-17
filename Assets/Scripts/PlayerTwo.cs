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
    {}
    }
    void FixedUpdate()
    {
        rb.linearVelocity = movement * moveSpeed;
    }
}