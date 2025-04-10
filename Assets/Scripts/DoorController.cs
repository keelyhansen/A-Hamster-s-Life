/*****************************************************************************
// File Name : DoorController
// Author : Keely J.Hansen
// Creation Date : March 29, 2025
//
// Brief Description : This allows the door to be opened to the next scene 
*****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorController : MonoBehaviour
{
    /// <summary>
    /// this collider allows the player to be able to walk into the portal on the game and move into the next level
    /// </summary>
    /// <param name="collidedObject"></param>
    private void OnTriggerEnter(Collider collidedObject)
    {
        if (collidedObject.gameObject.name == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
