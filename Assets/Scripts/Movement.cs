using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{

    private Rigidbody rb;
    private float speed = 500f;

    private float flashSpeed = .75f;
    private float flashTimer = .75f;

    public Material[] materials;

    private int currentmaterial = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        gameObject.GetComponentInChildren<MeshRenderer>().material = materials[currentmaterial];
    }

    // Update is called once per frame
    void Update()
    {
        if (flashTimer <= 0)
        {
            currentmaterial = (currentmaterial + 1) % materials.Length;
            flashTimer = flashSpeed;
            gameObject.GetComponentInChildren<MeshRenderer>().material = materials[currentmaterial];
            if (currentmaterial == 1) flashTimer /= 10; 
        }
        rb.AddForce(new Vector3(0, 0, -speed) * Time.deltaTime);
        if (transform.position.z <= 0f)
        {
            GameObject.Destroy(gameObject);
        }
        flashTimer -= Time.deltaTime;
    }
}
