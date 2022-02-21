using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject knifePrefab;
    private int StartDelay = 2;
    private float Delay = 1;
    private GameObject target;
    public bool Spacepressed;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPos", StartDelay, Delay);
        Spacepressed = GameObject.Find("Knife").GetComponent<KnifeMovement>().spacepressed;
        target = GameObject.Find("Target");
    }

    // Update is called once per frame
    void Update()
    {
            
    }
    private void SpawnPos()
    {
        if (target != null)
        {
            Instantiate(knifePrefab, transform.position, knifePrefab.transform.rotation);

        }
    }
       
}
