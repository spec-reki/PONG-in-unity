using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public bool isPlayer01;
    public bool isPlayer02;
    public float speed;
    public Rigidbody2D rb;

    private float movement;

    void Update() 
    {
        if (isPlayer01)
        {
            movement = Input.GetAxisRaw("Vertical");
        }
        
        if (isPlayer02)
        {
            movement = Input.GetAxisRaw("Vertical2");
        }

        rb.velocity = new Vector2(rb.velocity.x, movement * speed);
    }

}
