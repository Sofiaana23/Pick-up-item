using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private List<string> inventory;

    // Start is called before the first frame update
    void Start()
    {
        inventory = new List<string>();
    }

    public void Collect(string collectable)
    {
        inventory.Add(collectable);
        Display();
    }

    void Display()
    {
        int i = 0;
        string logEntry = "Current Inventory";

        foreach (string collectable in inventory)
        {
            logEntry += "\n\tGame Object ";
            logEntry += i;
            logEntry += ": ";
            logEntry += collectable;
            i++;
        }

        Debug.Log(logEntry);
    }
}
