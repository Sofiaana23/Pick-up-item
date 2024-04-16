using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    private Rigidbody rb;
    private float speed = 500f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(new Vector3(0, 0, -speed) * Time.deltaTime);
        if (transform.position.z <= 0f)
        {
            GameObject.Destroy(gameObject);
        }
    }
}
