using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle02 : MonoBehaviour
{
    public bool isPlayer02;
    public float speed;
    public Rigidbody2D rb;

    private float movement;

    void Update() 
    {
        if (isPlayer02)
        {
            movement = Input.GetAxisRaw("Vertical2");
        }
        else
        {
            movement = Input.GetAxisRaw("Vertical");
        }

        rb.velocity = new Vector2(rb.velocity.x, movement * speed);
    }

}
