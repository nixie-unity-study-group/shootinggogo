﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public float bulletSpeed = 0.1f;
    public float bulletBorderY = 6;
    public bool isUp = true;

    private Vector2 currentPosition;
    private Vector2 nextPosition;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isUp)
        {
            if (transform.position.y < bulletBorderY)
            {
                Vector2 currentPosition = new Vector2(transform.position.x, transform.position.y);
                Vector2 nextPosition = new Vector2(transform.position.x, bulletBorderY);
                transform.position = Vector2.MoveTowards(currentPosition, nextPosition, bulletSpeed);
            }
            else
            {
                Object.Destroy(this.gameObject);
            }
        }
        else
        {
            if (transform.position.y > bulletBorderY)
            {
                Vector2 currentPosition = new Vector2(transform.position.x, transform.position.y);
                Vector2 nextPosition = new Vector2(transform.position.x, bulletBorderY);
                transform.position = Vector2.MoveTowards(currentPosition, nextPosition, bulletSpeed);
            }
            else
            {
                Object.Destroy(this.gameObject);
            }
        }
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (gameObject.tag == "PlayerBullet"
            && other.tag == "Enemy")
        {
            Object.Destroy(this.gameObject);
        }
        if (gameObject.tag == "EnemyBullet"
             && other.tag == "Player")  {
            Object.Destroy(this.gameObject);
        }
    }
}

 


