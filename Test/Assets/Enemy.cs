﻿    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float speed;

    public Transform[] points = new Transform[2];

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        if(transform.position.x >= points[0].position.x)
        {
            transform.eulerAngles = new Vector3(0, -180, 0);
        }
        else if (transform.position.x <= points[1].position.x)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
    }
}
