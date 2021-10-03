using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Sprite playerUp, playerDown, playerLeft, playerRight;

    private SpriteRenderer sr;
    private Rigidbody2D rb;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        UpdatePosition();
    }

    private void UpdatePosition()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            sr.sprite = playerUp;
            rb.MovePosition(rb.position + Vector2.up);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            sr.sprite = playerDown;
            rb.MovePosition(rb.position + Vector2.down);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            sr.sprite = playerRight;
            rb.MovePosition(rb.position + Vector2.right);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            sr.sprite = playerLeft;
            rb.MovePosition(rb.position + Vector2.left);
        }

        /*
         * Add boundries
         */
        Vector2 pos = transform.position;
        if (pos.x > 8)
            pos.x = 8;
        else if (pos.x < -8)
            pos.x = -8;
        else if (pos.y > 6)
            pos.y = 6;
        else if (pos.y < -6)
            pos.y = -6;
        transform.position = pos;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.tag);
    }
}
