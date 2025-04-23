/*****************************************************************************
// File Name :GameManager
// Author : Keely J.Hansen
// Creation Date April 20, 2025
// Brief Description : This makes it to be able to be seen in the game 
*****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour

{
    public GameObject CompleteFirstLevelUI;
    public GameObject CompleteSecondLevelUI;
    public GameObject DoorOpenUI;
    /// <summary>
    /// the UI work of the game, it is so that you are actially be able to see the different levels on the gameplay screen
    /// </summary>
    
    public void CompleteLevelOne()
    {
        CompleteFirstLevelUI. SetActive(true);
    }
    public void CompleteLevelTwo()
    {
        CompleteSecondLevelUI.SetActive(true);
    }
    public void DoorOpen()
    {
        DoorOpenUI.SetActive(true);
    }

}
