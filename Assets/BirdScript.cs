using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    private Rigidbody2D body;
    public Canvas canvas;
    public Fish1Control player1;
    public Fish2Control player2;
    public GameObject target = null;
    
    // Start is called before the first frame update
    void Start()
    {
    	body = GetComponent<Rigidbody2D>();
    	canvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null) {
            Vector2 diff = new Vector2(target.transform.position.x - transform.position.x, target.transform.position.y - transform.position.y);
            body.velocity = body.velocity + diff / 10f;
            return;
        }
        body.velocity = new Vector3(2 * Mathf.Sin(Time.time), Mathf.Cos(Time.time * 2), 0);
    }
    
    void OnCollisionEnter2D(Collision2D collision) {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "Circle") {
            player1.gameOver = true;
            player2.gameOver = true;
            Destroy(collision.gameObject);
            canvas.gameObject.SetActive(true);
            target = player1.gameObject;
        }


        if (collision.gameObject.name == "RedFish") {
            Destroy(collision.gameObject);
            target = player2.gameObject;
        }
        if (collision.gameObject.name == "BlueFish") {
            Destroy(collision.gameObject);
            target = player1.gameObject;
        }
    }
}
