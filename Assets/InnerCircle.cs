using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InnerCircle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");
        foreach (GameObject player in players) {
            Physics2D.IgnoreCollision(player.GetComponent<CapsuleCollider2D>(), GetComponent<Collider2D>());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
