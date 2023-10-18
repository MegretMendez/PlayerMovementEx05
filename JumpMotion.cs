using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class JumpMotion : MonoBehaviour
{
    
    private CharacterController character_controller;

    //JumpVariables
    private Vector3 PlayerVelocity;
    private bool groundedPlayer;
    public float JumpHeight = 0.5f; 
    private bool jumpPressed = false;
    private float gravityForce = -9.81f;
    
    // Start is called before the first frame update
    void Start()
    {
        character_controller=GetComponent<CharacterController>();
    }

    void Update()
    {
        MovementJump();
    }

    void MovementJump(){
        groundedPlayer = character_controller.isGrounded;
        //if on the ground, stop vertical movement
        if(groundedPlayer){ 
            PlayerVelocity.y = 0.0f;
        }

        //if jump button is pressed and player is on the ground, jump the player
        if(jumpPressed && groundedPlayer){
            PlayerVelocity.y += Mathf.Sqrt(JumpHeight*gravityForce*-1.0f); //how the player is going to jump
            jumpPressed = false;
        }
        PlayerVelocity.y += gravityForce * Time.deltaTime;
        character_controller.Move(PlayerVelocity * Time.deltaTime);
    }
    public void OnJump(){
       //Check if there is no vertical movement
       if(character_controller.velocity.y == 0){
        jumpPressed = true;
       }
    }
}
