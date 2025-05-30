/*****************************************************************************
// File Name : SecondFollowPlayer
// Author : Keely J.Hansen
// Creation Date : March 29, 2025
//
// Brief Description : Used for the cameras location and position 
*****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondFollowPlayer : MonoBehaviour
{

    [SerializeField] private GameObject player;
    [SerializeField] private Vector3 offset;


    void Start()
    {
        offset = new Vector3(-35, 15, 0);
    }

    /// <summary>
    /// Gets called just before the next frame begins
    /// </summary>

    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
