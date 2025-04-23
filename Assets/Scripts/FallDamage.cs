
/*****************************************************************************
// File Name : FallDamage
// Author : Keely J.Hansen
// Creation Date : April 22, 2025
//
// Brief Description : This script is meant to have the player take damage when they fall down 
*****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FallDamage : MonoBehaviour
{
    [SerializeField] Transform groundCheck;
    [SerializeField] float groundDistance = 0.2f;
    [SerializeField] LayerMask groundLayer;
    [SerializeField] float fallThressholdVelocity = 5f;

    private bool grounded;
    private Rigidbody rb;

    private Animator animator;
    /// <summary>
    /// I called a lot of ground methods to see if the player was touching the ground and this method is meant to take damage based on the range that you are from the ground so if you are close 
    /// to the ground you won't get hurt but if you are far up then you take damage 
    /// </summary>
    private void Awake()
    {
       // animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }
    public void Update()
    {
        bool previousGrounded = grounded;
        grounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundLayer, QueryTriggerInteraction.Ignore);
        if (previousGrounded && grounded)
        {
            Debug.Log("Do damage: " + (rb.velocity.y < -fallThressholdVelocity));
            if (rb.velocity.y < -fallThressholdVelocity) 
            {
                float damage = Mathf.Abs(rb.velocity.y + -fallThressholdVelocity);
                Debug.Log("Damage Dealt: " + damage);
            }
        }
       ///Code that I plan on keeping to look through to figure out my problem with the collision method 
        
        
        // animator.SetBool("grounded", grounded);
    }
    /*private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Stairs")
        {
            /*print("enter");
            enterPos = transform.position;
            if(exitPos.y - enterPos.y > 2)
            {
                print("falling dog");*/

    //PlayerHealth.health -= 5 * exitPos.y - enterPos.y;
    //}
    //}
    /*private void OnCollisionExit(Collision col)
    {
        if (col.gameObject.name == "Stairs")
        {
            print("exit");

            exitPos = transform.position;
            
        }
    }*/

}
