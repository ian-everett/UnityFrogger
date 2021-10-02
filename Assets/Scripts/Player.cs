using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Sprite playerUp, playerDown, playerLeft, playerRight;

    private SpriteRenderer sr;

    void Start()
    {
        Debug.Log("Start");
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        UpdatePosition();
    }

    private void UpdatePosition()
    {
        Vector2 pos = transform.localPosition;

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            sr.sprite = playerUp;
            pos += Vector2.up;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            sr.sprite = playerDown;
            pos += Vector2.down;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            sr.sprite = playerRight;
            pos += Vector2.right;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            sr.sprite = playerLeft;
            pos += Vector2.left;
        }

        transform.localPosition = pos;
    }
}
