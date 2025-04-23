/*****************************************************************************
// File Name :SecondLevelTrigger
// Author : Keely J.Hansen
// Creation Date April 20, 2025
//
// Brief Description : announces the start of the second level
*****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// The start of the second level will be announces with the this class
/// </summary>
public class SecondLevelTrigger : MonoBehaviour
{
    public GameManager gameManager;
     /// <summary>
     /// the trigger is used to call inside unity it make it call the second level after hitting a specific point
     /// </summary>
    private void OnTriggerEnter()
    {
        gameManager.CompleteLevelOne();
    }
}
