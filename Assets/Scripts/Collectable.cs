using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Inventory inventory;
            if (collision.gameObject.TryGetComponent<Inventory>(out inventory))
            {
                // Only get to this block if its a player, and has an Inventory script attached
                inventory.Collect(gameObject.name);
                GameObject.Destroy(gameObject);
            }
        }
    }
}
