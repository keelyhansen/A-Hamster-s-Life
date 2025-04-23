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

    // Update is called once per frame
    void Update()
    {
        healthText.text = " Health: " + (int)health;
    }

}
