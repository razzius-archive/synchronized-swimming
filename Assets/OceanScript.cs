using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OceanScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnCollisionEnter2D(Collision2D collision) {
    	Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "Circle") {
            Destroy(collision.gameObject);
        }
    }
}
