using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] collectables;
    float spawn_y = .5f;
    float spawn_z = 450;
    float movementSpeed = 20f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 0f, .5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        int index = UnityEngine.Random.Range(0, collectables.Length);
        Vector3 spawnpos = new Vector3(UnityEngine.Random.Range(-24, 24), spawn_y, spawn_z);
        Instantiate(collectables[index], spawnpos, collectables[index].transform.rotation);
    }
}
