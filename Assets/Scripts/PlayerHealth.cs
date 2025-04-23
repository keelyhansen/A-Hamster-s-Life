/*****************************************************************************
// File Name : PlayerHealth
// Author : Keely J.Hansen
// Creation Date : April 22, 2025
//
// Brief Description : this script is used to place the health text on the screen 
*****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using TMPro;


public class PlayerHealth : MonoBehaviour
{
    public static float health;
    public TMP_Text healthText;
    // Start is called before the first frame update
    void Start()
    {
        health = 100;
    }
    /// <summary>
    /// in both the start and the update signifies how much health the player will have and what the text will look like on the screen once the game starts
    /// </summary>
    // Update is called once per frame
    void Update()
    {
        healthText.text = " Health: " + (int)health;
    }
    
}
