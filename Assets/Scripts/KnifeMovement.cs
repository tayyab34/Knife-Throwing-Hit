using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeMovement : MonoBehaviour
{
    private float force = 500f;
    private Rigidbody KnifeRb;
    private Target target;
    public bool spacepressed = false;
    // Start is called before the first frame update
    void Start()
    {
        KnifeRb = GetComponent<Rigidbody>();
        target = GameObject.Find("Target").GetComponent<Target>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            KnifeRb.AddForce(Vector3.forward * force, ForceMode.Impulse);
            spacepressed = true;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Target"))
        {
            target.AddHealth(-10);
        }
        //if (collision.gameObject.CompareTag("Knife"))
        //{
        //    KnifeRb.AddForce(Vector3.forward * -force, ForceMode.Impulse);
        //}
    }
}
