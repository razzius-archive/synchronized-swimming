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
        if (Input.GetKey(KeyCode.UpArrow)) {
            vVel = 1;
        } else if (Input.GetKey(KeyCode.DownArrow)) {
            vVel = -1;
        } else {
            vVel = 0;
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            hVel = -1;
        } else if (Input.GetKey(KeyCode.RightArrow)) {
            hVel = 1;
        } else {
            hVel = 0;
        }

        Vector2 velocities = new Vector2(hVel * runSpeed, vVel * runSpeed);
        
        body.velocity = velocities;
    }
}
