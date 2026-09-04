using UnityEngine;

public class PlayerTwo : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Animator anim;
    public Rigidbody2D rb;

    private Vector2 movement;

    void Start()
    {
        GameManager.Gameover = false;

        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (!GameManager.Gameover)
        {
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");

            movement.Normalize();

            if (movement.x < 0)
            {
                transform.localScale = new Vector3(1, 1, 1);
            }
            else if (movement.x > 0)
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }
        }

        else
        {
            movement = Vector2.zero;
        }

        if (movement.x < 0 || movement.y < 0 || movement.x > 0 || movement.y > 0) {
            anim.SetBool("andando", true);

        }

        else
        {
            anim.SetBool("andando", false);
        }

    }
    void FixedUpdate()
    {
        rb.linearVelocity = movement * moveSpeed;
    }
}