
/*****************************************************************************
// File Name : Enemy
// Author : Keely J.Hansen
// Creation Date : April 22, 2025
//
// Brief Description : this is the Ai factor of the enemy, it allows the movement responce of enemy and what it is looking for 
*****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float MaxSpeed;
    private float Speed;

    private Collider[] hitColliders;
    private RaycastHit Hit;

    public float SightRanger;
    public float DetectionRange;

    public Rigidbody rb;
    public GameObject Target;

    private bool seePlayer;
    /// <summary>
    /// we have the range speed of the enemy in the start here, it is the maximum speed that athe enemy can go 
    /// </summary>
    void Start()
    {
        Speed = 7f;
    }

    /// <summary>
    /// In the update is where the actual code is being used, it allows the enemy to navigate towrds the player if it is sce4en in a specific distance/ range, where it is supposed to go if it doesn't see the player
    /// and so on , it makes the enemy move in general and what it is meant to do if it actually seeas the enemy
    /// </summary>
    void Update()
    {
        if (seePlayer) 
        {
            hitColliders = Physics.OverlapSphere(transform.position, DetectionRange);
            foreach (var HitCollider in hitColliders)
            {
                if(HitCollider.tag == "Player")
                {
                    Target = HitCollider.gameObject;
                    seePlayer = true;
                }
            }
        }
        else
        {
            if (Physics.Raycast(transform.position,(Target.transform.position - transform.position),out Hit, SightRanger))
            {
                if(Hit.collider.tag != "Player")
                { 
                    seePlayer = false;
                }
                else
                {
                    var Heading = Target.transform.position - transform.position;
                    var Distance = Heading.magnitude;
                    var Direcation = Heading / Distance;

                    Vector3 Move = new Vector3(Direcation.x * Speed, 0, Direcation.z * Speed);
                    rb.velocity = Move;
                    transform.forward = Move;
                }
            }
        }
    }
}
