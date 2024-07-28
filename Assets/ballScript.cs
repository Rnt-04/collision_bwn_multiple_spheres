using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballScript : MonoBehaviour
{
    public Transform target;
    public float speed= 50f;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
            Vector3 direction = target.position - transform.position;
            rb = GetComponent<Rigidbody>();
            rb.AddForce (direction*speed, ForceMode.Force);
    }

    // Update is called once per frame
    void Update(){}
}
