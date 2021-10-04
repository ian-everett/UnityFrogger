using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float moveSpeed = 5f;
    public bool rightToLeft = true;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (rightToLeft)
        {
            rb.velocity = Vector2.left * moveSpeed;
        }
        else
        {
            rb.velocity = Vector2.right * moveSpeed; 
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (rightToLeft)
        {
            if (transform.position.x <= -8.5)
            {
                rb.position = new Vector2(9, rb.position.y);
            }
        }
        else
        {
            if (transform.position.x >= 8.5)
            {
                rb.position = new Vector2(-9, rb.position.y);
            }
        }
    } 
}
