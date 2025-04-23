/*****************************************************************************
// File Name : Door
// Author : Keely J.Hansen
// Creation Date : April 22, 2025
//
// Brief Description : this is connected to the other door script, this one activates the roation of the door or the the sliding mechanic
*****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public bool IsOpen = false;
    [SerializeField]
    private bool IsRotatatingDoor = true;
    [SerializeField]
    private float Speed = 1f;
    [Header("Rotation Configs")]
    [SerializeField]
    private float RotationAmount = 90f;
    [SerializeField]
    private float ForwardDirection = 0;

    private Vector3 StartRotation;
    private Vector3 Forward;

    private Coroutine AnimationCoroutine;
    /// <summary>
    /// the awake announces the position and direction the door will move 
    /// </summary>
    private void Awake()
    {
        StartRotation = transform.rotation.eulerAngles;
        // since "forward" actually is pointing into the door frame, i am choosing a dirrection to think about as "forward"(right)
        Forward = transform.right;
    }
    /// <summary>
    /// the user postion open allows the door to be able to when the player gets close enough to it to end up hitting the "E" key
    /// </summary>
    /// <param name="UserPosition"></param>
    public void Open(Vector3 UserPosition) 
    { 
        if (!IsOpen)
        {
            if (AnimationCoroutine != null)
            {
                StopCoroutine(AnimationCoroutine);
            }
            if (IsRotatatingDoor)
            {
                float dot = Vector3.Dot(Forward, (UserPosition - transform.position).normalized);
                Debug.Log($"Dot:{dot.ToString("N3")}");
                AnimationCoroutine = StartCoroutine(DoRotationOpen(dot)); 
            }
        }
    }
    /// <summary>
    /// the IEnumerator is what rotattes the door, it has all the code that is needed to do the rotation how its supposed to move and what the speed of it opening would be like
    /// </summary>
    /// <param name="ForwardAmount"></param>
    /// <returns></returns>
    private IEnumerator DoRotationOpen(float ForwardAmount)
    {
        Quaternion startRotation = transform.rotation;
        Quaternion endRotation;
        if (ForwardAmount >= ForwardDirection)
        {
            endRotation = Quaternion.Euler(new Vector3(0, StartRotation.y - RotationAmount, 0));
        }
        else
        {
            endRotation = Quaternion.Euler(new Vector3(0, StartRotation.y + RotationAmount, 0));
        }
        IsOpen = true;
        float time = 0;
        while (time < 1)
        {
            transform.rotation = Quaternion.Slerp(startRotation, endRotation, time);
            yield return null;
            time += Time.deltaTime * Speed;
        }
    }
    /// <summary>
    /// the close code is there to close the door when the player is done walking through( it does not do it atuomatically, the player has to hit the "e" key again to close the door
    /// </summary>
    public void Close()
    {
        if (IsOpen)
        {
            if (AnimationCoroutine != null)
            {
                StopCoroutine(AnimationCoroutine);

            }
            if (IsRotatatingDoor)
            {
                AnimationCoroutine = StartCoroutine(DoRotationClose());
            }
        }
    }
    /// <summary>
    ///  it the same with the close code thos is the rotation process of it closing and how fast it should close 
    /// </summary>
    /// <returns></returns>
    private IEnumerator DoRotationClose() 
    {
        Quaternion startRotation = transform.rotation;
        Quaternion endRotation = Quaternion.Euler(StartRotation);

        IsOpen = false;

        float time = 0;
        while (time < 1)
        {
            transform.rotation = Quaternion.Slerp(startRotation, endRotation, time);
            yield return null;
            time += Time.deltaTime * Speed;
        }
    }
}
