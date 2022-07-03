using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
   public bool isPlayer01;
   public float speed;
   public Rigidbody2D rb;
   public Vector3 startPosition;

    private float movement;

    void Start() {
        startPosition = transform.position;
    }


    void Update()
    {
        if( isPlayer01)
        {
            movement = Input.GetAxisRaw("Vertical");
        }    
        else
        {
            movement = Input.GetAxisRaw("Vertical2");
        }

        rb.velocity = new Vector2(rb.velocity.x, movement * speed);
    }

    public void Reset() {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
    }
}

