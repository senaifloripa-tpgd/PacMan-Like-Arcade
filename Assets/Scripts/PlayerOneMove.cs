using UnityEngine;

public class PlayerOneMove : MonoBehaviour
{
    // Variables to horizontal and vertical input
    private float horizontalInput;
    private float verticalInput;

    // Variable to player speed
    private float moveSpeed = 3f;

    // Variable to player physics component (Rigidbody2D)
    private Rigidbody2D playerPhysics;

    void Start()
    {        

        // Component reference
        playerPhysics = GetComponent<Rigidbody2D>();

    }

    void Update()
    {

        // Axis inputs to variables
        horizontalInput = Input.GetAxis("HorizontalP1");
        verticalInput = Input.GetAxis("VerticalP1");

        // Calculate inputs x speed in new vector2 and use it to set linear velocity of player physics 
        playerPhysics.linearVelocity = new Vector2(horizontalInput * moveSpeed, verticalInput * moveSpeed);

    }
    
    void OnCollisionEnter2D(Collision2D col){

        // Check if the object that collided has the tag "ghost" 
        if(col.gameObject.CompareTag("Ghost")){

            // Destroy player object
            Destroy(gameObject);

        }

    }

}