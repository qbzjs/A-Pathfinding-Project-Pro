﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    public float speed;
    public int damage;

    void Start()
    {
        damage = 25;
        Destroy(gameObject, 4f);
        Debug.Log("Fireball shot");
        if(tag == "bossFireball")
        {
            damage = 5;
        }
    }

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Destroy(gameObject,5f);
     
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(this.tag == "Fireball")
        {
            if (collision.tag == "enemy")
            {
                Destroy(gameObject);
            }
        }

        if (tag == "bossFireball" && collision.tag == "Player")
        {
            collision.GetComponent<PlayerStats>().TakeDamage(damage);
        }
    }
}