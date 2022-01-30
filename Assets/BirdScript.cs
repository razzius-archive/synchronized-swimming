using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    private Rigidbody2D body;
    public Canvas canvas;
    
    // Start is called before the first frame update
    void Start()
    {
    	body = GetComponent<Rigidbody2D>();
    	canvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        body.velocity = new Vector3(2 * Mathf.Sin(Time.time), Mathf.Cos(Time.time * 2), 0);
    }
    
    void OnCollisionEnter2D(Collision2D collision) {
        Destroy(collision.gameObject);
        canvas.gameObject.SetActive(true);
    }
}
