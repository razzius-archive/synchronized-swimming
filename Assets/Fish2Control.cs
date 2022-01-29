using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish1Control : MonoBehaviour
{
    public Rigidbody2D body;
    float hVel = 0;
    float vVel = 0;

    float runSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        hVel = Input.GetAxis("Horizontal");
        vVel = Input.GetAxis("Vertical");

        Vector2 velocities = new Vector2(hVel * runSpeed, vVel * runSpeed);
        
        body.velocity = velocities;
    }
}
