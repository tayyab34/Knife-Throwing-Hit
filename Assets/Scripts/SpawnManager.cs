using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject knifePrefab;
    void Start()
    {
        //Knife Spawn at start
        Instantiate(knifePrefab, transform.position, knifePrefab.transform.rotation);
    }

    void Update()
    {
        //Knife Spawning
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Instantiate(knifePrefab, transform.position, knifePrefab.transform.rotation);
        } 
    }  
}
