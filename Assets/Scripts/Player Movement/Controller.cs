﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float moveSpeed = 6f;
    Vector2 movement;
    private Rigidbody2D rb;
   //public Camera viewCamera;
    Vector3 velocity;

    public int health;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {

        velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized * moveSpeed;

        velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized * moveSpeed;

     
    }

    private void FixedUpdate()
    {
        rb.velocity = velocity;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Player Lost health! Took " + damage + " damage.");
    }
}
