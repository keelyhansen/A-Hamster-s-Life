/*****************************************************************************
// File Name : FollowPlayer
// Author : Keely J.Hansen
// Creation Date : March 29, 2025
//
// Brief Description : Used for the cameras location and position 
*****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
   
    [SerializeField] private GameObject player;
    [SerializeField] private Vector3 offset;
    public float rotationSpeed = 100f;

    
    void Start()
    {
        offset = new Vector3(70, 154, -155);
    }

    /// <summary>
    /// Gets called just before the next frame begins
    /// </summary>

    void Update()
    {
        //float horizontalInput = Input.GetAxis("Horizontal");
        //float verticalInput = Input.GetAxis("Vertical");


       // transform.Rotate(Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime);
        //transform.Rotate(Vector3.right,  -verticalInput * rotationSpeed * Time.deltaTime);

        transform.position = player.transform.position + offset;
    }
}
