﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Vector3 maxSpeed;

    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        MaxSpeed();

        if (Input.GetAxis("Horizontal") > 0)
        {
            rb.AddForce(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            rb.AddForce(Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetAxis("Vertical") > 0)
        {
            rb.AddForce(Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            rb.AddForce(Vector3.forward * speed * Time.deltaTime);
        }
    }

    private void MaxSpeed()
    {
        if(rb.velocity.x >= maxSpeed.x)
        {
            rb.velocity = maxSpeed;
        }

        if (rb.velocity.x <= -maxSpeed.x)
        {
            rb.velocity = -maxSpeed;
        }

        if (rb.velocity.z >= maxSpeed.z)
        {
            rb.velocity = maxSpeed;
        }

        if (rb.velocity.z <= -maxSpeed.z)
        {
            rb.velocity = -maxSpeed;
        }

    }
}
