using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public bool isPlayer01;
    public float speed;
    public Rigidbody2D rb;

    private float movement;

    void Update() 
    {
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, sidewayForce * 10, 0, ForceMode.VelocityChange);
        }

        if(Input.GetKey("s"))
        {
            rb.AddForce(-Force * 10, 0, 0, ForceMode.VelocityChange);
        }


}
