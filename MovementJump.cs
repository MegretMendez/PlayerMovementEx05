using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementJump : MonoBehaviour
{
    public float rotationSpeed;       // Public variable for character rotation speed
    public float speed;               // Public variable for character movement speed
    public float jumpForce;           // Public variable for jump force
    private int jumpCount = 0;        // Tracks the number of jumps made
    public int maxJumpCount = 3;      // Maximum allowed jump count
    private Rigidbody rb;             // Reference to the character's rigidbody
    private Vector3 startingPosition; // Initial character position
    private bool isJumping = false;   // Tracks if the character is in a jump
    private bool isGrounded = true;   // Initially set to true (character is grounded)

    void Start()
    {
        rb = GetComponent<Rigidbody>();        // Get the character's rigidbody
        startingPosition = transform.position; // Store the initial character position
    }

    void Update()
    {
        // Check for movement input (W, S, A, D or arrow keys) and move the character
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        { transform.Translate(0,0,speed * Time.deltaTime); }
        
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        { transform.Translate(0,0,-speed * Time.deltaTime); }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        { transform.Translate(speed * Time.deltaTime,0,0); }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        { transform.Translate(-speed * Time.deltaTime,0,0); }

        if (Input.GetKeyDown(KeyCode.Space))
        {
        
            // Check if the character can jump, and call the Jump function
            if (isGrounded && jumpCount < maxJumpCount)
            {
                OnDoubleJump();
            }
        }

        ApplyGravity(); // Apply gravity to the character

        // Handle character rotation based on mouse input
        float mouseX = Input.GetAxis("Mouse X");
        transform.Rotate(0, -rotationSpeed * mouseX, 0);

    }
    
    // Double jump logic when the space bar is pressed
    void OnDoubleJump()
    {
        if (jumpCount < maxJumpCount){
        
        // Reset vertical velocity and apply an upward force for jumping
            rb.velocity = new Vector3(rb.velocity.x, 0, rb.velocity.z);
            rb.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
            isJumping = true;
            jumpCount++;
        }
        if (jumpCount >= maxJumpCount)
        {
            // Reset the character to the starting position after using all jumps
            transform.position = startingPosition;
            jumpCount = 0;
        }
    }        
    
    // Apply gravity to the character
    void ApplyGravity()
    {
         // Apply gravity using Unity's built-in Physics.gravity
        if (!isJumping)
        {
            rb.AddForce(Physics.gravity, ForceMode.Acceleration);
        }
        else if (isGrounded){
            // Check if the character touches the ground after a jump
            if (Physics.Raycast(transform.position, Vector3.down, 0.5f))
            {
                isJumping = false;
                isGrounded = true;
                jumpCount = 0;
            }
        }
        
    }
}
