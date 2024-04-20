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

    private void OnCollisionEnter(Collision other)
    {
         VerifyPlayer_AddInventory(other.gameObject);
    }

    private void VerifyPlayer_AddInventory(GameObject other)
    {
        if (other.CompareTag("Player"))
        {
            Inventory inventory;
            if (other.TryGetComponent<Inventory>(out inventory))
            {
                // Only get to this block if its a player, and has an Inventory script attached
                inventory.Collect(name);
                GameObject.Destroy(gameObject);
            }
        }
    }
}
