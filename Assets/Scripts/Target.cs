using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private int health = 100;
    private float speed = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Rotate Target
        transform.Rotate(Vector3.right, speed * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        //Target collide with knife
        if (collision.gameObject.CompareTag("Knife"))
        {
            collision.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            collision.gameObject.transform.parent = gameObject.transform;
        }
    }
    //Adding Health
    public void AddHealth(int Health)
    {
        health += Health;
        if (health == 0)
        {
            Destroy(gameObject);
        }
    }
}
