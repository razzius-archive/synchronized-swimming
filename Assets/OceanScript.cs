using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OceanScript : MonoBehaviour
{
    public AudioSource source;
    public Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnCollisionEnter2D(Collision2D collision) {
    	Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "Circle") {
            source.Play();
            Destroy(collision.gameObject);
            canvas.gameObject.SetActive(true);
        }
    }
}
