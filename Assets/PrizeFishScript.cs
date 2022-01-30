using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrizeFishScript : MonoBehaviour
{
    GameObject circle = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (circle) {
            transform.position = circle.gameObject.transform.position;
            // transform.rotation = new Vector3(0, 0, 0);
        }
    }
    
    void OnCollisionEnter2D(Collision2D collision) {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "Circle") {
            GetComponent<PolygonCollider2D>().enabled = false;
            // Physics2D.IgnoreCollision(GetComponent<PolygonCollider2D>(), collision.gameObject.GetComponent<Collider2D>());
            transform.position = collision.gameObject.transform.position;
            circle = collision.gameObject;
        }
    }
}
