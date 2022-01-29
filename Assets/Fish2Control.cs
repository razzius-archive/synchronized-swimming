using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish2Control : MonoBehaviour
{
    public Rigidbody2D body;
    // IDictionary<KeyCode, Vector2> = new Dictionary
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
        if (Input.GetKey(KeyCode.W)) {
            vVel = 1;
        } else if (Input.GetKey(KeyCode.S)) {
            vVel = -1;
        } else {
            vVel = 0;
        }
        if (Input.GetKey(KeyCode.A)) {
            hVel = -1;
        } else if (Input.GetKey(KeyCode.D)) {
            hVel = 1;
        } else {
            hVel = 0;
        }

        Vector2 velocities = new Vector2(hVel * runSpeed, vVel * runSpeed);
        
        body.velocity = velocities;
    }
}
