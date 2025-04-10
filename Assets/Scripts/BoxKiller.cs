/*****************************************************************************
// File Name : BoxKiller
// Author : Keely J.Hansen
// Creation Date : March 29, 2025
//
// Brief Description : this is script is used to know how the player will die if colliding with one of the boxes 
*****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoxKiller : MonoBehaviour
{
    [SerializeField] private float loadDelay = 1.5f;
    [SerializeField] private int dyingYValue = -9;

    private bool isDead = false;
    /// <summary>
    /// this collision here allows the player to be able to die when it is attacked by an enemy
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Enemy")
        {
            GetComponent<MeshRenderer>().enabled = false;

            GetComponent<PlayerController>().enabled = false;

            GetComponent<Rigidbody>().isKinematic = false;

            Die();
        }
    }
    /// <summary>
    /// the screen will reload to either the place that the player starts once dying 
    /// </summary>
    private void Die()
    {
        isDead = true;


        Invoke("ReloadScene", loadDelay);
    }
    /// <summary>
    /// this is the reload script
    /// </summary>
    void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    /// <summary>
    /// this is how the player is able to die when falling off of a screen
    /// </summary>
    void Update()
    {
        if (transform.position.y < dyingYValue && !isDead)
        {
            Die();
        }
    }
    // Start is called before the first frame update
   

   
}
