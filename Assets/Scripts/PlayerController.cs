using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    private float speed = 1000;
    public GameObject camera;

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Add force to player in direction of the focal point (and camera)
        float horizontalInput = Input.GetAxis("Horizontal");
        playerRb.AddForce(new Vector3(horizontalInput, 0f, 0f) * speed * Time.deltaTime);
        
        Vector3 cameraPosition = transform.position + new Vector3(0f, 5f, -15f);
        camera.transform.position = cameraPosition;
        
    }

}
