using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //This variable is to control the player´s speed
    public float speed;
    //The part o Pablo that is affected by physics
    private Rigidbody2D pablo;
    //The vector that will keep track of the change in pablo´s movement
    private Vector3 movement;
    //This variable controls animations
    private Animator animator;



    void Start()
    {
        //Set pablo to be RigidBody that is attached to the player gameobject
        pablo = GetComponent<Rigidbody2D>();
        //It is atached to the player´s animator
        animator = GetComponent<Animator>();
    }
    void FixedUpdate()
    {
        movement = Vector3.zero;
        //(0,0,0)
        movement.x = Input.GetAxisRaw("Horizontal");//Left,right, A, D-1,1
        //Debug.Log("X input; " + movement.x);
        movement.y = Input.GetAxisRaw("Vertical");
        // Debug.Log("Y input; " + movement.y);
        updateanimationandmove();
        //it separates all related to animations and movement to make it more organized
    void updateanimationandmove()
    {
            //why move the dude if there is no input
            if (movement != Vector3.zero)
            {
                MoveCharacter();
                //Sends float values to the animator for the animations to work 
                animator.SetFloat("moveX", movement.x);
                animator.SetFloat("moveY", movement.y);
                animator.SetBool("moving", true);
            }
            else
            {
                animator.SetBool("moving", false);
            }
        }
    }
    void MoveCharacter()
    {
        //speed = 3
        //pos = (3,0)
        //movement = (-1,0) aka, moving left
        //movement = movement * speed -> (-2,0)
        //FRAMES!!!!! 60fps
        //movement = movemment*deta time (it has a decent speed)
        // pos - movement = (2,0)
        pablo.MovePosition(transform.position + (movement * speed * Time.deltaTime));
    }
}
