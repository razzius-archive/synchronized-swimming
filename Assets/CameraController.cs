using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public float offset;
    public float smoothTime = 0.15f;
    // public float offsetSmoothing;
    private Vector3 velocity = Vector3.zero;
    Camera camera_;
    
    // Start is called before the first frame update
    void Start()
    {
        camera_ = GetComponent<Camera>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (player == null) {
            return;
        }
        /* Vector3 viewPos = camera_.WorldToViewportPoint(player.transform.position); */
        /* Debug.Log(viewPos); */
        /* if (viewPos.x > .65 || viewPos.y > ) { */
        /*     smoothTime = 0; */
        /* } */
        /* Vector3 delta = player.transform.position - camera_.ViewportToWorldPoint(new Vector3(0.5f, 0.35f, viewPos.z)); //(new Vector3(0.5, 0.5, point.z)); */
        /* Vector3 destination = transform.position + delta; */
        /* transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, smoothTime); */
        Vector3 targetPosition = new Vector3(0, player.transform.position.y, transform.position.z);
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
