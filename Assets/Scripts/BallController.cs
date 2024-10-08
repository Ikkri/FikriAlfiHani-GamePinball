using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float maxSpeed;

    private Rigidbody rig;
    
    // Start is called before the first frame update
    private void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (rig.velocity.magnitude > maxSpeed)
        {
            rig.velocity = rig.velocity.normalized * maxSpeed;
        }
    }
}
