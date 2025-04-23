/*****************************************************************************
// File Name : TextPlayerAction
// Author : Keely J.Hansen
// Creation Date : April 22, 2025
//
// Brief Description : this script is not currently being used because I keep on have a few errors while working through it but it is able to make the doors open with the "E" key once fixed
*****************************************************************************/using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextPlayerActions : MonoBehaviour
{
   /* [SerializeField]
    private TextMeshPro UseText;
    [SerializeField]
    private Transform Camera;
    [SerializeField]
    private float MaxUseDistance = 5f;
    [SerializeField]
    private LayerMask UseLayers;

    private void OnUse()
    {
        if(Physics.Raycast(Camera.position, Camera.forward, out RaycastHit hit, MaxUseDistance, UseLayers))
        {
            if (hit.collider.TryGetComponent<Door>(out Door door))
            {
                if (door.IsOpen)
                {
                    door.Close();
                }
                else
                {
                    door.Open(transform.position);
                }
            }
        }
    }
    // Update is called once per frame
    private void Update()
    {
        if (!Physics.Raycast(Camera.position,Camera.forward, out RaycastHit hit,MaxUseDistance, UseLayers) && hit.collider.TryGetComponent<Door>(out Door door))
        { 
            if (door.IsOpen)
            {
                UseText.SetText("Close \"E\"");
            }
            UseText.gameObject.SetActive(true);
            UseText.transform.position = hit.point - (hit.point - Camera.position).normalized * 0.01f;
            UseText.transform.rotation = Quaternion.LookRotation((hit.point - Camera.position).normalized);
        }
        else
        {
            UseText.gameObject.SetActive(false);
        }
    }*/
}
