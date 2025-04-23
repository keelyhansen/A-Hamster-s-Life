/*****************************************************************************
// File Name : PlayerController
// Author : Keely J.Hansen
// Creation Date : March 29, 2025
//
// Brief Description : the way to controll the player
*****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private PlayerInput playerInput;
    [SerializeField] private float playerSpeed = 20f;
    

    private Rigidbody rb;
    private Vector3 playerMovement;
    /// <summary>
    /// the rb and the playerinput are there so that i am able to get a rigidbody and my players input action map sucessfully from the unity page 
    /// </summary>
    /// 
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerInput.currentActionMap.Enable();
    }
    /// <summary>
    /// the input value here is used to move the players speed and movement smoothly
    /// </summary>
    /// <param name="iValue"></param>
    void OnMove(InputValue iValue)
    {
        Vector2 inputMovementValue = iValue.Get<Vector2>();
        playerMovement.x = inputMovementValue.x * playerSpeed;
        playerMovement.z = inputMovementValue.y * playerSpeed;
    }

    /// <summary>
    /// this allows to the player to sucessfully move around 
    /// </summary>
    void Update()
    {
        rb.velocity = new Vector3(playerMovement.x, rb.velocity.y, playerMovement.z);
    }
   
}
