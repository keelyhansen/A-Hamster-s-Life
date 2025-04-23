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
    // Start is called before the first frame update
    void Start()
    {
        Speed = 7f;
    }

    // Update is called once per frame
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
